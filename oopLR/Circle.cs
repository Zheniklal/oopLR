using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oopLR
{
    public class Circle : Figure
    {
        private float radius;
        private float centerX,centerY;
        public Circle(float x, float y, float radius)
        {
            this.centerX = x;
            this.centerY = y;
            this.radius = radius;
        }
        public override void Drawing(Bitmap temp, Pen myPen)
        {
            Graphics.FromImage(temp).DrawEllipse(myPen, centerX - radius, centerY - radius, radius, radius);
        }
    }
}
