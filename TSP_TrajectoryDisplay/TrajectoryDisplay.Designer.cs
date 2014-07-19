namespace TSP_TrajectoryDisplay
{
    partial class TrajectoryDisplay
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrajectoryDisplay));
            this.algorithmTab = new System.Windows.Forms.TabControl();
            this.tspTab = new System.Windows.Forms.TabPage();
            this.tspPlayerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tspPlayControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tspPlayButton = new System.Windows.Forms.Button();
            this.tspStopButton = new System.Windows.Forms.Button();
            this.tspSolutionSlider = new System.Windows.Forms.TrackBar();
            this.tspSolutionSpinButton = new System.Windows.Forms.NumericUpDown();
            this.tspPaintPanel = new System.Windows.Forms.Panel();
            this.cpmpTab = new System.Windows.Forms.TabPage();
            this.algorithmTab.SuspendLayout();
            this.tspTab.SuspendLayout();
            this.tspPlayerPanel.SuspendLayout();
            this.tspPlayControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tspSolutionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tspSolutionSpinButton)).BeginInit();
            this.SuspendLayout();
            // 
            // algorithmTab
            // 
            this.algorithmTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmTab.Controls.Add(this.tspTab);
            this.algorithmTab.Controls.Add(this.cpmpTab);
            this.algorithmTab.Location = new System.Drawing.Point(12, 12);
            this.algorithmTab.Name = "algorithmTab";
            this.algorithmTab.SelectedIndex = 0;
            this.algorithmTab.Size = new System.Drawing.Size(614, 484);
            this.algorithmTab.TabIndex = 0;
            this.algorithmTab.Tag = "";
            // 
            // tspTab
            // 
            this.tspTab.Controls.Add(this.tspPlayerPanel);
            this.tspTab.Location = new System.Drawing.Point(4, 22);
            this.tspTab.Name = "tspTab";
            this.tspTab.Padding = new System.Windows.Forms.Padding(3);
            this.tspTab.Size = new System.Drawing.Size(606, 458);
            this.tspTab.TabIndex = 0;
            this.tspTab.Text = "TSP";
            this.tspTab.UseVisualStyleBackColor = true;
            this.tspTab.Click += new System.EventHandler(this.tspTab_Click);
            // 
            // tspPlayerPanel
            // 
            this.tspPlayerPanel.ColumnCount = 1;
            this.tspPlayerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tspPlayerPanel.Controls.Add(this.tspPlayControlPanel, 0, 1);
            this.tspPlayerPanel.Controls.Add(this.tspPaintPanel, 0, 0);
            this.tspPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspPlayerPanel.Location = new System.Drawing.Point(3, 3);
            this.tspPlayerPanel.Name = "tspPlayerPanel";
            this.tspPlayerPanel.RowCount = 2;
            this.tspPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tspPlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tspPlayerPanel.Size = new System.Drawing.Size(600, 452);
            this.tspPlayerPanel.TabIndex = 0;
            // 
            // tspPlayControlPanel
            // 
            this.tspPlayControlPanel.ColumnCount = 4;
            this.tspPlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tspPlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tspPlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tspPlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tspPlayControlPanel.Controls.Add(this.tspPlayButton, 2, 0);
            this.tspPlayControlPanel.Controls.Add(this.tspStopButton, 3, 0);
            this.tspPlayControlPanel.Controls.Add(this.tspSolutionSlider, 0, 0);
            this.tspPlayControlPanel.Controls.Add(this.tspSolutionSpinButton, 1, 0);
            this.tspPlayControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tspPlayControlPanel.Location = new System.Drawing.Point(3, 419);
            this.tspPlayControlPanel.Name = "tspPlayControlPanel";
            this.tspPlayControlPanel.RowCount = 1;
            this.tspPlayControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tspPlayControlPanel.Size = new System.Drawing.Size(594, 30);
            this.tspPlayControlPanel.TabIndex = 5;
            // 
            // tspPlayButton
            // 
            this.tspPlayButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30play;
            this.tspPlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tspPlayButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspPlayButton.Location = new System.Drawing.Point(537, 3);
            this.tspPlayButton.Name = "tspPlayButton";
            this.tspPlayButton.Size = new System.Drawing.Size(24, 24);
            this.tspPlayButton.TabIndex = 1;
            this.tspPlayButton.UseVisualStyleBackColor = true;
            this.tspPlayButton.Click += new System.EventHandler(this.tspPlayButton_Click);
            // 
            // tspStopButton
            // 
            this.tspStopButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30stop;
            this.tspStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tspStopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspStopButton.Location = new System.Drawing.Point(567, 3);
            this.tspStopButton.Name = "tspStopButton";
            this.tspStopButton.Size = new System.Drawing.Size(24, 24);
            this.tspStopButton.TabIndex = 2;
            this.tspStopButton.UseVisualStyleBackColor = true;
            this.tspStopButton.Click += new System.EventHandler(this.tspStopButton_Click);
            // 
            // tspSolutionSlider
            // 
            this.tspSolutionSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspSolutionSlider.LargeChange = 50;
            this.tspSolutionSlider.Location = new System.Drawing.Point(3, 3);
            this.tspSolutionSlider.Maximum = 466;
            this.tspSolutionSlider.Minimum = 1;
            this.tspSolutionSlider.Name = "tspSolutionSlider";
            this.tspSolutionSlider.Size = new System.Drawing.Size(464, 24);
            this.tspSolutionSlider.TabIndex = 3;
            this.tspSolutionSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tspSolutionSlider.Value = 1;
            this.tspSolutionSlider.Scroll += new System.EventHandler(this.tspSolutionSlider_Scroll);
            // 
            // tspSolutionSpinButton
            // 
            this.tspSolutionSpinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspSolutionSpinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tspSolutionSpinButton.Location = new System.Drawing.Point(473, 3);
            this.tspSolutionSpinButton.Maximum = new decimal(new int[] {
            466,
            0,
            0,
            0});
            this.tspSolutionSpinButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tspSolutionSpinButton.Name = "tspSolutionSpinButton";
            this.tspSolutionSpinButton.Size = new System.Drawing.Size(58, 26);
            this.tspSolutionSpinButton.TabIndex = 0;
            this.tspSolutionSpinButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tspSolutionSpinButton.ValueChanged += new System.EventHandler(this.tspSolutionSpinButton_ValueChanged);
            // 
            // tspPaintPanel
            // 
            this.tspPaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tspPaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspPaintPanel.Location = new System.Drawing.Point(3, 3);
            this.tspPaintPanel.Name = "tspPaintPanel";
            this.tspPaintPanel.Size = new System.Drawing.Size(594, 410);
            this.tspPaintPanel.TabIndex = 6;
            this.tspPaintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tspPaintPanel_Paint);
            // 
            // cpmpTab
            // 
            this.cpmpTab.Location = new System.Drawing.Point(4, 22);
            this.cpmpTab.Name = "cpmpTab";
            this.cpmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.cpmpTab.Size = new System.Drawing.Size(606, 458);
            this.cpmpTab.TabIndex = 1;
            this.cpmpTab.Text = "CPMP";
            this.cpmpTab.UseVisualStyleBackColor = true;
            this.cpmpTab.Click += new System.EventHandler(this.cpmpTab_Click);
            // 
            // TrajectoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 502);
            this.Controls.Add(this.algorithmTab);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrajectoryDisplay";
            this.Text = "TSP与CPMP求解过程演示";
            this.algorithmTab.ResumeLayout(false);
            this.tspTab.ResumeLayout(false);
            this.tspPlayerPanel.ResumeLayout(false);
            this.tspPlayControlPanel.ResumeLayout(false);
            this.tspPlayControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tspSolutionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tspSolutionSpinButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl algorithmTab;
        private System.Windows.Forms.TabPage tspTab;
        private System.Windows.Forms.TabPage cpmpTab;
        private System.Windows.Forms.TableLayoutPanel tspPlayerPanel;
        private System.Windows.Forms.TableLayoutPanel tspPlayControlPanel;
        private System.Windows.Forms.NumericUpDown tspSolutionSpinButton;
        private System.Windows.Forms.Button tspPlayButton;
        private System.Windows.Forms.Button tspStopButton;
        private System.Windows.Forms.TrackBar tspSolutionSlider;
        private System.Windows.Forms.Panel tspPaintPanel;
    }
}

