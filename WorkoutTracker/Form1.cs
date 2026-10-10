using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkoutTracker
{
    public partial class Form1 : Form
    {
        private readonly WorkoutRepository _repository = new WorkoutRepository();
        private List<Workout> _workouts = new List<Workout>();
        private readonly BindingSource _bindingSource = new BindingSource();
        private bool _isModified = false;
        private bool _isDarkTheme = false;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;

            this.FormClosing += Form1_FormClosing;

            ConfigureGridColumnsExplicitly();

            _workouts = _repository.Load() ?? new List<Workout>();

            _bindingSource.DataSource = _workouts;
            dgvWorkouts.DataSource = _bindingSource;

            if (cmbWorkoutType.Items.Count > 0)
                cmbWorkoutType.SelectedIndex = 0;

            if (cmbActivityType.Items.Count > 0)
                cmbActivityType.SelectedIndex = 0;

            RefreshGrid();

            ApplyTheme();
        }

        private void ConfigureGridColumnsExplicitly()
        {
            dgvWorkouts.AutoGenerateColumns = false;
            dgvWorkouts.Columns.Clear();

            dgvWorkouts.AllowUserToAddRows = false;
            dgvWorkouts.AllowUserToDeleteRows = false;
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.MultiSelect = true;

            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;

            dgvWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvWorkouts.ColumnHeadersHeight = 35;
            dgvWorkouts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Дата", DataPropertyName = "Date", FillWeight = 85 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Назва", DataPropertyName = "Title", FillWeight = 120 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Час, хв", DataPropertyName = "DurationInMinutes", FillWeight = 95 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Вага, кг", DataPropertyName = "UserWeightKg", FillWeight = 90 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Тип", DataPropertyName = "TypeTitle", FillWeight = 85 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Деталі", DataPropertyName = "Details", FillWeight = 165 });
            dgvWorkouts.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Калорії", DataPropertyName = "Calories", FillWeight = 85 });
        }

        private void RefreshGrid()
        {
            string query = txtSearch.Text.Trim().ToLower();
            List<Workout> displayedWorkouts;

            if (string.IsNullOrWhiteSpace(query))
            {
                displayedWorkouts = _workouts;
            }

            else
            {
                displayedWorkouts = _workouts
                    .Where(w => w.Title != null && w.Title.ToLower().Contains(query))
                    .ToList();


            }

            _bindingSource.DataSource = null;
            _bindingSource.DataSource = displayedWorkouts;
            _bindingSource.ResetBindings(false);

            UpdateSummaryStatistic(displayedWorkouts);
        }

        private void cmbWorkoutType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cmbWorkoutType.SelectedItem?.ToString() ?? "";

            if (selectedType == "Кардіо")
            {
                numDistance.Enabled = true;
                cmbActivityType.Enabled = true;

                numSets.Enabled = false;
                numReps.Enabled = false;
                numWeightLifted.Enabled = false;
            }
            else if (selectedType == "Силове")
            {
                numDistance.Enabled = false;
                cmbActivityType.Enabled = false;

                numSets.Enabled = true;
                numReps.Enabled = true;
                numWeightLifted.Enabled = true;
            }
        }

        private void btnAddWorkout_Click(object sender, EventArgs e)
        {
            try
            {
                string title = txtTitle.Text.Trim();
                DateTime date = dtpDate.Value.Date;
                int duration = (int)numDuration.Value;
                double userWeight = (double)numUserWeight.Value;

                if (string.IsNullOrWhiteSpace(title))
                {
                    MessageBox.Show("Будь ласка, введіть назву тренування.", "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTitle.Focus();
                    return;
                }

                string selectedType = cmbWorkoutType.SelectedItem?.ToString() ?? "";
                Workout newWorkout;

                if (selectedType == "Кардіо")
                {
                    double distance = (double)numDistance.Value;
                    string activity = cmbActivityType.SelectedItem?.ToString() ?? "Біг";
                    newWorkout = new CardioWorkout(title, date, duration, userWeight, activity, distance);
                }
                else if (selectedType == "Силове")
                {
                    int sets = (int)numSets.Value;
                    int reps = (int)numReps.Value;
                    double weightLifted = (double)numWeightLifted.Value;
                    newWorkout = new StrengthWorkout(title, date, duration, userWeight, sets, reps, weightLifted);
                }
                else
                {
                    MessageBox.Show("Оберіть тип тренування зі списку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _workouts.Add(newWorkout);
                RefreshGrid();
                _isModified = true;

                txtTitle.Clear();
                txtTitle.Focus();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Непередбачена помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                "підтвердження видалення",
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
                if (txtTitle.Focused)
                    return;

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

        private void UpdateSummaryStatistic(IEnumerable<Workout> currentWorkouts)
        {
            var list = currentWorkouts.ToList();

            int totalCount = list.Count;
            int totalDuration = list.Sum(w => w.DurationInMinutes);
            double totalCalories = list.Sum(w => w.CalculateCaloriesBurned());

            lblSummary.Text = $"Всього тренувань: {totalCount} | Загальний час: {totalDuration} хв | Спалено: {totalCalories:F1} ккал";
        }

        private void ApplyTheme()
        {
            void UpdateLabelsColor(Control parent, Color color)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is Label lbl && lbl != lblNewWorkoutTitle && lbl != lblSummaryTitle)
                    {
                        lbl.ForeColor = color;
                    }
                    if (c.HasChildren)
                    {
                        UpdateLabelsColor(c, color);
                    }
                }
            }

            if (_isDarkTheme)
            {
                var formBg = Color.FromArgb(20, 20, 22);
                var cardBg = Color.FromArgb(32, 33, 36);
                var inputBg = Color.FromArgb(42, 43, 46);
                var textLight = Color.FromArgb(240, 240, 240);
                var subText = Color.FromArgb(160, 160, 165);
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

                btnAddWorkout.BackColor = Color.FromArgb(50, 52, 58);
                btnAddWorkout.ForeColor = Color.White;

                panelWorkoutInput.BackColor = cardBg;
                panelSummary.BackColor = cardBg;

                lblNewWorkoutTitle.ForeColor = textLight;
                lblSummaryTitle.ForeColor = textLight;
                lblSummary.ForeColor = textLight;
                lblSearch.ForeColor = textLight;

                UpdateLabelsColor(panelWorkoutInput, subText);

                txtSearch.BackColor = inputBg;
                txtSearch.ForeColor = textLight;
                txtTitle.BackColor = inputBg;
                txtTitle.ForeColor = textLight;

                NumericUpDown[] numControls = { numUserWeight, numDuration, numDistance, numSets, numReps, numWeightLifted };
                foreach (var num in numControls)
                {
                    if (num != null)
                    {
                        num.BackColor = inputBg;
                        num.ForeColor = textLight;
                    }
                }

                ComboBox[] cmbControls = { cmbWorkoutType, cmbActivityType };
                foreach (var cmb in cmbControls)
                {
                    if (cmb != null)
                    {
                        cmb.BackColor = inputBg;
                        cmb.ForeColor = textLight;
                        cmb.FlatStyle = FlatStyle.Flat;
                    }
                }

                if (dtpDate != null)
                {
                    dtpDate.CalendarMonthBackground = cardBg;
                    dtpDate.CalendarTitleBackColor = cardBg;
                    dtpDate.CalendarForeColor = textLight;
                    dtpDate.CalendarTitleForeColor = textLight;

                    dtpDate.Format = DateTimePickerFormat.Custom;
                    dtpDate.CustomFormat = "dd.MM.yyyy";
                    dtpDate.BackColor = inputBg;
                    dtpDate.ForeColor = textLight;
                }

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
            }
            else
            {
                var formBg = Color.FromArgb(226, 232, 240);
                var cardBg = Color.White;
                var textDark = Color.FromArgb(30, 41, 59);
                var subText = Color.FromArgb(71, 85, 105);
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

                btnAddWorkout.BackColor = Color.FromArgb(37, 99, 235);
                btnAddWorkout.ForeColor = Color.White;

                panelWorkoutInput.BackColor = cardBg;
                panelSummary.BackColor = cardBg;

                lblNewWorkoutTitle.ForeColor = textDark;
                lblSummaryTitle.ForeColor = textDark;
                lblSummary.ForeColor = textDark;
                lblSearch.ForeColor = textDark;

                UpdateLabelsColor(panelWorkoutInput, subText);

                txtSearch.BackColor = cardBg;
                txtSearch.ForeColor = textDark;
                txtTitle.BackColor = cardBg;
                txtTitle.ForeColor = textDark;

                NumericUpDown[] numControls = { numUserWeight, numDuration, numDistance, numSets, numReps, numWeightLifted };
                foreach (var num in numControls)
                {
                    if (num != null)
                    {
                        num.BackColor = cardBg;
                        num.ForeColor = textDark;
                    }
                }

                ComboBox[] cmbControls = { cmbWorkoutType, cmbActivityType };
                foreach (var cmb in cmbControls)
                {
                    if (cmb != null)
                    {
                        cmb.BackColor = cardBg;
                        cmb.ForeColor = textDark;
                        cmb.FlatStyle = FlatStyle.Flat;
                    }
                }

                if (dtpDate != null)
                {
                    dtpDate.CalendarMonthBackground = cardBg;
                    dtpDate.CalendarTitleBackColor = cardBg;
                    dtpDate.CalendarForeColor = textDark;
                    dtpDate.CalendarTitleForeColor = textDark;

                    dtpDate.Format = DateTimePickerFormat.Custom;
                    dtpDate.CustomFormat = "dd.MM.yyyy";
                    dtpDate.BackColor = cardBg;
                    dtpDate.ForeColor = textDark;
                }

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
            }
        }

        private void btnToggleTheme_Click(object sender, EventArgs e)
        {
            _isDarkTheme = !_isDarkTheme;
            ApplyTheme();
        }
    }
}