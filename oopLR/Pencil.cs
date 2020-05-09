using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopLR
{
    [Serializable]
    class Pencil : Figure
    {
        private float x1, x2, y1, y2;
        public Pencil(float x1, float y1, float x2, float y2, Pen myPen)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
            this.myPen = myPen;
        }
        public override void Drawing(Bitmap temp)
        {
           // try {
               // Graphics g = Graphics.FromImage(temp);
               // g.DrawLine(myPen, x1, y1, x2, y2);
               if (this.myPen != null)
               Graphics.FromImage(temp).DrawLine(this.myPen, x1, y1, x2, y2);
            //}
           // catch {  }
            
        }
    }
}
