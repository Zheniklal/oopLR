using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using FigureLibrary;

namespace oopLR
{
    [Serializable]
    public class Ellipse : Figure
    {
        private float x, y;
        private float centerX,centerY;
        public Ellipse(float x, float y, float x1, float y1, Color col, float thickness)
        {
            this.x = x;
            this.y = y;
            this.centerX = x1;
            this.centerY = y1;
            this.col = col;
            this.thickness = thickness;
        }
        public override void Drawing(PaintEventArgs e)
        {
            Pen myPen = new Pen(col, thickness);
            e.Graphics.DrawEllipse(myPen, x, y, centerX - x, centerY - y);
        }
    }
}
