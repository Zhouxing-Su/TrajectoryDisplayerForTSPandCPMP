using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;
using System.IO;

namespace TSP_TrajectoryDisplay
{
    class TspDisplay
    {
        public const int DISPLAY_INTERVAL = 500;
        public const int ARROW_WIDTH = 4;
        public const int ARROW_HEIGHT = 6;

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
        List<Point> pointList;                      // init in readTrajectory()
        int instMaxX;                               // init in readTrajectory()
        int instMaxY;                               // init in readTrajectory()
        int[] objList;                              // init in readTrajectory()
        int[][] slnList;                            // init in readTrajectory()



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

        public void drawSolution(Graphics g) {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics paintBuffer = currentContext.Allocate(
                g, paintPanel.DisplayRectangle);
            paintBuffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintBuffer.Graphics.Clear(Color.LightGray);

            Pen p = new Pen(Color.Blue, 1);
            p.CustomEndCap = new AdjustableArrowCap(ARROW_WIDTH, ARROW_HEIGHT, true);

            int ampX = paintPanel.Width / instMaxX;     // expand the graph to whole panel
            int ampY = paintPanel.Height / instMaxY;    // expand the graph to whole panel

            // draw last solution
            if (step > 1) {
                drawCircuit(paintBuffer.Graphics, p, step - 1, ampX, ampY);
            }

            // draw current solution
            p.Color = Color.Black;
            p.Width = 2;
            drawCircuit(paintBuffer.Graphics, p, step, ampX, ampY);

            paintBuffer.Render();
            paintBuffer.Render(paintPanel.CreateGraphics());

            paintBuffer.Dispose();
        }

        private void drawCircuit(Graphics g, Pen p, int step, int ampX = 1, int ampY = 1) {
            int x1, y1, x2, y2;

            for (int i = pointList.Count - 1; i > 0; i--) {
                x1 = pointList[slnList[step][i]].X * ampX;
                y1 = pointList[slnList[step][i]].Y * ampY;
                x2 = pointList[slnList[step][i - 1]].X * ampX;
                y2 = pointList[slnList[step][i - 1]].Y * ampY;
                g.DrawLine(p, x1, y1, x2, y2);
            }

            x1 = pointList[slnList[step][0]].X * ampX;
            y1 = pointList[slnList[step][0]].Y * ampY;
            x2 = pointList[slnList[step][pointList.Count - 1]].X * ampX;
            y2 = pointList[slnList[step][pointList.Count - 1]].Y * ampY;
            g.DrawLine(p, x1, y1, x2, y2);
        }

        private void readTrajectory() {
            string instPath = @"../../instances/tsp/eil51.tsp";
            string objPath = @"../../instances/tsp/LOTLS_eil51.txt";
            string slnPath = @"../../instances/tsp/LOTS_eil51.txt";

            pointList = new List<Point>();
            string[] inst = File.ReadAllLines(instPath);
            foreach (string s in inst) {
                string[] coord = s.Split(' ');
                if (coord.Length == 2) {    // 2 elements which coord[0] for x, coord[1] for y
                    int x = int.Parse(coord[0]);
                    int y = int.Parse(coord[1]);
                    pointList.Add(new Point(x, y));
                    instMaxX = Math.Max(x, instMaxX);
                    instMaxY = Math.Max(y, instMaxY);
                }
            }

            objList = Array.ConvertAll(File.ReadAllLines(objPath), int.Parse);
            totalStep = objList.Length;

            slnList = new int[totalStep][];
            string[] sln = File.ReadAllLines(slnPath);
            for (int i = 0; i < totalStep; i++) {
                string[] seq = sln[i].Split(' ');
                slnList[i] = Array.ConvertAll(seq, int.Parse);
            }
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
