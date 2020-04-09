using System;
using System.Drawing;
using System.Windows.Forms;

namespace oopLR
{
    public partial class MainForm : Form
    {
        bool isPressed;
        int x1, x2, y1, y2;
        Bitmap snapshot, tempDraw;
        string selectedTool;
        Color foreColor;
        int brushThickness;
        FiguresList figuresList;

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
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
            snapshot = (Bitmap)tempDraw.Clone();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (selectedTool != "Pencil") tempDraw = (Bitmap)snapshot.Clone();
            Graphics g = Graphics.FromImage(tempDraw);
            Pen myPen = new Pen(foreColor, brushThickness);
            switch (selectedTool)
            {
                case "Line":
                    if (tempDraw != null)
                    {
                        Line l = new Line(x1, y1, x2, y2);
                        l.Drawing(tempDraw, myPen);
                        figuresList.list.Add(l);
                    }   
                    break;

                case "Rectangle":
                    if (tempDraw != null)
                    {
                        Rectangle rec = new Rectangle(x1, y1, x2, y2);
                        rec.Drawing(tempDraw, myPen);
                        figuresList.list.Add(rec);
                    }  
                    break;

                case "Pencil":
                    if (tempDraw != null)
                    {
                        Pencil p = new Pencil(x1, y1, x2, y2);
                        p.Drawing(tempDraw, myPen);
                        figuresList.list.Add(p);
                        x1 = x2;
                        y1 = y2;
                    }
                    break;

                case "Ellipse":
                    if (tempDraw != null)
                    {
                        Ellipse el = new Ellipse(x1, y1, x2, y2);
                        el.Drawing(tempDraw, myPen);
                        figuresList.list.Add(el);
                    }
                    break;

                case "Circle":
                    if (tempDraw != null)
                    {
                        Circle c = new Circle(x1, y1, x1 - x2);
                        c.Drawing(tempDraw, myPen);
                        figuresList.list.Add(c);
                    }
                    break;

                case "returnAll":
                    figuresList.Draw(tempDraw, myPen);
                    break;

                default:    break;
            }
            myPen.Dispose();
            e.Graphics.DrawImageUnscaled(tempDraw, 0, 0);
            g.Dispose();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox.CreateGraphics();
            g.Clear(pictureBox.BackColor);

            snapshot.Dispose();
            snapshot = null;
            tempDraw.Dispose();
            tempDraw = null;

            snapshot = new Bitmap(pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Height);
            tempDraw = (Bitmap)snapshot.Clone();
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

        private void tool_Click(object sender, EventArgs e)
        {
            Line.Checked = false;
            Rectangle.Checked = false;
            Pencil.Checked = false;
            Circle.Checked = false;
            Ellipse.Checked = false;
            returnAll.Checked = false;
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
            isPressed = true;
            x1 = e.X;
            y1 = e.Y;
            tempDraw = (Bitmap)snapshot.Clone();
        }

        public MainForm()
        {
            InitializeComponent();
            figuresList = new FiguresList();
            snapshot = new Bitmap(pictureBox.ClientRectangle.Width, pictureBox.ClientRectangle.Height);
            tempDraw = (Bitmap)snapshot.Clone();
            foreColor = Color.Black;
            brushThickness = 1;
            Pencil.Checked = true;
            selectedTool = "Pencil";
        }

    }
}

