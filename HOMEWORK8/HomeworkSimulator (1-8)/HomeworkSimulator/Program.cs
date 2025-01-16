using HomeworkSimulator.UI;
using System;
using System.Windows.Forms;

namespace HomeworkSimulator
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Set the initial form (choose the correct one)
            Application.Run(new MainForm());
        }
    }
}
