using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackathon.Views
{
    public partial class TaskTraySettings : Form
    {
        public TaskTraySettings()
        {
            InitializeComponent();
        }

        private void timerSizeTB_Scroll(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.timerSize = timerSizeTB.Value;
        }

        private void createTaskBTN_Click(object sender, EventArgs e)
        {
            Program.newTaskInstance.Show();
        }
    }
}
