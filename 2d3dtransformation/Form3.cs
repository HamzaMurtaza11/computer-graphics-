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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500,200,100,50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            // Create a Graphics object
            Graphics g = this.CreateGraphics();

            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(780.0f,180.0f);
            // Rotate by 45 degrees
            X.RotateAt(330, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(350.0f, 120.0f);
            // Rotate by 45 degrees
            X.RotateAt(45, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(580.0f, 170.0f);
            // Rotate by 45 degrees
            X.RotateAt(270, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(530.0f,150.0f);
            // Rotate by 45 degrees
            X.RotateAt(210, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(500.0f, 150.0f);
            // Rotate by 45 degrees
            X.RotateAt(180, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(460.0f, 140.0f);
            // Rotate by 45 degrees
            X.RotateAt(120, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            // Create a Matrix object
            Matrix X = new Matrix();
            // Create a point
            PointF pt = new PointF(640.0f, 190.0f);
            // Rotate by 45 degrees
            X.RotateAt(270, pt, MatrixOrder.Append);
            // Apply the Matrix object to the Graphics object
            // (i.e., to all the graphics items
            // drawn on the Graphics object)
            g.Transform = X;
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 50, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 50, 100, 50);
            // Dispose of object
            g.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Create a Graphics object
            Graphics g = this.CreateGraphics();
            g.Clear(this.BackColor);
            Pen p1 = new Pen(Color.Blue);
            g.DrawRectangle(p1, 500, 200, 100, 50);
            // Fill a rectangle
            g.FillRectangle(Brushes.Transparent, 500, 200, 100, 50);
        }
    }
}
