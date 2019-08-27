//    Filename: Program.cs
// Description: Program 
//      Author: Drew Thomas 11419895
//        Date: 10/20/2015
//     History: Last modified 10/20 at 8:40
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thomasdy_EX4
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
            Application.Run(new Form1());
        }
    }
}
