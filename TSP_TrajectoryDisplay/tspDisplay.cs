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
        public bool isPlaying;
        System.Timers.Timer timer;

        private TrajectoryDisplay form;
        private NumericUpDown solutionSpinButton;
        private Button playButton;
        private Button stopButton;
        private TrackBar solutionSlider;
        private Panel paintPanel;

        private Thread tPaint;

        private int totalStep;
        private int step;
        private delegate void setStepDelegate(int newStep);


        public TspDisplay(
                TrajectoryDisplay tspForm,
                NumericUpDown tspSolutionSpinButton,
                Button tspPlayButton,
                Button tspStopButton,
                TrackBar tspSolutionSlider,
                Panel tspPaintPanel,
                int tspTotalStep,
                int displayInterval = 500,
                int initStep = 1) {
            form = tspForm;
            solutionSpinButton = tspSolutionSpinButton;
            playButton = tspPlayButton;
            stopButton = tspStopButton;
            solutionSlider = tspSolutionSlider;
            paintPanel = tspPaintPanel;

            totalStep = tspTotalStep;
            tspSolutionSlider.Maximum = totalStep;
            tspSolutionSpinButton.Maximum = totalStep;

            isPlaying = false;
            timer = new System.Timers.Timer();
            timer.Interval = displayInterval;
            timer.Elapsed += displayNextStep;

            setStep(initStep);
        }

        public void setStep(int newStep) {
            step = (newStep > totalStep) ? 1 : newStep;
            solutionSlider.Value = step;
            solutionSpinButton.Value = step;
            displaySolution();
        }

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

        private void displaySolution() {
            paintPanel.Refresh();
            Graphics g = paintPanel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, paintPanel.Width, step);
            g.Dispose();
        }

        private void displayNextStep(object sender, ElapsedEventArgs e) {
            form.Invoke(new setStepDelegate(setStep), step + 1);
            if (step == totalStep) {
                pause();
            }
        }
    }
}
