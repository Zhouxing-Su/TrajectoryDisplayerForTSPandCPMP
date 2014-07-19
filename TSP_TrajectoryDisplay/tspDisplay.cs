using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace TSP_TrajectoryDisplay
{
    class TspDisplay
    {
        public const int DISPLAY_INTERVAL = 500;

        public bool isPlaying;                      // init in TspDisplay()

        private System.Timers.Timer timer;          // init in TspDisplay()

        private TrajectoryDisplay form;             // init in TspDisplay()
        private NumericUpDown solutionSpinButton;   // init in TspDisplay()
        private Button playButton;                  // init in TspDisplay()
        private Button stopButton;                  // init in TspDisplay()
        private TrackBar solutionSlider;            // init in TspDisplay()
        private Panel paintPanel;                   // init in TspDisplay()

        private int step;                           // init in TspDisplay()
        private delegate void setStepDelegate(int newStep);

        private int totalStep;                      // init in readTrajectory()


        public TspDisplay(
                TrajectoryDisplay tspForm,
                NumericUpDown tspSolutionSpinButton,
                Button tspPlayButton,
                Button tspStopButton,
                TrackBar tspSolutionSlider,
                Panel tspPaintPanel,
                int displayInterval = DISPLAY_INTERVAL,
                int initStep = 1) {
            form = tspForm;
            solutionSpinButton = tspSolutionSpinButton;
            playButton = tspPlayButton;
            stopButton = tspStopButton;
            solutionSlider = tspSolutionSlider;
            paintPanel = tspPaintPanel;

            timer = new System.Timers.Timer();
            timer.Interval = displayInterval;
            timer.Elapsed += displayNextStep;
            isPlaying = false;

            readTrajectory();

            tspSolutionSlider.Maximum = totalStep;
            tspSolutionSpinButton.Maximum = totalStep;

            setStep(initStep);
        }

        public void displaySolution() {
            Graphics g = paintPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, paintPanel.Width, step);
            g.Dispose();
        }

        private void readTrajectory() {
            totalStep = 466;
        }

        #region play control
        public void play() {
            timer.Start();

            playButton.BackgroundImage = Properties.Resources._30pause;
            isPlaying = true;
        }

        public void pause() {
            timer.Stop();

            playButton.BackgroundImage = Properties.Resources._30play;
            isPlaying = false;
        }

        public void stop() {
            timer.Stop();

            setStep(1);
            playButton.BackgroundImage = Properties.Resources._30play;
            isPlaying = false;
        }

        public void setStep(int newStep) {
            step = (newStep > totalStep) ? 1 : newStep;
            solutionSlider.Value = step;
            solutionSpinButton.Value = step;
            paintPanel.Refresh();
        }

        private void displayNextStep(object sender, ElapsedEventArgs e) {
            form.Invoke(new setStepDelegate(setStep), step + 1);
            if (step == totalStep) {
                pause();
            }
        }
        #endregion play control
    }
}
