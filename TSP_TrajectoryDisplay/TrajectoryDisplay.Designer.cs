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
            this.AlgorithmTab = new System.Windows.Forms.TabControl();
            this.TSPtab = new System.Windows.Forms.TabPage();
            this.CPMPtab = new System.Windows.Forms.TabPage();
            this.PlayerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayControlPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SolutionSpinButton = new System.Windows.Forms.NumericUpDown();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SolutionSlider = new System.Windows.Forms.TrackBar();
            this.PaintPanel = new System.Windows.Forms.Panel();
            this.AlgorithmTab.SuspendLayout();
            this.TSPtab.SuspendLayout();
            this.PlayerPanel.SuspendLayout();
            this.PlayControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionSpinButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // AlgorithmTab
            // 
            this.AlgorithmTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlgorithmTab.Controls.Add(this.TSPtab);
            this.AlgorithmTab.Controls.Add(this.CPMPtab);
            this.AlgorithmTab.Location = new System.Drawing.Point(12, 12);
            this.AlgorithmTab.Name = "AlgorithmTab";
            this.AlgorithmTab.SelectedIndex = 0;
            this.AlgorithmTab.Size = new System.Drawing.Size(446, 391);
            this.AlgorithmTab.TabIndex = 0;
            this.AlgorithmTab.Tag = "";
            // 
            // TSPtab
            // 
            this.TSPtab.Controls.Add(this.PlayerPanel);
            this.TSPtab.Location = new System.Drawing.Point(4, 22);
            this.TSPtab.Name = "TSPtab";
            this.TSPtab.Padding = new System.Windows.Forms.Padding(3);
            this.TSPtab.Size = new System.Drawing.Size(438, 365);
            this.TSPtab.TabIndex = 0;
            this.TSPtab.Text = "TSP";
            this.TSPtab.UseVisualStyleBackColor = true;
            // 
            // CPMPtab
            // 
            this.CPMPtab.Location = new System.Drawing.Point(4, 22);
            this.CPMPtab.Name = "CPMPtab";
            this.CPMPtab.Padding = new System.Windows.Forms.Padding(3);
            this.CPMPtab.Size = new System.Drawing.Size(438, 365);
            this.CPMPtab.TabIndex = 1;
            this.CPMPtab.Text = "CPMP";
            this.CPMPtab.UseVisualStyleBackColor = true;
            // 
            // PlayerPanel
            // 
            this.PlayerPanel.ColumnCount = 1;
            this.PlayerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerPanel.Controls.Add(this.PlayControlPanel, 0, 1);
            this.PlayerPanel.Controls.Add(this.PaintPanel, 0, 0);
            this.PlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerPanel.Location = new System.Drawing.Point(3, 3);
            this.PlayerPanel.Name = "PlayerPanel";
            this.PlayerPanel.RowCount = 2;
            this.PlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.PlayerPanel.Size = new System.Drawing.Size(432, 359);
            this.PlayerPanel.TabIndex = 0;
            // 
            // PlayControlPanel
            // 
            this.PlayControlPanel.ColumnCount = 4;
            this.PlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.PlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PlayControlPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.PlayControlPanel.Controls.Add(this.SolutionSpinButton, 1, 0);
            this.PlayControlPanel.Controls.Add(this.StartButton, 2, 0);
            this.PlayControlPanel.Controls.Add(this.StopButton, 3, 0);
            this.PlayControlPanel.Controls.Add(this.SolutionSlider, 0, 0);
            this.PlayControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlayControlPanel.Location = new System.Drawing.Point(3, 326);
            this.PlayControlPanel.Name = "PlayControlPanel";
            this.PlayControlPanel.RowCount = 1;
            this.PlayControlPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PlayControlPanel.Size = new System.Drawing.Size(426, 30);
            this.PlayControlPanel.TabIndex = 5;
            // 
            // SolutionSpinButton
            // 
            this.SolutionSpinButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolutionSpinButton.Location = new System.Drawing.Point(309, 3);
            this.SolutionSpinButton.Maximum = new decimal(new int[] {
            466,
            0,
            0,
            0});
            this.SolutionSpinButton.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SolutionSpinButton.Name = "SolutionSpinButton";
            this.SolutionSpinButton.Size = new System.Drawing.Size(54, 21);
            this.SolutionSpinButton.TabIndex = 0;
            this.SolutionSpinButton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30play;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StartButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartButton.Location = new System.Drawing.Point(369, 3);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(24, 24);
            this.StartButton.TabIndex = 1;
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // StopButton
            // 
            this.StopButton.BackgroundImage = global::TSP_TrajectoryDisplay.Properties.Resources._30stop;
            this.StopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.StopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StopButton.Location = new System.Drawing.Point(399, 3);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(24, 24);
            this.StopButton.TabIndex = 2;
            this.StopButton.UseVisualStyleBackColor = true;
            // 
            // SolutionSlider
            // 
            this.SolutionSlider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SolutionSlider.LargeChange = 50;
            this.SolutionSlider.Location = new System.Drawing.Point(3, 3);
            this.SolutionSlider.Maximum = 466;
            this.SolutionSlider.Name = "SolutionSlider";
            this.SolutionSlider.Size = new System.Drawing.Size(300, 24);
            this.SolutionSlider.TabIndex = 3;
            this.SolutionSlider.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // PaintPanel
            // 
            this.PaintPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaintPanel.Location = new System.Drawing.Point(3, 3);
            this.PaintPanel.Name = "PaintPanel";
            this.PaintPanel.Size = new System.Drawing.Size(426, 317);
            this.PaintPanel.TabIndex = 6;
            // 
            // TrajectoryDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 410);
            this.Controls.Add(this.AlgorithmTab);
            this.Name = "TrajectoryDisplay";
            this.Text = "TSP与CPMP求解过程演示";
            this.AlgorithmTab.ResumeLayout(false);
            this.TSPtab.ResumeLayout(false);
            this.PlayerPanel.ResumeLayout(false);
            this.PlayControlPanel.ResumeLayout(false);
            this.PlayControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionSpinButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SolutionSlider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AlgorithmTab;
        private System.Windows.Forms.TabPage TSPtab;
        private System.Windows.Forms.TabPage CPMPtab;
        private System.Windows.Forms.TableLayoutPanel PlayerPanel;
        private System.Windows.Forms.TableLayoutPanel PlayControlPanel;
        private System.Windows.Forms.NumericUpDown SolutionSpinButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TrackBar SolutionSlider;
        private System.Windows.Forms.Panel PaintPanel;
    }
}

