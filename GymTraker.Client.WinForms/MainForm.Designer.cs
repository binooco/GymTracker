namespace GymTraker.Client.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка ресурсів
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dgvWorkouts = new DataGridView();
            groupBoxDetails = new GroupBox();
            dtpDate = new DateTimePicker();
            label4 = new Label();
            txtReps = new TextBox();
            label3 = new Label();
            txtWeight = new TextBox();
            label2 = new Label();
            txtExercise = new TextBox();
            label1 = new Label();
            panelButtons = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            groupBoxDetails.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // dgvWorkouts
            // 
            dgvWorkouts.AllowUserToAddRows = false;
            dgvWorkouts.AllowUserToDeleteRows = false;
            dgvWorkouts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.Location = new Point(12, 12);
            dgvWorkouts.MultiSelect = false;
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkouts.Size = new Size(520, 460);
            dgvWorkouts.TabIndex = 0;
            dgvWorkouts.SelectionChanged += dgvWorkouts_SelectionChanged;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxDetails.Controls.Add(dtpDate);
            groupBoxDetails.Controls.Add(label4);
            groupBoxDetails.Controls.Add(txtReps);
            groupBoxDetails.Controls.Add(label3);
            groupBoxDetails.Controls.Add(txtWeight);
            groupBoxDetails.Controls.Add(label2);
            groupBoxDetails.Controls.Add(txtExercise);
            groupBoxDetails.Controls.Add(label1);
            groupBoxDetails.Location = new Point(540, 12);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(300, 200);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Нове тренування";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(115, 25);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(170, 23);
            dtpDate.TabIndex = 8;
            dtpDate.ValueChanged += dtpDate_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 30);
            label4.Name = "label4";
            label4.Size = new Size(35, 15);
            label4.TabIndex = 7;
            label4.Text = "Дата:";
            // 
            // txtReps
            // 
            txtReps.Location = new Point(115, 155);
            txtReps.Name = "txtReps";
            txtReps.Size = new Size(170, 23);
            txtReps.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 159);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 5;
            label3.Text = "Повторення:";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(115, 115);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(170, 23);
            txtWeight.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 119);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 3;
            label2.Text = "Вага:";
            // 
            // txtExercise
            // 
            txtExercise.Location = new Point(115, 74);
            txtExercise.Name = "txtExercise";
            txtExercise.Size = new Size(170, 23);
            txtExercise.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 78);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 1;
            label1.Text = "Вправа:";
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnUpdate);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnLoad);
            panelButtons.Location = new Point(540, 220);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(300, 150);
            panelButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(10, 118);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 30);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Видалити вибране";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(10, 82);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(280, 30);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Зберегти зміни";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(10, 46);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати тренування";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(10, 10);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(280, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Оновити список";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // MainForm
            // 
            ClientSize = new Size(854, 484);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxDetails);
            Controls.Add(dgvWorkouts);
            Name = "MainForm";
            Text = "GymTracker – Клієнт";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            groupBoxDetails.ResumeLayout(false);
            groupBoxDetails.PerformLayout();
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWorkouts;
        private System.Windows.Forms.GroupBox groupBoxDetails;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtExercise;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}