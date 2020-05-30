using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace oopLR
{
    public static class CollectionOfFigures
    {
        public static List<Type> GetClasses<T>(Assembly asm) where T : class
        {
            List<Type> figs = new List<Type>();
            foreach (Type type in asm.GetTypes().Where(myType=>myType.IsClass && myType.IsSubclassOf(typeof(T))))
            {
                figs.Add(type);
            }

            return figs;
        }
    }
}
