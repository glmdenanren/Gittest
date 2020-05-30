using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;

        void DrawCaleyTree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCaleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCaleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0, double y0, double x1, double y1)
        {
            string colorOfPen = colorpen.Text;
            switch (colorOfPen)
            {
                case "红":
                    graphics.DrawLine(Pens.Red, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "蓝":
                    graphics.DrawLine(Pens.Blue, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黄":
                    graphics.DrawLine(Pens.Yellow, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
                case "黑":
                    graphics.DrawLine(Pens.Black, (int)x0, (int)y0, (int)x1, (int)y1);
                    break;
            }
        }

		private void button1_Click(object sender, EventArgs e)
		{
            int dep = 0;
            int leng = 0;
            try
            {
                dep = Int32.Parse(depth.Text);
                per1 = Double.Parse(perleft.Text);
                per2 = Double.Parse(perright.Text);
                leng = Int32.Parse(length.Text);
                th1 = Double.Parse(angleright.Text) * Math.PI / 180;
                th2 = Double.Parse(angleleft.Text) * Math.PI / 180;
                if (dep < 0 || per1 < 0 || per2 < 0 || leng < 0)
                    MessageBox.Show("输入错误");
            }
            catch
            {
                MessageBox.Show("输入错误");
            }

            //if (graphics == null) graphics = this.CreateGraphics();
            graphics = this.CreateGraphics();
            DrawCaleyTree(dep, 200, 310, leng, -Math.PI / 2);
        }

		private void button2_Click(object sender, EventArgs e)
		{
            graphics = this.CreateGraphics();
            graphics.Clear(this.BackColor);
        }

		private void length_TextChanged(object sender, EventArgs e)
		{

		}
	}
}