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
    public partial class trajectoryDisplay : Form
    {
        private Thread tPaint;

        private int step;
        public int Step {
            get {
                return step;
            }
            set {
                step = value;
                solutionSlider.Value = value;
                solutionSpinButton.Value = value;
            }
        }
        private bool isPlaying;


        public trajectoryDisplay() {
            InitializeComponent();
            //SetStyle(ControlStyles.DoubleBuffer, true);

            Step = 1;
            isPlaying = false;
        }

        private void displayTrajectory() {
            while (true) {
                Step = (Step + 1) % paintPanel.Height;
                Thread.Sleep(500);
            }
        }

        private void displaySolution() {
            Graphics g = paintPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, paintPanel.Width, Step);
            g.Dispose();
        }

        private void paintPanel_Paint(object sender, PaintEventArgs e) {
            displaySolution();
        }

        private void solutionSpinButton_ValueChanged(object sender, EventArgs e) {
            Step = Decimal.ToInt32(solutionSpinButton.Value);

            displaySolution();
        }

        private void solutionSlider_Scroll(object sender, EventArgs e) {
            Step = solutionSlider.Value;

            displaySolution();
        }

        private void playButton_Click(object sender, EventArgs e) {
            if (isPlaying) {  // stop and show the play button
                isPlaying = false;
                playButton.BackgroundImage = Properties.Resources._30play;

                //tPaint.Abort();
            } else {    // start and show pause button
                isPlaying = true;
                playButton.BackgroundImage = Properties.Resources._30pause;

                //tPaint = new Thread(new ThreadStart(displayTrajectory));
                //tPaint.Start();
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {
            Step = 1;
        }

    }
}
