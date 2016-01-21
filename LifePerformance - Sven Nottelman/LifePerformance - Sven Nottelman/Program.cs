using System;
using System.Windows.Forms;

namespace LifePerformance___Sven_Nottelman
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Hoofdscherm());
        }
    }
}
