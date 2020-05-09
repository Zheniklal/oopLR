using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oopLR
{
    [Serializable]
    public class Ellipse : Figure
    {
        private float x, y;
        private float centerX,centerY;
        public Ellipse(float x, float y, float x1, float y1, Pen myPen)
        {
            this.x = x;
            this.y = y;
            this.centerX = x1;
            this.centerY = y1;
            this.myPen = myPen;
        }
        public override void Drawing(Bitmap temp)
        {
            if (myPen != null)
                Graphics.FromImage(temp).DrawEllipse(myPen, x, y, centerX - x, centerY - y);
        }
    }
}
