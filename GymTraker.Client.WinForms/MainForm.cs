using System.Net.Http;
using System.Net.Http.Json;
using GymTraker.Client.WinForms.Models;
using Microsoft.VisualBasic;

namespace GymTraker.Client.WinForms
{
    public partial class MainForm : Form
    {
        private readonly HttpClient _httpClient;



        public MainForm()
        {
            InitializeComponent();
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

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadWorkoutsAsync();
        }

        private async Task LoadWorkoutsAsync()
        {
            try
            {
                var workouts = await _httpClient.GetFromJsonAsync<List<Workout>>("/api/workouts");
                dgvWorkouts.DataSource = workouts;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при завантаженні тренувань:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            await AddWorkoutAsync();
        }

        private async Task AddWorkoutAsync()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtExercise.Text))
                {
                    MessageBox.Show("Введіть назву вправи.", "Валідація",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!double.TryParse(txtWeight.Text.Replace(',', '.'), System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out double weight))
                {
                    MessageBox.Show("Невірний формат ваги.", "Валідація",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtReps.Text, out int reps))
                {
                    MessageBox.Show("Невірна кількість повторень.", "Валідація",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var dto = new WorkoutCreateDto
                {
                    Date = dtpDate.Value.Date,
                    ExerciseName = txtExercise.Text.Trim(),
                    Weight = weight,
                    Reps = reps
                };

                var response = await _httpClient.PostAsJsonAsync("/api/workouts", dto);
                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Не вдалося додати тренування. Код: " + response.StatusCode,
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

        private void ClearInput()
        {
            txtExercise.Clear();
            txtWeight.Clear();
            txtReps.Clear();
            dtpDate.Value = DateTime.Today;
        }

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

                await LoadWorkoutsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка при видаленні тренування:\n" + ex.Message,
                    "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}