using System.Drawing;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class InputForm : Form
    {
        public string EnteredText => txtUsername.Text.Trim();
        private bool _isDarkTheme = false;

        public InputForm(bool isDarkTheme = false)
        {
            InitializeComponent();
            _isDarkTheme = isDarkTheme;
            ApplyTheme(_isDarkTheme);
        }

        private void ApplyTheme(bool isDark)
        {
            _isDarkTheme = isDark;

            if (_isDarkTheme)
            {
                var formBg = Color.FromArgb(20, 20, 22);
                var inputBg = Color.FromArgb(42, 43, 46);
                var textLight = Color.FromArgb(240, 240, 240);
                var borderDark = Color.FromArgb(60, 62, 66);

                this.BackColor = formBg;
                this.ForeColor = textLight;

                lblPrompt.ForeColor = textLight;

                txtUsername.BackColor = inputBg;
                txtUsername.ForeColor = textLight;

                btnOk.BackColor = Color.FromArgb(37, 99, 235);
                btnOk.ForeColor = Color.White;
                btnOk.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);

                btnCancel.BackColor = Color.FromArgb(42, 43, 46);
                btnCancel.ForeColor = textLight;
                btnCancel.FlatAppearance.BorderColor = borderDark;
            }
            else
            {
                var formBg = Color.FromArgb(226, 232, 240);
                var cardBg = Color.White;
                var textDark = Color.FromArgb(30, 41, 59);
                var buttonBorder = Color.FromArgb(209, 213, 219);

                this.BackColor = formBg;
                this.ForeColor = textDark;

                lblPrompt.ForeColor = textDark;

                txtUsername.BackColor = cardBg;
                txtUsername.ForeColor = textDark;

                btnOk.BackColor = Color.FromArgb(37, 99, 235);
                btnOk.ForeColor = Color.White;
                btnOk.FlatAppearance.BorderColor = Color.FromArgb(37, 99, 235);

                btnCancel.BackColor = Color.White;
                btnCancel.ForeColor = textDark;
                btnCancel.FlatAppearance.BorderColor = buttonBorder;
            }
        }
    }
}