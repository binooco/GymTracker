namespace GymTraker.Client.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">
        /// true if managed resources should be disposed; otherwise, false.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support.
        /// Do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvWorkouts = new DataGridView();
            groupBoxDetails = new GroupBox();
            labelReps = new Label();
            labelWeight = new Label();
            labelExercise = new Label();
            labelDate = new Label();
            txtReps = new TextBox();
            txtWeight = new TextBox();
            txtExercise = new TextBox();
            dtpDate = new DateTimePicker();
            panelButtons = new Panel();
            btnDelete = new Button();
            btnAdd = new Button();
            btnLoad = new Button();
            labelTitle = new Label();
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
            dgvWorkouts.Location = new Point(12, 50);
            dgvWorkouts.MultiSelect = false;
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.RowHeadersVisible = false;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkouts.Size = new Size(520, 380);
            dgvWorkouts.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            groupBoxDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxDetails.Controls.Add(labelReps);
            groupBoxDetails.Controls.Add(labelWeight);
            groupBoxDetails.Controls.Add(labelExercise);
            groupBoxDetails.Controls.Add(labelDate);
            groupBoxDetails.Controls.Add(txtReps);
            groupBoxDetails.Controls.Add(txtWeight);
            groupBoxDetails.Controls.Add(txtExercise);
            groupBoxDetails.Controls.Add(dtpDate);
            groupBoxDetails.Location = new Point(548, 50);
            groupBoxDetails.Name = "groupBoxDetails";
            groupBoxDetails.Size = new Size(320, 230);
            groupBoxDetails.TabIndex = 1;
            groupBoxDetails.TabStop = false;
            groupBoxDetails.Text = "Нове тренування";
            // 
            // labelReps
            // 
            labelReps.AutoSize = true;
            labelReps.Location = new Point(18, 169);
            labelReps.Name = "labelReps";
            labelReps.Size = new Size(77, 15);
            labelReps.TabIndex = 7;
            labelReps.Text = "Повторення:";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Location = new Point(18, 126);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(34, 15);
            labelWeight.TabIndex = 6;
            labelWeight.Text = "Вага:";
            // 
            // labelExercise
            // 
            labelExercise.AutoSize = true;
            labelExercise.Location = new Point(18, 82);
            labelExercise.Name = "labelExercise";
            labelExercise.Size = new Size(49, 15);
            labelExercise.TabIndex = 5;
            labelExercise.Text = "Вправа:";
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Location = new Point(18, 38);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(35, 15);
            labelDate.TabIndex = 4;
            labelDate.Text = "Дата:";
            // 
            // txtReps
            // 
            txtReps.Location = new Point(120, 166);
            txtReps.Name = "txtReps";
            txtReps.PlaceholderText = "наприклад, 8";
            txtReps.Size = new Size(180, 23);
            txtReps.TabIndex = 3;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(120, 123);
            txtWeight.Name = "txtWeight";
            txtWeight.PlaceholderText = "кг, напр. 80";
            txtWeight.Size = new Size(180, 23);
            txtWeight.TabIndex = 2;
            // 
            // txtExercise
            // 
            txtExercise.Location = new Point(120, 79);
            txtExercise.Name = "txtExercise";
            txtExercise.PlaceholderText = "Жим лежачи, присідання…";
            txtExercise.Size = new Size(180, 23);
            txtExercise.TabIndex = 1;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(120, 35);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(180, 23);
            dtpDate.TabIndex = 0;
            // 
            // panelButtons
            // 
            panelButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panelButtons.Controls.Add(btnDelete);
            panelButtons.Controls.Add(btnAdd);
            panelButtons.Controls.Add(btnLoad);
            panelButtons.Location = new Point(548, 286);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(320, 144);
            panelButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(18, 92);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(282, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити вибране тренування";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(18, 53);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(282, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Додати тренування";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(18, 14);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(282, 30);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Оновити список тренувань";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitle.Location = new Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(856, 30);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "GymTracker – облік тренувань";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 442);
            Controls.Add(labelTitle);
            Controls.Add(panelButtons);
            Controls.Add(groupBoxDetails);
            Controls.Add(dgvWorkouts);
            MinimumSize = new Size(900, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GymTracker – клієнт";
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
        private System.Windows.Forms.Label labelReps;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelExercise;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtExercise;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label labelTitle;
    }
}