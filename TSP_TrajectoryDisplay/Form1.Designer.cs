namespace TSP_TrajectoryDisplay
{
    partial class Form1
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
            this.AlgorithmTab.SuspendLayout();
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
            this.AlgorithmTab.Size = new System.Drawing.Size(474, 317);
            this.AlgorithmTab.TabIndex = 0;
            this.AlgorithmTab.Tag = "";
            // 
            // TSPtab
            // 
            this.TSPtab.Location = new System.Drawing.Point(4, 22);
            this.TSPtab.Name = "TSPtab";
            this.TSPtab.Padding = new System.Windows.Forms.Padding(3);
            this.TSPtab.Size = new System.Drawing.Size(466, 291);
            this.TSPtab.TabIndex = 0;
            this.TSPtab.Text = "TSP";
            this.TSPtab.UseVisualStyleBackColor = true;
            // 
            // CPMPtab
            // 
            this.CPMPtab.Location = new System.Drawing.Point(4, 22);
            this.CPMPtab.Name = "CPMPtab";
            this.CPMPtab.Padding = new System.Windows.Forms.Padding(3);
            this.CPMPtab.Size = new System.Drawing.Size(466, 291);
            this.CPMPtab.TabIndex = 1;
            this.CPMPtab.Text = "CPMP";
            this.CPMPtab.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 341);
            this.Controls.Add(this.AlgorithmTab);
            this.Name = "Form1";
            this.Text = "Form1";
            this.AlgorithmTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AlgorithmTab;
        private System.Windows.Forms.TabPage TSPtab;
        private System.Windows.Forms.TabPage CPMPtab;
    }
}

