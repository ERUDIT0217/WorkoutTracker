using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class AddWorkoutForm : Form
    {
        public Workout? CreatedWorkout { get; private set; }

        public AddWorkoutForm() : this(false)
        {
        }

        public AddWorkoutForm(bool isDarkTheme)
        {
            InitializeComponent();

            this.Shown += (s, e) => txtTitle.Focus();

            this.AcceptButton = btnAddWorkout;
            if (btnCancel != null)
            {
                this.CancelButton = btnCancel;
            }

            if (cmbWorkoutType.Items.Count > 0)
                cmbWorkoutType.SelectedIndex = 0;

            if (cmbActivityType.Items.Count > 0)
                cmbActivityType.SelectedIndex = 0;

            ApplyTheme(isDarkTheme);
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
        private void btnAddWorkout_Click_1(object sender, EventArgs e)
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

                if (selectedType == "Кардіо")
                {
                    double distance = (double)numDistance.Value;
                    string activity = cmbActivityType.SelectedItem?.ToString() ?? "Біг";
                    CreatedWorkout = new CardioWorkout(title, date, duration, userWeight, activity, distance);
                }
                else if (selectedType == "Силове")
                {
                    int sets = (int)numSets.Value;
                    int reps = (int)numReps.Value;
                    double weightLifted = (double)numWeightLifted.Value;
                    CreatedWorkout = new StrengthWorkout(title, date, duration, userWeight, sets, reps, weightLifted);
                }
                else
                {
                    MessageBox.Show("Оберіть тип тренування зі списку.", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ApplyTheme(bool isDarkTheme)
        {
            if (isDarkTheme)
            {
                var bg = Color.FromArgb(24, 24, 27);
                var inputBg = Color.FromArgb(39, 39, 42);
                var textLight = Color.FromArgb(240, 240, 240);
                var subText = Color.FromArgb(160, 160, 165);
                var borderDark = Color.FromArgb(60, 62, 66);

                this.BackColor = bg;
                this.ForeColor = textLight;

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
                    }
                }

                btnAddWorkout.BackColor = Color.FromArgb(50, 52, 58);
                btnAddWorkout.ForeColor = Color.White;
                btnAddWorkout.FlatAppearance.BorderColor = borderDark;

                if (btnCancel != null)
                {
                    btnCancel.BackColor = inputBg;
                    btnCancel.ForeColor = Color.FromArgb(200, 200, 205);
                    btnCancel.FlatAppearance.BorderColor = borderDark;
                }

                foreach (Control c in this.Controls)
                {
                    if (c is Label lbl)
                    {
                        lbl.ForeColor = lbl.Font.Bold ? textLight : subText;
                    }
                }
            }
            else
            {
                this.BackColor = Color.FromArgb(245, 247, 250);
                this.ForeColor = Color.FromArgb(30, 41, 59);

                btnAddWorkout.BackColor = Color.FromArgb(37, 99, 235);
                btnAddWorkout.ForeColor = Color.White;

                if (btnCancel != null)
                {
                    btnCancel.BackColor = Color.White;
                    btnCancel.ForeColor = Color.FromArgb(71, 85, 105);
                    btnCancel.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
                }
            }
        }
    }
}