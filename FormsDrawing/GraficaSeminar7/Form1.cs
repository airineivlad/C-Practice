using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficaSeminar7
{
    public partial class Form1 : Form
    {
        Pen penCrt; Pen[] vectPen;
        SolidBrush brCrt; SolidBrush[] vectBrush;
        string[] den;
        float[] val;
        int nrCulori;
        RectangleF r;

        public Form1()
        {
            InitializeComponent();
            penCrt = new Pen(Color.Black, 2);
            brCrt = new SolidBrush(Color.Blue);
            den = new string[] {"Bila", "Metro", "Kaufland", "Cora"};
            val = new float[] {1500, 2700, 1300, 3000};
            vectPen = new Pen[] {
                new Pen(Color.Coral),
                new Pen(Color.BurlyWood),
                new Pen(Color.Green),
                new Pen(Color.Red),
                new Pen(Color.Yellow),
                new Pen(Color.Violet),
            };
            vectBrush = new SolidBrush[]{
                new SolidBrush(Color.Coral),
                new SolidBrush(Color.BurlyWood),
                new SolidBrush(Color.Green),
                new SolidBrush(Color.LightBlue),
                new SolidBrush(Color.MidnightBlue),
                new SolidBrush(Color.OrangeRed)
            };
            nrCulori = vectPen.Length;
        }

        private void panel1_PaintBare(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Deseneaza bare", Font, brCrt, new Point(10, 10));
        }

        private void panel1_PaintPie(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawString("Deseneaza pie", Font, brCrt, new Point(10, 10));
            r = panel1.ClientRectangle; float start, valU; 
           
            float sum = 0;
            for (int i = 0; i < den.Length; i++)
            {
                sum += val[i];

            }
            start = 0; valU = 0;

            for (int i = 0; i < den.Length; i++)
            {
                valU = (val[i]*360)/sum;
                penCrt = vectPen[i%nrCulori];
                brCrt = vectBrush[i % nrCulori];
                g.DrawPie(penCrt, r, start, valU);
                g.FillPie(brCrt, r.X, r.Y, r.Width, r.Height, start, valU);
                start += valU;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)//Bare
        {
            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintBare);
            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);
            tbMes.Text += "\r\nA ajuns in Bare";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_PaintBare);

            panel1.Invalidate();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)//Pie
        {
            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);
            this.panel1.Paint -= new System.Windows.Forms.PaintEventHandler(this.panel1_PaintBare);
            tbMes.Text += "\r\nA ajuns in Pie";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_PaintPie);

            panel1.Invalidate();

        }
    }
}
