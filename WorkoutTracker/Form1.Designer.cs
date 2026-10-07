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
            dgvWorkouts = new DataGridView();
            groupBox1 = new GroupBox();
            btnDelete = new Button();
            btnSave = new Button();
            cmbActivityType = new ComboBox();
            label9 = new Label();
            numUserWeight = new NumericUpDown();
            label8 = new Label();
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
            label10 = new Label();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            lblSummary = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUserWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvWorkouts
            // 
            dgvWorkouts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.Location = new Point(1, 71);
            dgvWorkouts.MultiSelect = false;
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.RowHeadersWidth = 51;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkouts.Size = new Size(703, 662);
            dgvWorkouts.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cmbActivityType);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(numUserWeight);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnAddWorkout);
            groupBox1.Controls.Add(dtpDate);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(numWeightLifted);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(numReps);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(numSets);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(numDistance);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(numDuration);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Controls.Add(cmbWorkoutType);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(766, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 855);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Нове тренування";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 798);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(156, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Видалити вибране";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(6, 753);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(148, 29);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти у файл";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbActivityType
            // 
            cmbActivityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityType.FormattingEnabled = true;
            cmbActivityType.Items.AddRange(new object[] { "Біг", "Плавання", "Велосипед", "Ходьба" });
            cmbActivityType.Location = new Point(13, 185);
            cmbActivityType.Name = "cmbActivityType";
            cmbActivityType.Size = new Size(151, 28);
            cmbActivityType.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 162);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 19;
            label9.Text = "Тип кардіо:";
            // 
            // numUserWeight
            // 
            numUserWeight.Location = new Point(12, 55);
            numUserWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numUserWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numUserWeight.Name = "numUserWeight";
            numUserWeight.Size = new Size(150, 27);
            numUserWeight.TabIndex = 18;
            numUserWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 32);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 17;
            label8.Text = "Вага користувача (кг):";
            // 
            // btnAddWorkout
            // 
            btnAddWorkout.Location = new Point(6, 704);
            btnAddWorkout.Name = "btnAddWorkout";
            btnAddWorkout.Size = new Size(167, 29);
            btnAddWorkout.TabIndex = 16;
            btnAddWorkout.Text = "Додати тренування";
            btnAddWorkout.UseVisualStyleBackColor = true;
            btnAddWorkout.Click += btnAddWorkout_Click;
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(12, 663);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(151, 27);
            dtpDate.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 640);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 14;
            label7.Text = "Дата:";
            // 
            // numWeightLifted
            // 
            numWeightLifted.DecimalPlaces = 1;
            numWeightLifted.Location = new Point(13, 595);
            numWeightLifted.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numWeightLifted.Name = "numWeightLifted";
            numWeightLifted.Size = new Size(150, 27);
            numWeightLifted.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 572);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 12;
            label6.Text = "Вага снаряда (кг):";
            // 
            // numReps
            // 
            numReps.Location = new Point(12, 529);
            numReps.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numReps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReps.Name = "numReps";
            numReps.Size = new Size(150, 27);
            numReps.TabIndex = 11;
            numReps.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 506);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Повторення:";
            // 
            // numSets
            // 
            numSets.Location = new Point(13, 464);
            numSets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSets.Name = "numSets";
            numSets.Size = new Size(150, 27);
            numSets.TabIndex = 9;
            numSets.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 441);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 8;
            label4.Text = "Підходи:";
            // 
            // numDistance
            // 
            numDistance.DecimalPlaces = 2;
            numDistance.Location = new Point(13, 395);
            numDistance.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(150, 27);
            numDistance.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 372);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 6;
            label3.Text = "Дистанція (км):";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 259);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 5;
            // 
            // numDuration
            // 
            numDuration.Location = new Point(13, 325);
            numDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(150, 27);
            numDuration.TabIndex = 4;
            numDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 302);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 3;
            label2.Text = "Тривалість (хв):";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(13, 236);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Назва:";
            // 
            // cmbWorkoutType
            // 
            cmbWorkoutType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkoutType.FormattingEnabled = true;
            cmbWorkoutType.Items.AddRange(new object[] { "Кардіо", "Силове" });
            cmbWorkoutType.Location = new Point(13, 116);
            cmbWorkoutType.Name = "cmbWorkoutType";
            cmbWorkoutType.Size = new Size(151, 28);
            cmbWorkoutType.TabIndex = 1;
            cmbWorkoutType.SelectedIndexChanged += cmbWorkoutType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 93);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Тип тренування:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 28);
            label10.Name = "label10";
            label10.Size = new Size(58, 20);
            label10.TabIndex = 2;
            label10.Text = "Пошук:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblSummary);
            groupBox2.Location = new Point(1, 753);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(703, 102);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Підсумкова статистика";
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.Location = new Point(6, 45);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(331, 20);
            lblSummary.TabIndex = 0;
            lblSummary.Text = "Всього тренувань: 0 | Час: 0 хв | Калорії: 0 ккал";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 853);
            Controls.Add(groupBox2);
            Controls.Add(txtSearch);
            Controls.Add(label10);
            Controls.Add(groupBox1);
            Controls.Add(dgvWorkouts);
            MinimumSize = new Size(1100, 900);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutTracker";
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUserWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWorkouts;
        private GroupBox groupBox1;
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
        private Label label8;
        private NumericUpDown numUserWeight;
        private ComboBox cmbActivityType;
        private Label label9;
        private Label label10;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Label lblSummary;
    }
}
