using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Drawing.Drawing2D;
using System.IO;

namespace TspPlayerPanel
{
    public partial class TspPlayerPanel : UserControl
    {
        public const int MIN_STEP = 0;
        public const int DISPLAY_INTERVAL = 500;
        public const int ARROW_WIDTH = 4;
        public const int ARROW_HEIGHT = 6;

        public bool isPlaying;                      // init in TspDisplay()

        private System.Timers.Timer timer;          // init in TspDisplay()

        private int step;                           // init in TspDisplay()
        private delegate void setStepDelegate(int newStep);

        private int totalStep;                      // init in readTrajectory()
        private int maxStep;                        // init in readTrajectory()
        private List<Point> pointList;              // init in readTrajectory()
        private int instMaxX;                       // init in readTrajectory()
        private int instMaxY;                       // init in readTrajectory()
        private int[] objList;                      // init in readTrajectory()
        private int[][] slnList;                    // init in readTrajectory()


        public TspPlayerPanel() {
            InitializeComponent();

            init();
        }

        private void init(int displayInterval = DISPLAY_INTERVAL, int initStep = MIN_STEP) {
            timer = new System.Timers.Timer();
            timer.Interval = displayInterval;
            timer.Elapsed += displayNextStep;
            isPlaying = false;

            readTrajectory();

            tspSolutionSlider.Minimum = MIN_STEP;
            tspSolutionSlider.Maximum = maxStep;
            tspSolutionSpinButton.Minimum = MIN_STEP;
            tspSolutionSpinButton.Maximum = maxStep;

            setStep(initStep);
        }

        private void readTrajectory() {
            string instPath = @"../../../instances/tsp/eil51.tsp";
            string objPath = @"../../../instances/tsp/LOTLS_eil51.txt";
            string slnPath = @"../../../instances/tsp/LOTS_eil51.txt";

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
            maxStep = totalStep - 1;

            slnList = new int[totalStep][];
            string[] sln = File.ReadAllLines(slnPath);
            for (int i = 0; i < totalStep; i++) {
                string[] seq = sln[i].Split(' ');
                slnList[i] = Array.ConvertAll(seq, int.Parse);
            }
        }

        #region drawing
        public void drawSolution(Graphics g) {
            BufferedGraphicsContext currentContext = BufferedGraphicsManager.Current;
            BufferedGraphics paintBuffer = currentContext.Allocate(
                g, tspPaintPanel.DisplayRectangle);
            paintBuffer.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintBuffer.Graphics.Clear(Color.LightGray);

            Pen p = new Pen(Color.Blue, 1);
            p.CustomEndCap = new AdjustableArrowCap(ARROW_WIDTH, ARROW_HEIGHT, true);

            // expand the graph to whole panel
            int ampX = (instMaxX > tspPaintPanel.Width || instMaxX <= 0) ? 1 : (tspPaintPanel.Width / instMaxX);
            int ampY = (instMaxY > tspPaintPanel.Height || instMaxY <= 0) ? 1 : (tspPaintPanel.Height / instMaxY);

            // draw last solution if there is
            if (step > MIN_STEP) {
                drawCircuit(paintBuffer.Graphics, p, step - 1, ampX, ampY);
            }

            // draw current solution
            p.Color = Color.Black;
            p.Width = 2;
            drawCircuit(paintBuffer.Graphics, p, step, ampX, ampY);

            paintBuffer.Render();
            paintBuffer.Render(tspPaintPanel.CreateGraphics());

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
        #endregion drawing


        #region play control
        public void play() {
            timer.Start();

            tspPlayButton.BackgroundImage = Properties.Resources._30pause;
            isPlaying = true;
        }

        public void pause() {
            timer.Stop();

            tspPlayButton.BackgroundImage = Properties.Resources._30play;
            isPlaying = false;
        }

        public void stop() {
            timer.Stop();

            setStep(MIN_STEP);
            tspPlayButton.BackgroundImage = Properties.Resources._30play;
            isPlaying = false;
        }

        public void setStep(int newStep) {
            step = (newStep >= totalStep) ? MIN_STEP : newStep;
            tspSolutionSlider.Value = step;
            tspSolutionSpinButton.Value = step;
            tspPaintPanel.Refresh();
        }

        private void displayNextStep(object sender, ElapsedEventArgs e) {
            playerPanel.Invoke(new setStepDelegate(setStep), step + 1);
            if (step == maxStep) {
                pause();
            }
        }
        #endregion play control


        #region action response
        private void tspSolutionSpinButton_ValueChanged(object sender, EventArgs e) {
            setStep(Decimal.ToInt32(tspSolutionSpinButton.Value));
        }

        private void tspSolutionSlider_Scroll(object sender, EventArgs e) {
            setStep(tspSolutionSlider.Value);
        }

        private void tspPlayButton_Click(object sender, EventArgs e) {
            if (isPlaying == true) {
                pause();
            } else {
                play();
            }
        }

        private void tspStopButton_Click(object sender, EventArgs e) {
            stop();
        }

        private void tspPaintPanel_Paint(object sender, PaintEventArgs e) {
            drawSolution(e.Graphics);
        }
        #endregion action response
    }
}
