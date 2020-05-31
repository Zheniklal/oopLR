using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace FigureLibrary
{
    [Serializable]
    public abstract class Figure
    {
        public Color col;
        public float thickness;
        public abstract void Drawing(PaintEventArgs e);
    }
}
