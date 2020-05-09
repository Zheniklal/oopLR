using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oopLR
{
    [Serializable]
    public class Rectangle : Figure
    {
        private float height;
        private float width;
        private float x1, y1, x2, y2;
        public Rectangle(float x1, float y1, float x2, float y2, Pen myPen)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.height = y2 - y1;
            this.width = x2 - x1;
            this.myPen = myPen;
        }
        public override void Drawing(Bitmap temp)
        {
            Graphics.FromImage(temp).DrawRectangle(myPen, x1, y1, width, height);
        }

    }
}
