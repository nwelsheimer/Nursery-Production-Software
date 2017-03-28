﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using General;

namespace Nursery_Production_Software
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            General.Global.set_AppSubKey("Parent");
            General.Global.registry(General.Global.keyHKLM_AppSubKey, "Database", "MSVision");
            General.Global.SetConnectionString(General.Global.registry(General.Global.keyHKLM_AppSubKey, "Server").ToString(), General.Global.registry(General.Global.keyHKLM_AppSubKey, "Database").ToString());


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmParent());
        }
    }
}