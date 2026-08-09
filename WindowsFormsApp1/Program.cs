using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            WindowsFormsApp1.Views.FrmLogin login = new WindowsFormsApp1.Views.FrmLogin();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new WindowsFormsApp1.Views.MainForm());
            }
        }
    }
}
