namespace homework9
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
			this.LtbxInfo = new System.Windows.Forms.ListBox();
			this.GbxStartUrl = new System.Windows.Forms.GroupBox();
			this.BtnStop = new System.Windows.Forms.Button();
			this.BtnContinue = new System.Windows.Forms.Button();
			this.BtnPause = new System.Windows.Forms.Button();
			this.BtnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TbxStartUrl = new System.Windows.Forms.TextBox();
			this.GbxStartUrl.SuspendLayout();
			this.SuspendLayout();
			// 
			// LtbxInfo
			// 
			this.LtbxInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LtbxInfo.FormattingEnabled = true;
			this.LtbxInfo.ItemHeight = 12;
			this.LtbxInfo.Location = new System.Drawing.Point(81, 83);
			this.LtbxInfo.Margin = new System.Windows.Forms.Padding(2);
			this.LtbxInfo.Name = "LtbxInfo";
			this.LtbxInfo.Size = new System.Drawing.Size(511, 268);
			this.LtbxInfo.TabIndex = 0;
			// 
			// GbxStartUrl
			// 
			this.GbxStartUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GbxStartUrl.Controls.Add(this.label1);
			this.GbxStartUrl.Controls.Add(this.TbxStartUrl);
			this.GbxStartUrl.Location = new System.Drawing.Point(9, 17);
			this.GbxStartUrl.Margin = new System.Windows.Forms.Padding(2);
			this.GbxStartUrl.Name = "GbxStartUrl";
			this.GbxStartUrl.Padding = new System.Windows.Forms.Padding(2);
			this.GbxStartUrl.Size = new System.Drawing.Size(582, 49);
			this.GbxStartUrl.TabIndex = 1;
			this.GbxStartUrl.TabStop = false;
			// 
			// BtnStop
			// 
			this.BtnStop.Location = new System.Drawing.Point(9, 254);
			this.BtnStop.Margin = new System.Windows.Forms.Padding(2);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(56, 37);
			this.BtnStop.TabIndex = 5;
			this.BtnStop.Text = "结束";
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// BtnContinue
			// 
			this.BtnContinue.Location = new System.Drawing.Point(9, 193);
			this.BtnContinue.Margin = new System.Windows.Forms.Padding(2);
			this.BtnContinue.Name = "BtnContinue";
			this.BtnContinue.Size = new System.Drawing.Size(56, 37);
			this.BtnContinue.TabIndex = 4;
			this.BtnContinue.Text = "继续";
			this.BtnContinue.UseVisualStyleBackColor = true;
			this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
			// 
			// BtnPause
			// 
			this.BtnPause.Location = new System.Drawing.Point(9, 135);
			this.BtnPause.Margin = new System.Windows.Forms.Padding(2);
			this.BtnPause.Name = "BtnPause";
			this.BtnPause.Size = new System.Drawing.Size(56, 37);
			this.BtnPause.TabIndex = 3;
			this.BtnPause.Text = "暂停";
			this.BtnPause.UseVisualStyleBackColor = true;
			this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
			// 
			// BtnStart
			// 
			this.BtnStart.Location = new System.Drawing.Point(10, 83);
			this.BtnStart.Margin = new System.Windows.Forms.Padding(2);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(56, 37);
			this.BtnStart.TabIndex = 2;
			this.BtnStart.Text = "开始";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(4, 22);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "起始地址";
			// 
			// TbxStartUrl
			// 
			this.TbxStartUrl.Location = new System.Drawing.Point(72, 19);
			this.TbxStartUrl.Margin = new System.Windows.Forms.Padding(2);
			this.TbxStartUrl.Name = "TbxStartUrl";
			this.TbxStartUrl.Size = new System.Drawing.Size(506, 21);
			this.TbxStartUrl.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 360);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.GbxStartUrl);
			this.Controls.Add(this.BtnContinue);
			this.Controls.Add(this.LtbxInfo);
			this.Controls.Add(this.BtnPause);
			this.Controls.Add(this.BtnStart);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.GbxStartUrl.ResumeLayout(false);
			this.GbxStartUrl.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LtbxInfo;
        private System.Windows.Forms.GroupBox GbxStartUrl;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxStartUrl;
        private System.Windows.Forms.Button BtnStop;
    }
}
