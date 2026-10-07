using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace WorkoutTracker
{
    public partial class Form1 : Form
    {
        private readonly WorkoutRepository _repository = new WorkoutRepository();
        private List<Workout> _workouts = new List<Workout>();
        private readonly BindingSource _bindingSource = new BindingSource();
        private bool _isModified = false;

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
    }
}