using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oopLR
{
    public abstract class Figure
    {
        public Color col;
        public int brushThickness;
        public abstract void Drawing(Bitmap temp, Pen myPen);
    }
}
