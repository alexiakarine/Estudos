using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Vendedores
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());*/
            for (int i = 0; i < 255; i++)
            {
                Console.Write("{0} {1}\n", i, (char)i);
            }
            Console.ReadKey();
        }
    }
}
