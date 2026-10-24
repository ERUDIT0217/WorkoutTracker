namespace WorkoutTracker
{
    partial class UserSelectForm
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
            lblTitle = new Label();
            cmbUsers = new ComboBox();
            btnSelect = new Button();
            btnDeleteUser = new Button();
            btnNewUser = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblTitle.Location = new Point(25, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(353, 21);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Оберіть або створіть профіль користувача:";
            // 
            // cmbUsers
            // 
            cmbUsers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsers.FormattingEnabled = true;
            cmbUsers.Location = new Point(25, 55);
            cmbUsers.Name = "cmbUsers";
            cmbUsers.Size = new Size(405, 28);
            cmbUsers.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.FromArgb(37, 99, 235);
            btnSelect.Cursor = Cursors.Hand;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSelect.ForeColor = Color.White;
            btnSelect.Location = new Point(25, 100);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(102, 35);
            btnSelect.TabIndex = 2;
            btnSelect.Text = "Увійти";
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(254, 226, 226);
            btnDeleteUser.Cursor = Cursors.Hand;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.FromArgb(185, 28, 28);
            btnDeleteUser.Location = new Point(260, 100);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(170, 35);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Видалити профіль";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnNewUser
            // 
            btnNewUser.BackColor = Color.FromArgb(16, 185, 129);
            btnNewUser.Cursor = Cursors.Hand;
            btnNewUser.FlatAppearance.BorderSize = 0;
            btnNewUser.FlatStyle = FlatStyle.Flat;
            btnNewUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewUser.ForeColor = Color.White;
            btnNewUser.Location = new Point(153, 100);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(91, 35);
            btnNewUser.TabIndex = 4;
            btnNewUser.Text = "+ Новий";
            btnNewUser.UseVisualStyleBackColor = false;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // UserSelectForm
            // 
            AcceptButton = btnSelect;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 178);
            Controls.Add(btnNewUser);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnSelect);
            Controls.Add(cmbUsers);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserSelectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вибір профілю — WorkoutTracker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private ComboBox cmbUsers;
        private Button btnSelect;
        private Button btnDeleteUser;
        private Button btnNewUser;
    }
}