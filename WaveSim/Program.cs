/*
 *  WaveSim - Physically correct 2D-Wave simulation
 *  Author: Arthur Silber / arthur.silber@gmx.de
 *  
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WaveSim
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

            string[] args = Environment.GetCommandLineArgs();
            string filename = "";
            if (args.Length > 1)
            {
                filename = args[1];
            }
            
            Application.Run(new SimForm(filename));
            
        }
    }
}
