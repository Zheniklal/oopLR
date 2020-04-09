﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace oopLR
{
    public class FiguresList
    {
        public List<Figure> list;
        public FiguresList()
        {
            list = new List<Figure>();
        }
        public int Draw(Bitmap temp, Pen myPen)
        {
            if (list.Count == -1)
                return 0;
            else
            {
                for (int i = 0; i < list.Count; i++)
                    list[i].Drawing(temp, myPen);
                return 1;
            }
        }
    }
}
