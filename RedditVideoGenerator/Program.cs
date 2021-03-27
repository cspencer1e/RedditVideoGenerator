using RedditVideoGenerator.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RedditVideoGenerator
{
    static class Program
    {
        public static MainForm form;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RedditTools.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            form = new MainForm();
            Application.Run(form);
        } 
    }
}
