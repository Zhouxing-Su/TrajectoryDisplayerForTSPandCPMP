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
            this.cpmpTab = new System.Windows.Forms.TabPage();
            this.tspPlayerPanel = new PlayerPanel.TspPlayerPanel();
            this.algorithmTab.SuspendLayout();
            this.tspTab.SuspendLayout();
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
            this.algorithmTab.SelectedIndexChanged += new System.EventHandler(this.algorithmTab_SelectedIndexChanged);
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
            // tspPlayerPanel
            // 
            this.tspPlayerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tspPlayerPanel.Location = new System.Drawing.Point(3, 3);
            this.tspPlayerPanel.Name = "tspPlayerPanel";
            this.tspPlayerPanel.Size = new System.Drawing.Size(600, 452);
            this.tspPlayerPanel.TabIndex = 0;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl algorithmTab;
        private System.Windows.Forms.TabPage tspTab;
        private System.Windows.Forms.TabPage cpmpTab;
        private PlayerPanel.TspPlayerPanel tspPlayerPanel;
    }
}

