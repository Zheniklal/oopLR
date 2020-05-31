using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;
using System.Drawing;
using System.Windows.Forms;


namespace TrapeziumLibrary
{
    [Serializable]
    public class Trapezium : Figure
    {
        private float x1, y1, x2, y2;

        public Trapezium(float x1, float y1, float x2, float y2, Color col, float thickness)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.col = col;
            this.thickness = thickness;
        }
        public override void Drawing(PaintEventArgs e)
        {
            Pen myPen = new Pen(col, thickness);
            e.Graphics.DrawLine(myPen, x1, y1, x1 + (x2 - x1) / 2, y1);
            e.Graphics.DrawLine(myPen, x1 + (x2 - x1) / 2, y1, x2, y2);
            e.Graphics.DrawLine(myPen, x1, y1, x1 + (x1 - x2) / 2, y2);
            e.Graphics.DrawLine(myPen, x1 + (x1 - x2) / 2, y2, x2, y2);
        }
    }
}
