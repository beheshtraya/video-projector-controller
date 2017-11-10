using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlProjector
{
    
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            if (Screen.AllScreens.Length < 2)
            {
                MessageBox.Show("Extend Mode not activated.");
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form frmMain = new Form1();
            Application.Run(frmMain);
        }
    }
}
