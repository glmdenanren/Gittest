namespace homework7
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
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.colorpen = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.angleleft = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.angleright = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.depth = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.length = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.perleft = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.perright = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(605, 374);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(60, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "Creat";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(714, 376);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(62, 21);
			this.button2.TabIndex = 1;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// colorpen
			// 
			this.colorpen.Location = new System.Drawing.Point(686, 329);
			this.colorpen.Name = "colorpen";
			this.colorpen.Size = new System.Drawing.Size(90, 21);
			this.colorpen.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(543, 332);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(137, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "颜色（红、黄、蓝、黑）";
			// 
			// angleleft
			// 
			this.angleleft.Location = new System.Drawing.Point(686, 302);
			this.angleleft.Name = "angleleft";
			this.angleleft.Size = new System.Drawing.Size(90, 21);
			this.angleleft.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(603, 305);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "左分支角度";
			// 
			// angleright
			// 
			this.angleright.Location = new System.Drawing.Point(686, 275);
			this.angleright.Name = "angleright";
			this.angleright.Size = new System.Drawing.Size(90, 21);
			this.angleright.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(603, 278);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "右分支角度";
			// 
			// depth
			// 
			this.depth.Location = new System.Drawing.Point(686, 103);
			this.depth.Name = "depth";
			this.depth.Size = new System.Drawing.Size(87, 21);
			this.depth.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(603, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "递归深度";
			// 
			// length
			// 
			this.length.Location = new System.Drawing.Point(686, 146);
			this.length.Name = "length";
			this.length.Size = new System.Drawing.Size(87, 21);
			this.length.TabIndex = 10;
			this.length.TextChanged += new System.EventHandler(this.length_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(603, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "主干长度";
			// 
			// perleft
			// 
			this.perleft.Location = new System.Drawing.Point(686, 187);
			this.perleft.Name = "perleft";
			this.perleft.Size = new System.Drawing.Size(87, 21);
			this.perleft.TabIndex = 12;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(603, 190);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 12);
			this.label6.TabIndex = 13;
			this.label6.Text = "左分支长度比";
			// 
			// perright
			// 
			this.perright.Location = new System.Drawing.Point(687, 218);
			this.perright.Name = "perright";
			this.perright.Size = new System.Drawing.Size(86, 21);
			this.perright.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(604, 221);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 12);
			this.label7.TabIndex = 15;
			this.label7.Text = "右分支长度比";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.perright);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.perleft);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.length);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.depth);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.angleright);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.angleleft);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.colorpen);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox colorpen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox angleleft;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox angleright;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox depth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox length;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox perleft;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox perright;
		private System.Windows.Forms.Label label7;
	}
}

