using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace oopLR
{
    public partial class MainForm : Form
    {
        bool isPressed;
        float x1, x2, y1, y2;
        string selectedTool;
        Color foreColor;
        float brushThickness;
        FiguresList figuresList;
        Type currentFigure;

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isPressed)
            {
                x2 = e.X;
                y2 = e.Y;
                pictureBox.Invalidate();
                pictureBox.Update();
            }
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            isPressed = false;
            Figure obj = (Figure)Activator.CreateInstance(currentFigure, new object[] { x1, y1, x2, y2, foreColor, brushThickness });
            figuresList.list.Add(obj);
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        { 
            figuresList.Draw(e);
            if (currentFigure != null)
            {
                try
                {
                    Figure obj = (Figure)Activator.CreateInstance(currentFigure, new object[] { x1, y1, x2, y2, foreColor, brushThickness });

                    obj.Drawing(e);
                    if (selectedTool == "Pencil")
                    {
                        x1 = x2;
                        y1 = y2;
                        figuresList.list.Add(obj);
                    }
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripTextBoxWidth_TextChanged(object sender, EventArgs e)
        {
            try
            {
                brushThickness = Convert.ToInt32(toolStripTextBoxWidth.Text);
            }
            catch
            {
                toolStripTextBoxWidth.Text = "";
                brushThickness = 1;
            }

        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            figuresList.list.Clear();

            Graphics g = pictureBox.CreateGraphics();
            g.Clear(pictureBox.BackColor);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;

                List<Figure> figs = FileManagement.OpenFile(fileName);
                figuresList.list.AddRange(figs);

                pictureBox.Invalidate();
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog1.FileName;
                FileManagement.SaveFile(figuresList.list, fileName);
            }
        }

        private void tool_Click(object sender, EventArgs e)
        {
            Line.Checked = false;
            Rectangle.Checked = false;
            Pencil.Checked = false;
            Ellipse.Checked = false;
            ToolStripButton btnClicked = sender as ToolStripButton;
            btnClicked.Checked = true;
            selectedTool = btnClicked.Name;
        }

            private void ToolStripMenuItemColor_Click(object sender, EventArgs e)
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    foreColor = colorDialog.Color;
                }
            }

            private void PictureBox_MouseDown(object sender, MouseEventArgs e)
            {
                currentFigure = Type.GetType("oopLR." + selectedTool);
                isPressed = true;
                x1 = e.X;
                y1 = e.Y;
            }

            public MainForm()
            {
                InitializeComponent();
                figuresList = new FiguresList();
                foreColor = Color.Black;
                brushThickness = 1;
                Pencil.Checked = true;
                selectedTool = "Pencil";
             //   List<Type> figs = new List<Type>();
             //   figs = CollectionOfFigures.GetClasses<Figure>(Assembly.GetExecutingAssembly());
                currentFigure = Type.GetType("oopLR." + selectedTool);
          
            }

    }   
}


