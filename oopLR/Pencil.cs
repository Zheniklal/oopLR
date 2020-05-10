using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oopLR
{
    [Serializable]
    class Pencil : Figure
    {
        private float x1, x2, y1, y2;
        public Pencil(float x1, float y1, float x2, float y2, Color col, float thickness)
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
            e.Graphics.DrawLine(myPen, x1, y1, x2, y2);
        }
    }
}
