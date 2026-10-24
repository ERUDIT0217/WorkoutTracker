using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WorkoutTracker
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }



        public void ApplyTheme(bool isDarkTheme)
        {
            if (isDarkTheme)
            {
                this.BackColor = Color.FromArgb(20, 20, 22);
                this.ForeColor = Color.FromArgb(240, 240, 240);

                lblAppTitle.ForeColor = Color.FromArgb(240, 240, 240);
                lblDescription.ForeColor = Color.FromArgb(209, 213, 219);

                btnClose.BackColor = Color.FromArgb(42, 43, 46);
                btnClose.ForeColor = Color.FromArgb(240, 240, 240);
                btnClose.FlatAppearance.BorderColor = Color.FromArgb(60, 62, 66);
            }
            else
            {
                this.BackColor = Color.FromArgb(226, 232, 240);
                this.ForeColor = Color.FromArgb(30, 41, 59);

                lblAppTitle.ForeColor = Color.FromArgb(30, 41, 59);
                lblDescription.ForeColor = Color.FromArgb(30, 41, 59);

                btnClose.BackColor = Color.White;
                btnClose.ForeColor = Color.FromArgb(30, 41, 59);
                btnClose.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}