using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Reflection;

namespace oopLR
{
    public static class FileManagement
    {
        public static List<Figure> OpenFile(string fileName)
        {
            List<Figure> figs = new List<Figure>();
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
              //  figs = (List<Figure>)bf.Deserialize(fs);
                figs = (List<Figure>)bf.Deserialize(fs);
            }

            //MessageBox.Show("File uploaded.");

            return figs;

        }

        public static void SaveFile(List<Figure> list, string fileName)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();

                using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    bf.Serialize(fs, list);
                    
                }
                MessageBox.Show("File saved");
            }
            catch
            {
                MessageBox.Show("Error");
            }
            

            
        }
    }
}
