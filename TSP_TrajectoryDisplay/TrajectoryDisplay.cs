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

namespace TSP_TrajectoryDisplay
{
    public partial class TrajectoryDisplay : Form
    {
        private TspDisplay tspDisplay;
        //private CpmpDisplay CpmpDisplay;

        public TrajectoryDisplay() {
            InitializeComponent();

            tspDisplay = new TspDisplay(this, tspSolutionSpinButton, tspPlayButton,
                tspStopButton, tspSolutionSlider, tspPaintPanel);

            //CpmpDisplay = new CpmpDisplay();
        }

        private void algorithmTab_SelectedIndexChanged(object sender, EventArgs e) {
            if (algorithmTab.SelectedIndex == algorithmTab.TabPages.IndexOfKey("TSP")) {
                //cpmpDisplay.pause();
            } else if (algorithmTab.SelectedIndex == algorithmTab.TabPages.IndexOfKey("CPMP")) {
                tspDisplay.pause();
            }
        }


        #region TSP event
        private void tspSolutionSpinButton_ValueChanged(object sender, EventArgs e) {
            tspDisplay.setStep(Decimal.ToInt32(tspSolutionSpinButton.Value));
        }

        private void tspSolutionSlider_Scroll(object sender, EventArgs e) {
            tspDisplay.setStep(tspSolutionSlider.Value);
        }

        private void tspPlayButton_Click(object sender, EventArgs e) {
            if (tspDisplay.isPlaying == true) {
                tspDisplay.pause();
            } else {
                tspDisplay.play();
            }
        }

        private void tspStopButton_Click(object sender, EventArgs e) {
            tspDisplay.stop();
        }

        private void tspPaintPanel_Paint(object sender, PaintEventArgs e) {
            tspDisplay.drawSolution(e.Graphics);
        }
        #endregion TSP event
    }
}
