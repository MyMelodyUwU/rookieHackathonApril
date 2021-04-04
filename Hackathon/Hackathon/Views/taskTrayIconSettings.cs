using System;
using System.Windows.Forms;

namespace Hackathon.Views
{
    public partial class taskTrayIconSettings : Form
    {
        public taskTrayIconSettings()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Program.overlayWindowInstance.Close();
        }
    }
}
