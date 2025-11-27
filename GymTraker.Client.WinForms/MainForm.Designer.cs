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
            this.dgvWorkouts = new System.Windows.Forms.DataGridView();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.labelReps = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelExercise = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtExercise = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWorkouts
            // 
            this.dgvWorkouts.AllowUserToAddRows = false;
            this.dgvWorkouts.AllowUserToDeleteRows = false;
            this.dgvWorkouts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvWorkouts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkouts.Location = new System.Drawing.Point(12, 50);
            this.dgvWorkouts.MultiSelect = false;
            this.dgvWorkouts.Name = "dgvWorkouts";
            this.dgvWorkouts.ReadOnly = true;
            this.dgvWorkouts.RowHeadersVisible = false;
            this.dgvWorkouts.RowTemplate.Height = 25;
            this.dgvWorkouts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWorkouts.Size = new System.Drawing.Size(520, 380);
            this.dgvWorkouts.TabIndex = 0;
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxDetails.Controls.Add(this.labelReps);
            this.groupBoxDetails.Controls.Add(this.labelWeight);
            this.groupBoxDetails.Controls.Add(this.labelExercise);
            this.groupBoxDetails.Controls.Add(this.labelDate);
            this.groupBoxDetails.Controls.Add(this.txtReps);
            this.groupBoxDetails.Controls.Add(this.txtWeight);
            this.groupBoxDetails.Controls.Add(this.txtExercise);
            this.groupBoxDetails.Controls.Add(this.dtpDate);
            this.groupBoxDetails.Location = new System.Drawing.Point(548, 50);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(320, 230);
            this.groupBoxDetails.TabIndex = 1;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Нове тренування";
            // 
            // labelReps
            // 
            this.labelReps.AutoSize = true;
            this.labelReps.Location = new System.Drawing.Point(18, 169);
            this.labelReps.Name = "labelReps";
            this.labelReps.Size = new System.Drawing.Size(86, 15);
            this.labelReps.TabIndex = 7;
            this.labelReps.Text = "Повторення:";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(18, 126);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(36, 15);
            this.labelWeight.TabIndex = 6;
            this.labelWeight.Text = "Вага:";
            // 
            // labelExercise
            // 
            this.labelExercise.AutoSize = true;
            this.labelExercise.Location = new System.Drawing.Point(18, 82);
            this.labelExercise.Name = "labelExercise";
            this.labelExercise.Size = new System.Drawing.Size(44, 15);
            this.labelExercise.TabIndex = 5;
            this.labelExercise.Text = "Вправа:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(18, 38);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 15);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Дата:";
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(120, 166);
            this.txtReps.Name = "txtReps";
            this.txtReps.PlaceholderText = "наприклад, 8";
            this.txtReps.Size = new System.Drawing.Size(180, 23);
            this.txtReps.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(120, 123);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PlaceholderText = "кг, напр. 80";
            this.txtWeight.Size = new System.Drawing.Size(180, 23);
            this.txtWeight.TabIndex = 2;
            // 
            // txtExercise
            // 
            this.txtExercise.Location = new System.Drawing.Point(120, 79);
            this.txtExercise.Name = "txtExercise";
            this.txtExercise.PlaceholderText = "Жим лежачи, присідання…";
            this.txtExercise.Size = new System.Drawing.Size(180, 23);
            this.txtExercise.TabIndex = 1;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(120, 35);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 23);
            this.dtpDate.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right))));
            this.panelButtons.Controls.Add(this.btnDelete);
            this.panelButtons.Controls.Add(this.btnAdd);
            this.panelButtons.Controls.Add(this.btnLoad);
            this.panelButtons.Location = new System.Drawing.Point(548, 291);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(320, 139);
            this.panelButtons.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(18, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(282, 30);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Видалити вибране тренування";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(18, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(282, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати тренування";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(18, 14);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(282, 30);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Оновити список тренувань";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(856, 30);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "GymTracker – облік тренувань";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 442);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.dgvWorkouts);
            this.MinimumSize = new System.Drawing.Size(900, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymTracker – клієнт";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkouts)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

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