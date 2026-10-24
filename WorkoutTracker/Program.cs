using System;
using System.IO;
using System.Windows.Forms;

namespace WorkoutTracker
{
    static class Program
    {
        private const string ThemeConfigFile = "theme_config.txt";

        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                SetProcessDPIAware();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool isDarkTheme = LoadThemePreference();

            using (var selectForm = new UserSelectForm(isDarkTheme))
            {
                if (selectForm.ShowDialog() == DialogResult.OK)
                {
                    string activeUser = selectForm.SelectedUser;

                    using (var form1 = new Form1(activeUser, isDarkTheme))
                    {
                        Application.Run(form1);
                    }
                }
            }
        }

        public static bool LoadThemePreference()
        {
            try
            {
                if (File.Exists(ThemeConfigFile))
                {
                    string content = File.ReadAllText(ThemeConfigFile);
                    if (bool.TryParse(content, out bool isDark))
                    {
                        return isDark;
                    }
                }
            }
            catch { }
            return false;
        }

        public static void SaveThemePreference(bool isDark)
        {
            try
            {
                File.WriteAllText(ThemeConfigFile, isDark.ToString());
            }
            catch { }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}