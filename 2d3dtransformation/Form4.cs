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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 90);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 90);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
           
            // Create Matrix object
            Matrix X = new Matrix();
            // Apply 3X scaling
            X.Scale(3, 4, MatrixOrder.Append);
            // Apply transformation on the form
            g.Transform = X; 
                Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 160, 20, 50, 50);
          


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);

            // Create Matrix object
            Matrix X = new Matrix();
            // Apply 3X scaling
            X.Scale(1, 1, MatrixOrder.Append);
            // Apply transformation on the form
            g.Transform = X; 

                Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 190, 80, 50);

        }
    }
}
