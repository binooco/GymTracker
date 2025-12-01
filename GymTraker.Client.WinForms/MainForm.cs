using GymTraker.Client.WinForms.Models;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Json;

namespace GymTraker.Client.WinForms
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;
        private int? _editingId;

        public MainForm()
        {
            InitializeComponent();

            // ⚠️ твій HTTPS порт!
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7136")
            };

            dgvWorkouts.AutoGenerateColumns = true;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await LoadWorkoutsAsync();
        }

        // ===== Завантаження списку за обрану дату =====
        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadWorkoutsAsync();
        }

        private async Task LoadWorkoutsAsync()
        {
            try
            {
                var date = dtpDate.Value.Date;
                var url = $"/api/workouts?date={date:yyyy-MM-dd}";

                var workouts = await _httpClient.GetFromJsonAsync<List<Workout>>(url);
                dgvWorkouts.DataSource = workouts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні тренувань:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ===== Зміна дати = інша "сторінка" =====
        private async void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            // нічого не редагуємо, просто дивимось інший день
            _editingId = null;
            txtExercise.Clear();
            txtWeight.Clear();
            txtReps.Clear();
            groupBoxDetails.Text = "Нове тренування";

            await LoadWorkoutsAsync();
        }

        // ===== Читання полів =====
        private bool TryReadInputs(out DateTime date, out string exercise, out double weight, out int reps)
        {
            date = dtpDate.Value.Date;
            exercise = txtExercise.Text.Trim();
            weight = 0;
            reps = 0;

            if (string.IsNullOrWhiteSpace(exercise))
            {
                MessageBox.Show("Введіть назву вправи.", "Валідація",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!double.TryParse(
                    txtWeight.Text.Replace(',', '.'),
                    NumberStyles.Any,
                    CultureInfo.InvariantCulture,
                    out weight))
            {
                MessageBox.Show("Невірний формат ваги.", "Валідація",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtReps.Text, out reps))
            {
                MessageBox.Show("Невірна кількість повторень.", "Валідація",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // ===== Додавання =====
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddWorkoutAsync();
        }

        private async Task AddWorkoutAsync()
        {
            try
            {
                if (!TryReadInputs(out var date, out var exercise, out var weight, out var reps))
                    return;

                var dto = new WorkoutCreateDto
                {
                    Date = date,
                    ExerciseName = exercise,
                    Weight = weight,
                    Reps = reps
                };

                var response = await _httpClient.PostAsJsonAsync("/api/workouts", dto);
                if (!response.IsSuccessStatusCode)
                {
                    var message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Не вдалося додати тренування.\n" + message,
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClearInput();
                await LoadWorkoutsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при додаванні тренування:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Очистка полів (але НЕ дати!) =====
        private void ClearInput()
        {
            _editingId = null;
            txtExercise.Clear();
            txtWeight.Clear();
            txtReps.Clear();
            groupBoxDetails.Text = "Нове тренування";
            // dtpDate НЕ чіпаємо – дата = "сторінка"
        }

        // ===== Видалення =====
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteSelectedAsync();
        }

        private async Task DeleteSelectedAsync()
        {
            try
            {
                if (dgvWorkouts.CurrentRow == null)
                {
                    MessageBox.Show("Виберіть тренування для видалення.",
                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (dgvWorkouts.CurrentRow.DataBoundItem is not Workout workout)
                {
                    MessageBox.Show("Не вдалося отримати вибране тренування.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Видалити тренування #{workout.Id} ({workout.ExerciseName})?",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm != DialogResult.Yes)
                    return;

                var response = await _httpClient.DeleteAsync($"/api/workouts/{workout.Id}");
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Не вдалося видалити тренування. Код: " + response.StatusCode,
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClearInput();
                await LoadWorkoutsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні тренування:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ===== Вибір рядка =====
        private void dgvWorkouts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkouts.CurrentRow?.DataBoundItem is not Workout workout)
                return;

            _editingId = workout.Id;

            // ДАТУ НЕ ЧІПАЄМО – вона керується DateTimePickerʼом
            txtExercise.Text = workout.ExerciseName;
            txtWeight.Text = workout.Weight.ToString(CultureInfo.InvariantCulture);
            txtReps.Text = workout.Reps.ToString();

            groupBoxDetails.Text = $"Редагування #{workout.Id}";
        }

        // ===== Оновлення (PUT) =====
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            await UpdateWorkoutAsync();
        }

        private async Task UpdateWorkoutAsync()
        {
            try
            {
                if (_editingId is null)
                {
                    MessageBox.Show("Виберіть тренування для редагування.",
                        "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (!TryReadInputs(out var date, out var exercise, out var weight, out var reps))
                    return;

                var dto = new WorkoutCreateDto
                {
                    Date = date,
                    ExerciseName = exercise,
                    Weight = weight,
                    Reps = reps
                };

                var response = await _httpClient.PutAsJsonAsync($"/api/workouts/{_editingId.Value}", dto);

                if (!response.IsSuccessStatusCode)
                {
                    var message = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Не вдалося оновити тренування.\n" + message,
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ClearInput();
                await LoadWorkoutsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при оновленні тренування:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}