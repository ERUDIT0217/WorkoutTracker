namespace WorkoutTracker
{
    partial class AddWorkoutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label8 = new Label();
            cmbActivityType = new ComboBox();
            lblNewWorkoutTitle = new Label();
            label9 = new Label();
            numUserWeight = new NumericUpDown();
            label1 = new Label();
            cmbWorkoutType = new ComboBox();
            btnAddWorkout = new Button();
            lblTitle = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label7 = new Label();
            numDuration = new NumericUpDown();
            numWeightLifted = new NumericUpDown();
            txtTitle = new TextBox();
            label6 = new Label();
            label3 = new Label();
            numReps = new NumericUpDown();
            numDistance = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            numSets = new NumericUpDown();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numUserWeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numReps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSets).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(65, 247);
            label8.Name = "label8";
            label8.Size = new Size(160, 20);
            label8.TabIndex = 43;
            label8.Text = "Вага користувача (кг):";
            // 
            // cmbActivityType
            // 
            cmbActivityType.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbActivityType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbActivityType.FlatStyle = FlatStyle.Flat;
            cmbActivityType.FormattingEnabled = true;
            cmbActivityType.Items.AddRange(new object[] { "Біг", "Плавання", "Велосипед", "Ходьба" });
            cmbActivityType.Location = new Point(332, 122);
            cmbActivityType.Name = "cmbActivityType";
            cmbActivityType.Size = new Size(169, 28);
            cmbActivityType.TabIndex = 42;
            // 
            // lblNewWorkoutTitle
            // 
            lblNewWorkoutTitle.AutoSize = true;
            lblNewWorkoutTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            lblNewWorkoutTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblNewWorkoutTitle.Location = new Point(183, 31);
            lblNewWorkoutTitle.Name = "lblNewWorkoutTitle";
            lblNewWorkoutTitle.Size = new Size(177, 28);
            lblNewWorkoutTitle.TabIndex = 22;
            lblNewWorkoutTitle.Text = "Нове тренування";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(331, 95);
            label9.Name = "label9";
            label9.Size = new Size(87, 20);
            label9.TabIndex = 41;
            label9.Text = "Тип кардіо:";
            // 
            // numUserWeight
            // 
            numUserWeight.Location = new Point(66, 273);
            numUserWeight.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numUserWeight.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numUserWeight.Name = "numUserWeight";
            numUserWeight.Size = new Size(169, 27);
            numUserWeight.TabIndex = 40;
            numUserWeight.Value = new decimal(new int[] { 70, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 169);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 23;
            label1.Text = "Тип тренування:";
            // 
            // cmbWorkoutType
            // 
            cmbWorkoutType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWorkoutType.FlatStyle = FlatStyle.Flat;
            cmbWorkoutType.FormattingEnabled = true;
            cmbWorkoutType.Items.AddRange(new object[] { "Кардіо", "Силове" });
            cmbWorkoutType.Location = new Point(67, 195);
            cmbWorkoutType.Name = "cmbWorkoutType";
            cmbWorkoutType.Size = new Size(169, 28);
            cmbWorkoutType.TabIndex = 24;
            cmbWorkoutType.SelectedIndexChanged += cmbWorkoutType_SelectedIndexChanged;
            // 
            // btnAddWorkout
            // 
            btnAddWorkout.BackColor = Color.FromArgb(37, 99, 235);
            btnAddWorkout.Cursor = Cursors.Hand;
            btnAddWorkout.FlatAppearance.BorderSize = 0;
            btnAddWorkout.FlatStyle = FlatStyle.Flat;
            btnAddWorkout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAddWorkout.ForeColor = Color.White;
            btnAddWorkout.Location = new Point(67, 529);
            btnAddWorkout.Name = "btnAddWorkout";
            btnAddWorkout.Size = new Size(188, 33);
            btnAddWorkout.TabIndex = 39;
            btnAddWorkout.Text = "Додати тренування";
            btnAddWorkout.UseVisualStyleBackColor = false;
            btnAddWorkout.Click += btnAddWorkout_Click_1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(67, 95);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(54, 20);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Назва:";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(67, 450);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(169, 27);
            dtpDate.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 337);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 26;
            label2.Text = "Тривалість (хв):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(67, 422);
            label7.Name = "label7";
            label7.Size = new Size(44, 20);
            label7.TabIndex = 37;
            label7.Text = "Дата:";
            // 
            // numDuration
            // 
            numDuration.Location = new Point(67, 364);
            numDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(169, 27);
            numDuration.TabIndex = 27;
            numDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numWeightLifted
            // 
            numWeightLifted.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numWeightLifted.DecimalPlaces = 1;
            numWeightLifted.Location = new Point(332, 450);
            numWeightLifted.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numWeightLifted.Name = "numWeightLifted";
            numWeightLifted.Size = new Size(169, 27);
            numWeightLifted.TabIndex = 36;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(66, 122);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(169, 27);
            txtTitle.TabIndex = 0;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(332, 422);
            label6.Name = "label6";
            label6.Size = new Size(131, 20);
            label6.TabIndex = 35;
            label6.Text = "Вага снаряда (кг):";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(332, 169);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 29;
            label3.Text = "Дистанція (км):";
            // 
            // numReps
            // 
            numReps.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numReps.Location = new Point(331, 363);
            numReps.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numReps.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numReps.Name = "numReps";
            numReps.Size = new Size(169, 27);
            numReps.TabIndex = 34;
            numReps.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numDistance
            // 
            numDistance.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numDistance.DecimalPlaces = 2;
            numDistance.Location = new Point(332, 196);
            numDistance.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(169, 27);
            numDistance.TabIndex = 30;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(331, 337);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 33;
            label5.Text = "Повторення:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(331, 247);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 31;
            label4.Text = "Підходи:";
            // 
            // numSets
            // 
            numSets.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numSets.Location = new Point(332, 270);
            numSets.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSets.Name = "numSets";
            numSets.Size = new Size(169, 27);
            numSets.TabIndex = 32;
            numSets.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancel.Location = new Point(332, 530);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(188, 33);
            btnCancel.TabIndex = 44;
            btnCancel.Text = "Скасувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddWorkoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 624);
            Controls.Add(btnCancel);
            Controls.Add(label8);
            Controls.Add(cmbActivityType);
            Controls.Add(lblNewWorkoutTitle);
            Controls.Add(label9);
            Controls.Add(numUserWeight);
            Controls.Add(label1);
            Controls.Add(cmbWorkoutType);
            Controls.Add(btnAddWorkout);
            Controls.Add(lblTitle);
            Controls.Add(dtpDate);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(numDuration);
            Controls.Add(numWeightLifted);
            Controls.Add(txtTitle);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(numReps);
            Controls.Add(numDistance);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(numSets);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddWorkoutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Нове тренування";
            ((System.ComponentModel.ISupportInitialize)numUserWeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWeightLifted).EndInit();
            ((System.ComponentModel.ISupportInitialize)numReps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private ComboBox cmbActivityType;
        private Label lblNewWorkoutTitle;
        private Label label9;
        private NumericUpDown numUserWeight;
        private Label label1;
        private ComboBox cmbWorkoutType;
        private Button btnAddWorkout;
        private Label lblTitle;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label7;
        private NumericUpDown numDuration;
        private NumericUpDown numWeightLifted;
        private TextBox txtTitle;
        private Label label6;
        private Label label3;
        private NumericUpDown numReps;
        private NumericUpDown numDistance;
        private Label label5;
        private Label label4;
        private NumericUpDown numSets;
        private Button btnCancel;
    }
}