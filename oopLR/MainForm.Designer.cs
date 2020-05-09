namespace oopLR
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.Pencil = new System.Windows.Forms.ToolStripButton();
            this.Line = new System.Windows.Forms.ToolStripButton();
            this.Rectangle = new System.Windows.Forms.ToolStripButton();
            this.Ellipse = new System.Windows.Forms.ToolStripButton();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemColor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemWidth = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxWidth = new System.Windows.Forms.ToolStripTextBox();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearTheListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1219, 628);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseUp);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Pencil,
            this.Line,
            this.Rectangle,
            this.Ellipse});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1219, 31);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip";
            // 
            // Pencil
            // 
            this.Pencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pencil.Image = global::oopLR.Properties.Resources.pencil;
            this.Pencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(29, 24);
            this.Pencil.Text = "Pencil";
            this.Pencil.Click += new System.EventHandler(this.tool_Click);
            // 
            // Line
            // 
            this.Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Line.Image = global::oopLR.Properties.Resources.w128h1281390849416line128;
            this.Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(29, 24);
            this.Line.Text = "Line";
            this.Line.Click += new System.EventHandler(this.tool_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Rectangle.Image = global::oopLR.Properties.Resources.Без_названия;
            this.Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(29, 24);
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.Click += new System.EventHandler(this.tool_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Ellipse.Image = global::oopLR.Properties.Resources._33822;
            this.Ellipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(29, 24);
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.Click += new System.EventHandler(this.tool_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolStripMenuItemColor,
            this.ToolStripMenuItemWidth,
            this.clearToolStripMenuItem,
            this.ClearTheListToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1219, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemColor
            // 
            this.toolStripMenuItemColor.Name = "toolStripMenuItemColor";
            this.toolStripMenuItemColor.Size = new System.Drawing.Size(59, 24);
            this.toolStripMenuItemColor.Text = "Color";
            this.toolStripMenuItemColor.Click += new System.EventHandler(this.ToolStripMenuItemColor_Click);
            // 
            // ToolStripMenuItemWidth
            // 
            this.ToolStripMenuItemWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxWidth});
            this.ToolStripMenuItemWidth.Name = "ToolStripMenuItemWidth";
            this.ToolStripMenuItemWidth.Size = new System.Drawing.Size(63, 24);
            this.ToolStripMenuItemWidth.Text = "Width";
            // 
            // toolStripTextBoxWidth
            // 
            this.toolStripTextBoxWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBoxWidth.Name = "toolStripTextBoxWidth";
            this.toolStripTextBoxWidth.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBoxWidth.Text = "1";
            this.toolStripTextBoxWidth.TextChanged += new System.EventHandler(this.ToolStripTextBoxWidth_TextChanged);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // ClearTheListToolStripMenuItem
            // 
            this.ClearTheListToolStripMenuItem.Name = "ClearTheListToolStripMenuItem";
            this.ClearTheListToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.ClearTheListToolStripMenuItem.Text = "Clear The List";
            this.ClearTheListToolStripMenuItem.Click += new System.EventHandler(this.DeleteTheListToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "dat";
            this.openFileDialog1.Filter = "DAT Files (*.dat)|*.dat";
            this.openFileDialog1.FilterIndex = 0;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "dat";
            this.saveFileDialog1.Filter = "DAT Files (*.dat)|*.dat";
            this.saveFileDialog1.FilterIndex = 0;
            this.saveFileDialog1.Title = "Save picture as...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 628);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Рисовальник";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton Pencil;
        private System.Windows.Forms.ToolStripButton Line;
        private System.Windows.Forms.ToolStripButton Rectangle;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemWidth;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton Ellipse;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxWidth;
        private System.Windows.Forms.ToolStripMenuItem ClearTheListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

