using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace gmailFool
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
                Application.Run(new Form2());

                Application.Exit();
    }
        static void hello(object sender, EventArgs e)
        {

        }
    }
}
