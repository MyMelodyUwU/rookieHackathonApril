using System;
using System.Windows.Forms;

namespace Hackathon
{
    static class Program
    {
        public static Views.OverlayWindow overlayWindowInstance;
        public static Views.TaskTraySettings tasktraySettingsInstance;
        public static Views.NewTask newTaskInstance;
        public static Views.taskTrayIconSettings tasktrayIconSettingsInstance;

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
            newTaskInstance = new Views.NewTask();
            tasktrayIconSettingsInstance = new Views.taskTrayIconSettings();

            tasktraySettingsInstance.Show();
            Application.Run(overlayWindowInstance); 
        }
    }
}
