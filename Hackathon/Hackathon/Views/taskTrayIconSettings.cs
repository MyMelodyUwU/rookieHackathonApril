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
