using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rainbow_animation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Color[] c = new Color[10];
        int y = 0;
        void panel1_Paint(object sender, PaintEventArgs e)
        {
            c[0] = Color.Red;
            c[1] = Color.Orange;
            c[2] = Color.Yellow;
            c[3] = Color.Green;
            c[4] = Color.LightBlue;
            c[5] = Color.Blue;
            c[6] = Color.Violet;

            Graphics g = e.Graphics;
            for (int i = 0; i < 7; i++)
            {
                g.FillRectangle(new SolidBrush(c[i]), 0, panel1.Height * (i) / 7+y, panel1.Width, panel1.Height / 7);
            }
            for (int i = 0; i < 7; i++)
            {
                g.FillRectangle(new SolidBrush(c[i]), 0, panel1.Height * (i+7) / 7 + y, panel1.Width, panel1.Height / 7);
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            y-=1;
            if (y < -panel1.Height) y = 0;
            panel1.Invalidate();
        }
    }
}