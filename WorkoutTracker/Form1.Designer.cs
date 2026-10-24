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
            dgvWorkouts.Size = new Size(1167, 387);
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
            btnDelete.Location = new Point(915, 26);
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
            btnSave.Location = new Point(729, 26);
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
            // panelSummary
            // 
            panelSummary.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelSummary.BackColor = Color.White;
            panelSummary.Controls.Add(lblSummary);
            panelSummary.Controls.Add(lblSummaryTitle);
            panelSummary.Location = new Point(3, 488);
            panelSummary.Name = "panelSummary";
            panelSummary.Size = new Size(1165, 116);
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
            btnToggleTheme.Location = new Point(438, 26);
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
            btnOpenAddForm.Location = new Point(609, 26);
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
            btnAbout.Location = new Point(1106, 26);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(40, 33);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "❓";
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1168, 605);
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
    }
}
