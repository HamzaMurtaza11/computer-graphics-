using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace _2d3dtransformation
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Create a Graphics obhect
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
           
            // Create a Matrix object
            Matrix X = new Matrix();
            // Translate by 100 in the x direction
            // and 100 in the y direction
            X.Translate(50,0);
            // Apply transformation
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a Graphics obhect
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create a Matrix object
            Matrix X = new Matrix();
            // Translate by 100 in the x direction
            // and 100 in the y direction
            X.Translate(50, 50);
            // Apply transformation
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a Graphics obhect
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create a Matrix object
            Matrix X = new Matrix();
            // Translate by 100 in the x direction
            // and 100 in the y direction
            X.Translate(100, 100);
            // Apply transformation
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
        }
    }
}
