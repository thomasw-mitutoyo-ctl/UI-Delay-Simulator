using System;
using System.Windows.Forms;

namespace UIDelaySimulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new SettingsForm();
            Application.Run();
        }
    }
}
