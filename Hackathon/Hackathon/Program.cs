using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Hackathon
{
    static class Program
    {
        public static Views.OverlayWindow overlayWindowInstance;
        public static Views.TaskTraySettings tasktraySettingsInstance;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            overlayWindowInstance = new Views.OverlayWindow();
            tasktraySettingsInstance = new Views.TaskTraySettings();

            Application.Run(overlayWindowInstance);
        }
    }
}
