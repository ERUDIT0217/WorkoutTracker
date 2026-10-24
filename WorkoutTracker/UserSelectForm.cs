using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class UserSelectForm : Form
    {
        public string SelectedUser { get; private set; } = string.Empty;
        private bool _isDarkTheme = false;

        public UserSelectForm(bool isDarkTheme = false)
        {
            InitializeComponent();
            _isDarkTheme = isDarkTheme;
            ApplyTheme(_isDarkTheme);
            LoadExistingUsers();
        }

        private void LoadExistingUsers()
        {
            cmbUsers.Items.Clear();

            string dir = AppDomain.CurrentDomain.BaseDirectory;
            if (Directory.Exists(dir))
            {
                var files = Directory.GetFiles(dir, "workouts_*.json");
                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    if (fileName.Length > 14)
                    {
                        string username = fileName.Substring(9, fileName.Length - 5 - 9);
                        cmbUsers.Items.Add(username);
                    }
                }
            }

            if (cmbUsers.Items.Count > 0)
            {
                cmbUsers.SelectedIndex = 0;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, оберіть профіль зі списку або створіть новий.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SelectedUser = cmbUsers.SelectedItem?.ToString() ?? string.Empty;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            using (var inputForm = new InputForm(_isDarkTheme))
            {
                if (inputForm.ShowDialog(this) == DialogResult.OK)
                {
                    string newUsername = inputForm.EnteredText.Trim();

                    if (string.IsNullOrWhiteSpace(newUsername))
                        return;

                    foreach (char c in Path.GetInvalidFileNameChars())
                    {
                        if (newUsername.Contains(c))
                        {
                            MessageBox.Show("Ім'я містить недопустимі символи.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    string path = $"workouts_{newUsername}.json";

                    if (File.Exists(path))
                    {
                        MessageBox.Show($"Профіль «{newUsername}» вже існує!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadExistingUsers();
                        cmbUsers.SelectedItem = newUsername;
                        return;
                    }

                    try
                    {
                        File.WriteAllText(path, "[]");
                        LoadExistingUsers();
                        cmbUsers.SelectedItem = newUsername;
                        MessageBox.Show($"Профіль «{newUsername}» успішно створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Не вдалося створити профіль: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedItem == null)
            {
                MessageBox.Show("Оберіть профіль для видалення.", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string username = cmbUsers.SelectedItem.ToString();

            var confirm = MessageBox.Show(
                $"Ви дійсно бажаєте видалити профіль «{username}» та всі його дані?",
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string path = $"workouts_{username}.json";
                try
                {
                    if (File.Exists(path))
                    {
                        File.Delete(path);
                    }
                    MessageBox.Show("Профіль успішно видалено.", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExistingUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося видалити файл: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void ApplyTheme(bool isDark)
        {
            _isDarkTheme = isDark;

            if (_isDarkTheme)
            {
                var formBg = Color.FromArgb(20, 20, 22);
                var cardBg = Color.FromArgb(32, 33, 36);
                var inputBg = Color.FromArgb(42, 43, 46);
                var textLight = Color.FromArgb(240, 240, 240);
                var borderDark = Color.FromArgb(60, 62, 66);

                this.BackColor = formBg;
                this.ForeColor = textLight;

                lblTitle.ForeColor = textLight;

                cmbUsers.BackColor = inputBg;
                cmbUsers.ForeColor = textLight;

                btnSelect.BackColor = Color.FromArgb(37, 99, 235);
                btnSelect.ForeColor = Color.White;
                btnSelect.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);

                btnNewUser.BackColor = Color.FromArgb(16, 185, 129);
                btnNewUser.ForeColor = Color.White;
                btnNewUser.FlatAppearance.BorderColor = Color.FromArgb(16, 185, 129);

                btnDeleteUser.BackColor = Color.FromArgb(55, 25, 25);
                btnDeleteUser.ForeColor = Color.FromArgb(245, 120, 120);
                btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 35);
            }
            else
            {
                var formBg = Color.FromArgb(226, 232, 240);
                var cardBg = Color.White;
                var textDark = Color.FromArgb(30, 41, 59);
                var buttonBorder = Color.FromArgb(209, 213, 219);

                this.BackColor = formBg;
                this.ForeColor = textDark;

                lblTitle.ForeColor = textDark;

                cmbUsers.BackColor = cardBg;
                cmbUsers.ForeColor = textDark;

                btnSelect.BackColor = Color.FromArgb(37, 99, 235);
                btnSelect.ForeColor = Color.White;
                btnSelect.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);

                btnNewUser.BackColor = Color.FromArgb(16, 185, 129);
                btnNewUser.ForeColor = Color.White;
                btnNewUser.FlatAppearance.BorderColor = Color.FromArgb(16, 185, 129);

                btnDeleteUser.BackColor = Color.FromArgb(254, 226, 226);
                btnDeleteUser.ForeColor = Color.FromArgb(185, 28, 28);
                btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            }
        }
    }
}