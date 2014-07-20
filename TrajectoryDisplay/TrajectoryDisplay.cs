using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrajectoryDisplay
{
    public partial class TrajectoryDisplay : Form
    {
        public TrajectoryDisplay() {
            InitializeComponent();
        }

        private void algorithmTab_SelectedIndexChanged(object sender, EventArgs e) {
            if (algorithmTab.SelectedIndex == algorithmTab.TabPages.IndexOfKey("TSP")) {
                //cpmpDisplay.pause();
            } else if (algorithmTab.SelectedIndex == algorithmTab.TabPages.IndexOfKey("CPMP")) {
                tspPlayerPanel.pause();
            }
        }
    }
}
