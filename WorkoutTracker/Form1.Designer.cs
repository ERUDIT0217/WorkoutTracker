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
            btnDelete = new Button();
            btnSave = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblSummary = new Label();
            panelSummary = new Panel();
            lblSummaryTitle = new Label();
            btnToggleTheme = new Button();
            btnOpenAddForm = new Button();
            btnAbout = new Button();
            chkEnableDateFilter = new CheckBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            cmbProfiles = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
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
            dgvWorkouts.Size = new Size(1504, 393);
            dgvWorkouts.TabIndex = 0;
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
            btnDelete.Location = new Point(1141, 28);
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
            btnSave.Location = new Point(969, 29);
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
            txtSearch.Size = new Size(133, 30);
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
            // panelSummary
            // 
            panelSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSummary.BackColor = Color.White;
            panelSummary.Controls.Add(lblSummary);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Location = new Point(3, 494);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(1502, 116);
            panelSummary.TabIndex = 6;
            // 
            // lblSummaryTitle
            // 
            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblSummaryTitle.Location = new Point(17, 23);
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
            btnToggleTheme.Location = new Point(716, 27);
            btnToggleTheme.Name = "btnToggleTheme";
            btnToggleTheme.Size = new Size(147, 33);
            btnToggleTheme.TabIndex = 7;
            btnToggleTheme.Text = "🌙 Темна тема";
            btnToggleTheme.UseVisualStyleBackColor = false;
            btnToggleTheme.Click += btnToggleTheme_Click;
            // 
            // btnOpenAddForm
            // 
            btnOpenAddForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpenAddForm.BackColor = Color.FromArgb(37, 99, 235);
            btnOpenAddForm.Cursor = Cursors.Hand;
            btnOpenAddForm.FlatStyle = FlatStyle.Flat;
            btnOpenAddForm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnOpenAddForm.ForeColor = Color.White;
            btnOpenAddForm.Location = new Point(869, 29);
            btnOpenAddForm.Name = "btnOpenAddForm";
            btnOpenAddForm.Size = new Size(94, 33);
            btnOpenAddForm.TabIndex = 8;
            btnOpenAddForm.Text = "+ Додати";
            btnOpenAddForm.UseVisualStyleBackColor = false;
            btnOpenAddForm.Click += btnOpenAddForm_Click_1;
            // 
            // btnAbout
            // 
            btnAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAbout.BackColor = Color.FromArgb(243, 244, 246);
            btnAbout.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Segoe UI", 10F);
            btnAbout.ForeColor = Color.FromArgb(31, 41, 55);
            btnAbout.Location = new Point(1442, 29);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(40, 33);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "❓";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // chkEnableDateFilter
            // 
            chkEnableDateFilter.AutoSize = true;
            chkEnableDateFilter.Location = new Point(242, 30);
            chkEnableDateFilter.Name = "chkEnableDateFilter";
            chkEnableDateFilter.Size = new Size(159, 27);
            chkEnableDateFilter.TabIndex = 9;
            chkEnableDateFilter.Text = "Фільтр за датою";
            chkEnableDateFilter.UseVisualStyleBackColor = true;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(441, 29);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(107, 30);
            dtpStartDate.TabIndex = 10;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(590, 29);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(107, 30);
            dtpEndDate.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(416, 32);
            label1.Name = "label1";
            label1.Size = new Size(19, 23);
            label1.TabIndex = 12;
            label1.Text = "З";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 31);
            label2.Name = "label2";
            label2.Size = new Size(30, 23);
            label2.TabIndex = 13;
            label2.Text = "по";
            // 
            // cmbProfiles
            // 
            cmbProfiles.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbProfiles.FormattingEnabled = true;
            cmbProfiles.Location = new Point(1323, 29);
            cmbProfiles.Name = "cmbProfiles";
            cmbProfiles.Size = new Size(104, 31);
            cmbProfiles.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1505, 611);
            Controls.Add(cmbProfiles);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(chkEnableDateFilter);
            Controls.Add(btnAbout);
            Controls.Add(btnOpenAddForm);
            Controls.Add(btnToggleTheme);
            Controls.Add(panelSummary);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(dgvWorkouts);
            Font = new Font("Segoe UI", 10F);
            ForeColor = Color.Black;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WorkoutTracker";
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            panelSummary.ResumeLayout(false);
            panelSummary.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvWorkouts;
        private Button btnDelete;
        private Button btnSave;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblSummary;
        private Panel panelSummary;
        private Label lblSummaryTitle;
        private Button btnToggleTheme;
        private Button btnOpenAddForm;
        private Button btnAbout;
        private CheckBox chkEnableDateFilter;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label1;
        private Label label2;
        private ComboBox cmbProfiles;
    }
}
