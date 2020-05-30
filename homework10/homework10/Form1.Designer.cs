namespace homework10
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
			this.GbxStartUrl = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.BtnStop = new System.Windows.Forms.Button();
			this.BtnContinue = new System.Windows.Forms.Button();
			this.BtnPause = new System.Windows.Forms.Button();
			this.BtnStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.TbxStartUrl = new System.Windows.Forms.TextBox();
			this.dgvResult = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LblInfo = new System.Windows.Forms.Label();
			this.GbxStartUrl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
			this.SuspendLayout();
			// 
			// GbxStartUrl
			// 
			this.GbxStartUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GbxStartUrl.Controls.Add(this.label1);
			this.GbxStartUrl.Controls.Add(this.TbxStartUrl);
			this.GbxStartUrl.Location = new System.Drawing.Point(9, 17);
			this.GbxStartUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GbxStartUrl.Name = "GbxStartUrl";
			this.GbxStartUrl.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.GbxStartUrl.Size = new System.Drawing.Size(860, 62);
			this.GbxStartUrl.TabIndex = 1;
			this.GbxStartUrl.TabStop = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(39, 353);
			this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 38);
			this.button1.TabIndex = 6;
			this.button1.Text = "并行";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnStop
			// 
			this.BtnStop.Location = new System.Drawing.Point(39, 289);
			this.BtnStop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(56, 39);
			this.BtnStop.TabIndex = 5;
			this.BtnStop.Text = "结束";
			this.BtnStop.UseVisualStyleBackColor = true;
			this.BtnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// BtnContinue
			// 
			this.BtnContinue.Location = new System.Drawing.Point(39, 223);
			this.BtnContinue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BtnContinue.Name = "BtnContinue";
			this.BtnContinue.Size = new System.Drawing.Size(56, 39);
			this.BtnContinue.TabIndex = 4;
			this.BtnContinue.Text = "继续";
			this.BtnContinue.UseVisualStyleBackColor = true;
			this.BtnContinue.Click += new System.EventHandler(this.BtnContinue_Click);
			// 
			// BtnPause
			// 
			this.BtnPause.Location = new System.Drawing.Point(39, 156);
			this.BtnPause.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BtnPause.Name = "BtnPause";
			this.BtnPause.Size = new System.Drawing.Size(56, 40);
			this.BtnPause.TabIndex = 3;
			this.BtnPause.Text = "暂停";
			this.BtnPause.UseVisualStyleBackColor = true;
			this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
			// 
			// BtnStart
			// 
			this.BtnStart.Location = new System.Drawing.Point(39, 96);
			this.BtnStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(56, 39);
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
			this.TbxStartUrl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.TbxStartUrl.Name = "TbxStartUrl";
			this.TbxStartUrl.Size = new System.Drawing.Size(653, 21);
			this.TbxStartUrl.TabIndex = 0;
			this.TbxStartUrl.Text = "https://www.cnblogs.com/";
			// 
			// dgvResult
			// 
			this.dgvResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dgvResult.Location = new System.Drawing.Point(147, 83);
			this.dgvResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dgvResult.Name = "dgvResult";
			this.dgvResult.RowHeadersWidth = 51;
			this.dgvResult.RowTemplate.Height = 27;
			this.dgvResult.Size = new System.Drawing.Size(722, 401);
			this.dgvResult.TabIndex = 3;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Index";
			this.Column1.HeaderText = "index";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 125;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "URL";
			this.Column2.HeaderText = "url";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 500;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Status";
			this.Column3.HeaderText = "status";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Width = 125;
			// 
			// LblInfo
			// 
			this.LblInfo.AutoSize = true;
			this.LblInfo.Location = new System.Drawing.Point(14, 96);
			this.LblInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.LblInfo.Name = "LblInfo";
			this.LblInfo.Size = new System.Drawing.Size(0, 12);
			this.LblInfo.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(878, 494);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.LblInfo);
			this.Controls.Add(this.BtnStop);
			this.Controls.Add(this.dgvResult);
			this.Controls.Add(this.BtnContinue);
			this.Controls.Add(this.GbxStartUrl);
			this.Controls.Add(this.BtnPause);
			this.Controls.Add(this.BtnStart);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Form1";
			this.Text = "Form1";
			this.GbxStartUrl.ResumeLayout(false);
			this.GbxStartUrl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox GbxStartUrl;
        private System.Windows.Forms.Button BtnContinue;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxStartUrl;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;
    }
}

