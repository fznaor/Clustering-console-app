using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZavrsniRad
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
            Application.CurrentCulture = CultureInfo.InvariantCulture;
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm mainForm = new MainForm();
            Presenter presenter = new Presenter(mainForm);
            Application.Run(mainForm);
        }
    }
}
