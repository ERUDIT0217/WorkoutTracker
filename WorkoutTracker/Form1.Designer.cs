namespace WorkoutTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvWorkouts = new DataGridView();
            cmbActivityType = new ComboBox();
            label9 = new Label();
            numUserWeight = new NumericUpDown();
            btnAddWorkout = new Button();
            dtpDate = new DateTimePicker();
            label7 = new Label();
            numWeightLifted = new NumericUpDown();
            label6 = new Label();
            numReps = new NumericUpDown();
            label5 = new Label();
            numSets = new NumericUpDown();
            label4 = new Label();
            numDistance = new NumericUpDown();
            label3 = new Label();
            txtTitle = new TextBox();
            numDuration = new NumericUpDown();
            label2 = new Label();
            lblTitle = new Label();
            cmbWorkoutType = new ComboBox();
            label1 = new Label();
            btnDelete = new Button();
            btnSave = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblSummary = new Label();
            panelWorkoutInput = new Panel();
            label8 = new Label();
            lblNewWorkoutTitle = new Label();
            panelSummary = new Panel();
            lblSummaryTitle = new Label();
            btnToggleTheme = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUserWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            panelWorkoutInput.SuspendLayout();
            panelSummary.SuspendLayout();
            SuspendLayout();
            // 
            // dgvWorkouts
            // 
            dgvWorkouts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkouts.BackgroundColor = Color.White;
            dgvWorkouts.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 243, 246);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvWorkouts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.EnableHeadersVisualStyles = false;
            dgvWorkouts.Location = new Point(1, 82);
            dgvWorkouts.MultiSelect = false;
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.RowHeadersVisible = false;
            dgvWorkouts.RowHeadersWidth = 51;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkouts.Size = new Size(886, 751);
            dgvWorkouts.TabIndex = 0;
            // 
            // cmbActivityType
            // 
            cmbActivityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityType.FlatStyle = FlatStyle.Flat;
            cmbActivityType.FormattingEnabled = true;
            cmbActivityType.Items.AddRange(new object[] { "Біг", "Плавання", "Велосипед", "Ходьба" });
            cmbActivityType.Location = new Point(13, 262);
            cmbActivityType.Name = "cmbActivityType";
            cmbActivityType.Size = new Size(169, 31);
            cmbActivityType.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 235);
            label9.Name = "label9";
            label9.Size = new Size(98, 23);
            label9.TabIndex = 19;
            label9.Text = "Тип кардіо:";
            // 
            // numUserWeight
            // 
            numUserWeight.Location = new Point(12, 108);
            numUserWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numUserWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numUserWeight.Name = "numUserWeight";
            numUserWeight.Size = new Size(169, 30);
            numUserWeight.TabIndex = 18;
            numUserWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // btnAddWorkout
            // 
            btnAddWorkout.BackColor = Color.FromArgb(37, 99, 235);
            btnAddWorkout.Cursor = Cursors.Hand;
            btnAddWorkout.FlatAppearance.BorderSize = 0;
            btnAddWorkout.FlatStyle = FlatStyle.Flat;
            btnAddWorkout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddWorkout.ForeColor = Color.White;
            btnAddWorkout.Location = new Point(13, 863);
            btnAddWorkout.Name = "btnAddWorkout";
            btnAddWorkout.Size = new Size(188, 33);
            btnAddWorkout.TabIndex = 16;
            btnAddWorkout.Text = "Додати тренування";
            btnAddWorkout.UseVisualStyleBackColor = false;
            btnAddWorkout.Click += btnAddWorkout_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(12, 803);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(169, 30);
            dtpDate.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 768);
            label7.Name = "label7";
            label7.Size = new Size(51, 23);
            label7.TabIndex = 14;
            label7.Text = "Дата:";
            // 
            // numWeightLifted
            // 
            numWeightLifted.DecimalPlaces = 1;
            numWeightLifted.Location = new Point(12, 710);
            numWeightLifted.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numWeightLifted.Name = "numWeightLifted";
            numWeightLifted.Size = new Size(169, 30);
            numWeightLifted.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 684);
            label6.Name = "label6";
            label6.Size = new Size(148, 23);
            label6.TabIndex = 12;
            label6.Text = "Вага снаряда (кг):";
            // 
            // numReps
            // 
            numReps.Location = new Point(11, 634);
            numReps.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numReps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReps.Name = "numReps";
            numReps.Size = new Size(169, 30);
            numReps.TabIndex = 11;
            numReps.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 608);
            label5.Name = "label5";
            label5.Size = new Size(110, 23);
            label5.TabIndex = 10;
            label5.Text = "Повторення:";
            // 
            // numSets
            // 
            numSets.Location = new Point(12, 560);
            numSets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSets.Name = "numSets";
            numSets.Size = new Size(169, 30);
            numSets.TabIndex = 9;
            numSets.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 533);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 8;
            label4.Text = "Підходи:";
            // 
            // numDistance
            // 
            numDistance.DecimalPlaces = 2;
            numDistance.Location = new Point(12, 480);
            numDistance.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(169, 30);
            numDistance.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 454);
            label3.Name = "label3";
            label3.Size = new Size(128, 23);
            label3.TabIndex = 6;
            label3.Text = "Дистанція (км):";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(11, 324);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(140, 30);
            txtTitle.TabIndex = 5;
            // 
            // numDuration
            // 
            numDuration.Location = new Point(12, 400);
            numDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(169, 30);
            numDuration.TabIndex = 4;
            numDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 373);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 3;
            label2.Text = "Тривалість (хв):";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(12, 297);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 23);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Назва:";
            // 
            // cmbWorkoutType
            // 
            cmbWorkoutType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkoutType.FlatStyle = FlatStyle.Flat;
            cmbWorkoutType.FormattingEnabled = true;
            cmbWorkoutType.Items.AddRange(new object[] { "Кардіо", "Силове" });
            cmbWorkoutType.Location = new Point(13, 182);
            cmbWorkoutType.Name = "cmbWorkoutType";
            cmbWorkoutType.Size = new Size(169, 31);
            cmbWorkoutType.TabIndex = 1;
            cmbWorkoutType.SelectedIndexChanged += cmbWorkoutType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 156);
            label1.Name = "label1";
            label1.Size = new Size(139, 23);
            label1.TabIndex = 0;
            label1.Text = "Тип тренування:";
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.BackColor = Color.FromArgb(254, 226, 226);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(185, 28, 28);
            btnDelete.Location = new Point(711, 25);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(176, 33);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити вибране";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.White;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.FromArgb(30, 41, 59);
            btnSave.Location = new Point(524, 28);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(166, 33);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти у файл";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(18, 32);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 23);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Пошук:";
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Location = new Point(90, 29);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(230, 30);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummary.ForeColor = Color.FromArgb(30, 41, 59);
            lblSummary.Location = new Point(17, 61);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(407, 23);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Всього тренувань: 0 | Час: 0 хв | Калорії: 0 ккал";
            // 
            // panelWorkoutInput
            // 
            panelWorkoutInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelWorkoutInput.BackColor = Color.White;
            panelWorkoutInput.Controls.Add(label8);
            panelWorkoutInput.Controls.Add(cmbActivityType);
            panelWorkoutInput.Controls.Add(lblNewWorkoutTitle);
            panelWorkoutInput.Controls.Add(label9);
            panelWorkoutInput.Controls.Add(numUserWeight);
            panelWorkoutInput.Controls.Add(label1);
            panelWorkoutInput.Controls.Add(cmbWorkoutType);
            panelWorkoutInput.Controls.Add(btnAddWorkout);
            panelWorkoutInput.Controls.Add(lblTitle);
            panelWorkoutInput.Controls.Add(dtpDate);
            panelWorkoutInput.Controls.Add(label2);
            panelWorkoutInput.Controls.Add(label7);
            panelWorkoutInput.Controls.Add(numDuration);
            panelWorkoutInput.Controls.Add(numWeightLifted);
            panelWorkoutInput.Controls.Add(txtTitle);
            panelWorkoutInput.Controls.Add(label6);
            panelWorkoutInput.Controls.Add(label3);
            panelWorkoutInput.Controls.Add(numReps);
            panelWorkoutInput.Controls.Add(numDistance);
            panelWorkoutInput.Controls.Add(label5);
            panelWorkoutInput.Controls.Add(label4);
            panelWorkoutInput.Controls.Add(numSets);
            panelWorkoutInput.Location = new Point(908, 0);
            panelWorkoutInput.Name = "panelWorkoutInput";
            panelWorkoutInput.Size = new Size(259, 969);
            panelWorkoutInput.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 82);
            label8.Name = "label8";
            label8.Size = new Size(182, 23);
            label8.TabIndex = 21;
            label8.Text = "Вага користувача (кг):";
            // 
            // lblNewWorkoutTitle
            // 
            lblNewWorkoutTitle.AutoSize = true;
            lblNewWorkoutTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblNewWorkoutTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblNewWorkoutTitle.Location = new Point(11, 29);
            lblNewWorkoutTitle.Name = "lblNewWorkoutTitle";
            lblNewWorkoutTitle.Size = new Size(153, 23);
            lblNewWorkoutTitle.TabIndex = 0;
            lblNewWorkoutTitle.Text = "Нове тренування";
            // 
            // panelSummary
            // 
            panelSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSummary.BackColor = Color.White;
            panelSummary.Controls.Add(lblSummary);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Location = new Point(1, 853);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(886, 116);
            panelSummary.TabIndex = 6;
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblSummaryTitle.Location = new Point(17, 20);
            lblSummaryTitle.Name = "lblSummaryTitle";
            lblSummaryTitle.Size = new Size(203, 23);
            lblSummaryTitle.TabIndex = 0;
            lblSummaryTitle.Text = "Підсумкова статистика";
            // 
            // btnToggleTheme
            // 
            btnToggleTheme.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnToggleTheme.BackColor = Color.White;
            btnToggleTheme.Cursor = Cursors.Hand;
            btnToggleTheme.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnToggleTheme.FlatStyle = FlatStyle.Flat;
            btnToggleTheme.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnToggleTheme.ForeColor = Color.FromArgb(30, 41, 59);
            btnToggleTheme.Location = new Point(351, 28);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(147, 33);
            btnToggleTheme.TabIndex = 7;
            btnToggleTheme.Text = "🌙 Темна тема";
            btnToggleTheme.UseVisualStyleBackColor = false;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1168, 971);
            Controls.Add(btnToggleTheme);
            Controls.Add(panelSummary);
            Controls.Add(panelWorkoutInput);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvWorkouts);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            MinimumSize = new Size(1100, 1018);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutTracker";
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUserWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            panelWorkoutInput.ResumeLayout(false);
            panelWorkoutInput.PerformLayout();
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWorkouts;
        private ComboBox cmbWorkoutType;
        private Label label1;
        private NumericUpDown numDuration;
        private Label label2;
        private Label lblTitle;
        private TextBox txtTitle;
        private NumericUpDown numDistance;
        private Label label3;
        private NumericUpDown numReps;
        private Label label5;
        private NumericUpDown numSets;
        private Label label4;
        private NumericUpDown numWeightLifted;
        private Label label6;
        private DateTimePicker dtpDate;
        private Label label7;
        private Button btnAddWorkout;
        private Button btnDelete;
        private Button btnSave;
        private NumericUpDown numUserWeight;
        private ComboBox cmbActivityType;
        private Label label9;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblSummary;
        private Panel panelWorkoutInput;
        private Label lblNewWorkoutTitle;
        private Label label8;
        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Button btnToggleTheme;
    }
}
