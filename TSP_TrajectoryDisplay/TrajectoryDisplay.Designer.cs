namespace TSP_TrajectoryDisplay
{
    partial class trajectoryDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trajectoryDisplay));
            this.algorithmTab = new System.Windows.Forms.TabControl();
            this.tspTab = new System.Windows.Forms.TabPage();
            this.playerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.solutionSlider = new System.Windows.Forms.TrackBar();
            this.solutionSpinButton = new System.Windows.Forms.NumericUpDown();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.cpmpTab = new System.Windows.Forms.TabPage();
            this.algorithmTab.SuspendLayout();
            this.tspTab.SuspendLayout();
            this.playerPanel.SuspendLayout();
            this.playControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionSpinButton)).BeginInit();
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
            this.tspTab.Controls.Add(this.playerPanel);
            this.tspTab.Location = new System.Drawing.Point(4, 22);
            this.tspTab.Name = "tspTab";
            this.tspTab.Padding = new System.Windows.Forms.Padding(3);
            this.tspTab.Size = new System.Drawing.Size(606, 458);
            this.tspTab.TabIndex = 0;
            this.tspTab.Text = "TSP";
            this.tspTab.UseVisualStyleBackColor = true;
            // 
            // playerPanel
            // 
            this.playerPanel.ColumnCount = 1;
            this.playerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerPanel.Controls.Add(this.playControlPanel, 0, 1);
            this.playerPanel.Controls.Add(this.paintPanel, 0, 0);
            this.playerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playerPanel.Location = new System.Drawing.Point(3, 3);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.RowCount = 2;
            this.playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.playerPanel.Size = new System.Drawing.Size(600, 452);
            this.playerPanel.TabIndex = 0;
            // 
            // playControlPanel
            // 
            this.playControlPanel.ColumnCount = 4;
            this.playControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.playControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.playControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.playControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.playControlPanel.Controls.Add(this.playButton, 2, 0);
            this.playControlPanel.Controls.Add(this.stopButton, 3, 0);
            this.playControlPanel.Controls.Add(this.solutionSlider, 0, 0);
            this.playControlPanel.Controls.Add(this.solutionSpinButton, 1, 0);
            this.playControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playControlPanel.Location = new System.Drawing.Point(3, 419);
            this.playControlPanel.Name = "playControlPanel";
            this.playControlPanel.RowCount = 1;
            this.playControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.playControlPanel.Size = new System.Drawing.Size(594, 30);
            this.playControlPanel.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30play;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.playButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playButton.Location = new System.Drawing.Point(537, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(24, 24);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30stop;
            this.stopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopButton.Location = new System.Drawing.Point(567, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(24, 24);
            this.stopButton.TabIndex = 2;
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // solutionSlider
            // 
            this.solutionSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionSlider.LargeChange = 50;
            this.solutionSlider.Location = new System.Drawing.Point(3, 3);
            this.solutionSlider.Maximum = 466;
            this.solutionSlider.Minimum = 1;
            this.solutionSlider.Name = "solutionSlider";
            this.solutionSlider.Size = new System.Drawing.Size(464, 24);
            this.solutionSlider.TabIndex = 3;
            this.solutionSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            this.solutionSlider.Value = 1;
            this.solutionSlider.Scroll += new System.EventHandler(this.solutionSlider_Scroll);
            // 
            // solutionSpinButton
            // 
            this.solutionSpinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionSpinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.solutionSpinButton.Location = new System.Drawing.Point(473, 3);
            this.solutionSpinButton.Maximum = new decimal(new int[] {
            466,
            0,
            0,
            0});
            this.solutionSpinButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.solutionSpinButton.Name = "solutionSpinButton";
            this.solutionSpinButton.Size = new System.Drawing.Size(58, 26);
            this.solutionSpinButton.TabIndex = 0;
            this.solutionSpinButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.solutionSpinButton.ValueChanged += new System.EventHandler(this.solutionSpinButton_ValueChanged);
            // 
            // paintPanel
            // 
            this.paintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paintPanel.Location = new System.Drawing.Point(3, 3);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(594, 410);
            this.paintPanel.TabIndex = 6;
            this.paintPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.paintPanel_Paint);
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
            // 
            // trajectoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 502);
            this.Controls.Add(this.algorithmTab);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "trajectoryDisplay";
            this.Text = "TSP与CPMP求解过程演示";
            this.algorithmTab.ResumeLayout(false);
            this.tspTab.ResumeLayout(false);
            this.playerPanel.ResumeLayout(false);
            this.playControlPanel.ResumeLayout(false);
            this.playControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.solutionSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solutionSpinButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl algorithmTab;
        private System.Windows.Forms.TabPage tspTab;
        private System.Windows.Forms.TabPage cpmpTab;
        private System.Windows.Forms.TableLayoutPanel playerPanel;
        private System.Windows.Forms.TableLayoutPanel playControlPanel;
        private System.Windows.Forms.NumericUpDown solutionSpinButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar solutionSlider;
        private System.Windows.Forms.Panel paintPanel;
    }
}

