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

        public TrajectoryDisplay() {
            InitializeComponent();
            //SetStyle(ControlStyles.DoubleBuffer, true);

            tspDisplay = new TspDisplay(this, tspSolutionSpinButton, tspPlayButton,
                tspStopButton, tspSolutionSlider, tspPaintPanel, 466);
        }

        private void cpmpTab_Click(object sender, EventArgs e) {
            tspDisplay.pause();
        }

        private void tspTab_Click(object sender, EventArgs e) {

        }

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
    }
}
