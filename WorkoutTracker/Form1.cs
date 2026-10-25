using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class Form1 : Form
    {
        private string _username;
        private WorkoutRepository _repository = new WorkoutRepository();
        private List<Workout> _workouts = new List<Workout>();
        private readonly BindingSource _bindingSource = new BindingSource();
        private bool _isModified = false;
        private bool _isDarkTheme = false;

        public Form1(string username, bool initialDarkTheme)
        {
            InitializeComponent();

            _username = username;
            _isDarkTheme = initialDarkTheme;
            _repository.SetUser(_username);
            this.Text = $"WorkoutTracker — Профіль: {_username}";

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
            this.FormClosing += Form1_FormClosing; 

            dgvWorkouts.CurrentCellDirtyStateChanged += dgvWorkouts_CurrentCellDirtyStateChanged;
            dgvWorkouts.CellValueChanged += dgvWorkouts_CellValueChanged;

            dgvWorkouts.RowPrePaint += dgvWorkouts_RowPrePaint;

            chkEnableDateFilter.CheckedChanged += chkEnableDateFilter_CheckedChanged;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;

            LoadProfilesIntoCombo();
            cmbProfiles.SelectedIndexChanged += cmbProfiles_SelectedIndexChanged;

            ConfigureGridColumnsExplicitly();

            _workouts = _repository.Load() ?? new List<Workout>();

            _bindingSource.DataSource = _workouts;
            dgvWorkouts.DataSource = _bindingSource;

            RefreshGrid();
            ApplyTheme();
        }

        private void ConfigureGridColumnsExplicitly()
        {
            dgvWorkouts.AutoGenerateColumns = false;
            dgvWorkouts.Columns.Clear();

            dgvWorkouts.AllowUserToAddRows = false;
            dgvWorkouts.AllowUserToDeleteRows = false;
            dgvWorkouts.ReadOnly = false;
            dgvWorkouts.MultiSelect = true;

            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            dgvWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvWorkouts.ColumnHeadersHeight = 35;
            dgvWorkouts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvWorkouts.Columns.Add(new DataGridViewCheckBoxColumn
            {
                HeaderText = "Виконано",
                DataPropertyName = "IsCompleted",
                FillWeight = 70,
                ReadOnly = false
            });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дата", DataPropertyName = "Date", FillWeight = 85, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Назва", DataPropertyName = "Title", FillWeight = 120, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Час, хв", DataPropertyName = "DurationInMinutes", FillWeight = 95, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Вага, кг", DataPropertyName = "UserWeightKg", FillWeight = 90, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Тип", DataPropertyName = "TypeTitle", FillWeight = 85, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Деталі", DataPropertyName = "Details", FillWeight = 165, ReadOnly = true });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Калорії", DataPropertyName = "Calories", FillWeight = 85, ReadOnly = true });
        }

        private void RefreshGrid()
        {
            string query = txtSearch.Text.Trim().ToLower();
            bool useDateFilter = chkEnableDateFilter.Checked;
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            var displayedWorkouts = _workouts.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(query))
            {
                displayedWorkouts = displayedWorkouts
                    .Where(w => w.Title != null && w.Title.ToLower().Contains(query));
            }

            if (useDateFilter)
            {
                displayedWorkouts = displayedWorkouts
                    .Where(w => w.Date.Date >= startDate && w.Date.Date <= endDate);
            }

            var resultList = displayedWorkouts.ToList();

            _bindingSource.DataSource = null;
            _bindingSource.DataSource = resultList;
            _bindingSource.ResetBindings(false);

            UpdateSummaryStatistic(resultList);
        }

        private void chkEnableDateFilter_CheckedChanged(object? sender, EventArgs e)
        {
            dtpStartDate.Enabled = chkEnableDateFilter.Checked;
            dtpEndDate.Enabled = chkEnableDateFilter.Checked;

            RefreshGrid();
        }

        private void dtpStartDate_ValueChanged(object? sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dtpEndDate_ValueChanged(object? sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvWorkouts_CurrentCellDirtyStateChanged(object? sender, EventArgs e)
        {
            if (dgvWorkouts.IsCurrentCellDirty)
            {
                dgvWorkouts.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dgvWorkouts_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvWorkouts.Columns[e.ColumnIndex].DataPropertyName == "IsCompleted")
            {
                _isModified = true;

                dgvWorkouts.InvalidateRow(e.RowIndex);

                UpdateSummaryStatistic(_workouts);
            }
        }

        private void dgvWorkouts_RowPrePaint(object? sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvWorkouts.Rows.Count)
            {
                var row = dgvWorkouts.Rows[e.RowIndex];

                if (row.DataBoundItem is Workout workout)
                {
                    if (workout.IsCompleted)
                    {
                        row.DefaultCellStyle.BackColor = _isDarkTheme ? Color.FromArgb(15, 50, 35) : Color.FromArgb(187, 247, 208);
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = _isDarkTheme ? Color.FromArgb(24, 24, 27) : Color.White;
                    }
                }
            }
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            var selectedWorkouts = new List<Workout>();
            if (dgvWorkouts.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvWorkouts.SelectedRows)
                {
                    if (row.DataBoundItem is Workout workout && !selectedWorkouts.Contains(workout))
                    {
                        selectedWorkouts.Add(workout);
                    }
                }
            }
            else if (dgvWorkouts.SelectedCells.Count > 0)
            {
                foreach (DataGridViewCell cell in dgvWorkouts.SelectedCells)
                {
                    if (cell.OwningRow?.DataBoundItem is Workout workout && !selectedWorkouts.Contains(workout))
                    {
                        selectedWorkouts.Add(workout);
                    }
                }
            }

            if (selectedWorkouts.Count == 0)
            {
                MessageBox.Show(
                    "Оберіть один або декілька рядків у таблиці для видалення.",
                    "Повідомлення",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            string confirmMessage = selectedWorkouts.Count == 1
                ? $"Ви дійсно бажаєте видалити тренування «{selectedWorkouts[0].Title}»?"
                : $"Ви дійсно бажаєте видалити обрані тренування ({selectedWorkouts.Count} шт.)?";

            var confirmResults = MessageBox.Show(
                confirmMessage,
                "Підтвердження видалення",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResults == DialogResult.Yes)
            {
                foreach (var workout in selectedWorkouts)
                {
                    _workouts.Remove(workout);
                }

                RefreshGrid();
                _isModified = true;
            }
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            try
            {
                _repository.Save(_workouts);
                _isModified = false;
                MessageBox.Show("Дані тренувань успішно збережено у файл workouts.json!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних у файл: {ex.Message}", "Помилка збереження", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.SuppressKeyPress = true;
                btnSave_Click(sender, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                e.SuppressKeyPress = true;
                btnDelete_Click(sender, EventArgs.Empty);
            }
        }

        private void Form1_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (!_isModified)
                return;

            var result = MessageBox.Show(
                "У вас є незбережені зміни. Бажаєте зберегти їх перед виходом?",
                "Незбережені дані",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _repository.Save(_workouts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося зберегти дані: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void UpdateSummaryStatistic(List<Workout> list)
        {
            int totalCount = list.Count;
            int completedCount = list.Where(w => w.IsCompleted).Count();
            int plannedCount = totalCount - completedCount;

            int totalMinutes = list.Sum(w => w.DurationInMinutes);

            double totalCalories = list.Where(w => w.IsCompleted).Sum(w => w.CalculateCaloriesBurned());

            lblSummary.Text = $"Всього: {totalCount} (Виконано: {completedCount}, Заплановано: {plannedCount}) | Загальний час: {totalMinutes} хв | Спалено: {totalCalories:F1} ккал";
        }

        private void ApplyTheme()
        {
            if (_isDarkTheme)
            {
                var formBg = Color.FromArgb(20, 20, 22);
                var cardBg = Color.FromArgb(32, 33, 36);
                var inputBg = Color.FromArgb(42, 43, 46);
                var textLight = Color.FromArgb(240, 240, 240);
                var borderDark = Color.FromArgb(60, 62, 66);

                this.BackColor = formBg;
                this.ForeColor = textLight;

                btnToggleTheme.Text = "☀️ Світла тема";
                btnToggleTheme.BackColor = cardBg;
                btnToggleTheme.ForeColor = textLight;
                btnToggleTheme.FlatAppearance.BorderColor = borderDark;

                btnSave.BackColor = cardBg;
                btnSave.ForeColor = textLight;
                btnSave.FlatAppearance.BorderColor = borderDark;

                btnDelete.BackColor = Color.FromArgb(55, 25, 25);
                btnDelete.ForeColor = Color.FromArgb(245, 120, 120);
                btnDelete.FlatAppearance.BorderColor = Color.FromArgb(90, 35, 35);

                btnOpenAddForm.BackColor = Color.FromArgb(50, 52, 58);
                btnOpenAddForm.ForeColor = Color.White;
                btnOpenAddForm.FlatAppearance.BorderColor = borderDark;

                panelSummary.BackColor = cardBg;

                lblSummaryTitle.ForeColor = textLight;
                lblSummary.ForeColor = textLight;
                lblSearch.ForeColor = textLight;

                txtSearch.BackColor = inputBg;
                txtSearch.ForeColor = textLight;

                cmbProfiles.BackColor = inputBg;
                cmbProfiles.ForeColor = textLight;

                dtpStartDate.CalendarForeColor = textLight;
                dtpStartDate.CalendarMonthBackground = cardBg;
                dtpStartDate.CalendarTitleBackColor = cardBg;
                dtpStartDate.CalendarTitleForeColor = textLight;

                dtpEndDate.CalendarForeColor = textLight;
                dtpEndDate.CalendarMonthBackground = cardBg;
                dtpEndDate.CalendarTitleBackColor = cardBg;
                dtpEndDate.CalendarTitleForeColor = textLight;

                dgvWorkouts.BackgroundColor = cardBg;
                dgvWorkouts.GridColor = borderDark;
                dgvWorkouts.DefaultCellStyle.BackColor = cardBg;
                dgvWorkouts.DefaultCellStyle.ForeColor = textLight;
                dgvWorkouts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(55, 60, 70);
                dgvWorkouts.DefaultCellStyle.SelectionForeColor = Color.White;

                dgvWorkouts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(28, 29, 31);
                dgvWorkouts.AlternatingRowsDefaultCellStyle.ForeColor = textLight;

                dgvWorkouts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(24, 25, 27);
                dgvWorkouts.ColumnHeadersDefaultCellStyle.ForeColor = textLight;

                btnAbout.BackColor = Color.FromArgb(32, 33, 36);
                btnAbout.ForeColor = Color.FromArgb(240, 240, 240);
                btnAbout.FlatAppearance.BorderColor = Color.FromArgb(60, 62, 66);
            }
            else
            {
                var formBg = Color.FromArgb(226, 232, 240);
                var cardBg = Color.White;
                var textDark = Color.FromArgb(30, 41, 59);
                var borderLight = Color.FromArgb(226, 232, 240);
                var buttonBorder = Color.FromArgb(209, 213, 219);

                this.BackColor = formBg;
                this.ForeColor = textDark;

                btnToggleTheme.Text = "🌙 Темна тема";
                btnToggleTheme.BackColor = cardBg;
                btnToggleTheme.ForeColor = textDark;
                btnToggleTheme.FlatAppearance.BorderColor = buttonBorder;

                btnSave.BackColor = cardBg;
                btnSave.ForeColor = textDark;
                btnSave.FlatAppearance.BorderColor = buttonBorder;

                btnDelete.BackColor = Color.FromArgb(254, 226, 226);
                btnDelete.ForeColor = Color.FromArgb(185, 28, 28);
                btnDelete.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);

                btnOpenAddForm.BackColor = Color.FromArgb(37, 99, 235);
                btnOpenAddForm.ForeColor = Color.White;
                btnOpenAddForm.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);

                panelSummary.BackColor = cardBg;

                lblSummaryTitle.ForeColor = textDark;
                lblSummary.ForeColor = textDark;
                lblSearch.ForeColor = textDark;

                txtSearch.BackColor = cardBg;
                txtSearch.ForeColor = textDark;

                cmbProfiles.BackColor = cardBg;
                cmbProfiles.ForeColor = textDark;

                dgvWorkouts.BackgroundColor = cardBg;
                dgvWorkouts.GridColor = borderLight;
                dgvWorkouts.DefaultCellStyle.BackColor = cardBg;
                dgvWorkouts.DefaultCellStyle.ForeColor = textDark;
                dgvWorkouts.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                dgvWorkouts.DefaultCellStyle.SelectionForeColor = textDark;

                dgvWorkouts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
                dgvWorkouts.AlternatingRowsDefaultCellStyle.ForeColor = textDark;

                dgvWorkouts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
                dgvWorkouts.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(51, 65, 85);

                btnAbout.BackColor = Color.White;
                btnAbout.ForeColor = Color.FromArgb(30, 41, 59);
                btnAbout.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            }
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            _isDarkTheme = !_isDarkTheme;
            ApplyTheme();
            Program.SaveThemePreference(_isDarkTheme);
        }

        private void btnOpenAddForm_Click_1(object sender, EventArgs e)
        {
            using (var addForm = new AddWorkoutForm(_isDarkTheme))
            {
                if (addForm.ShowDialog(this) == DialogResult.OK && addForm.CreatedWorkout != null)
                {
                    _workouts.Add(addForm.CreatedWorkout);
                    RefreshGrid();
                    _isModified = true;
                }
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            using (var aboutForm = new AboutForm())
            {
                aboutForm.ApplyTheme(_isDarkTheme);
                aboutForm.ShowDialog(this);
            }
        }

        private void LoadProfilesIntoCombo()
        {
            if (cmbProfiles == null) return;
            cmbProfiles.Items.Clear();

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
                        cmbProfiles.Items.Add(username);
                    }
                }
            }

            if (!cmbProfiles.Items.Contains(_username))
            {
                cmbProfiles.Items.Add(_username);
            }

            cmbProfiles.SelectedItem = _username;
        }

        private void cmbProfiles_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string? selectedUser = cmbProfiles.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedUser) && selectedUser != _username)
            {
                if (_isModified)
                {
                    var result = MessageBox.Show(
                        "Зберегти зміни для поточного профілю перед перемиканням?",
                        "Незбережені дані",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        _repository.Save(_workouts);
                    }
                }

                _username = selectedUser;
                _repository.SetUser(_username);

                _workouts = _repository.Load() ?? new List<Workout>();
                _bindingSource.DataSource = _workouts;

                RefreshGrid();

                this.Text = $"WorkoutTracker — Профіль: {_username}";
                _isModified = false;
            }
        }
    }
}