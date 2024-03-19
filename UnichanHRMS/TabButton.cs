using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnichanHRMS.CustomControls
{
    public partial class TabButton : Button
    {
        public ToolTip toolTip = new ToolTip();

        //Fields
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.PaleGoldenrod;
        private Image image = Properties.Resources.people;
        private Size imageSize = new Size(50, 50);

        [Category("Custom")]
        public int BorderRadius { get => borderRadius; set => borderRadius = value; }
        [Category("Custom")]
        public Size ImageSize { get => imageSize; set => imageSize = value; }
        [Category("Custom")]
        public int BorderSize { get => borderSize; set => borderSize = value; }
        [Category("Custom")]
        public Color BorderColor { get => borderColor; set => borderColor = value; }

        public TabButton()
        {
            InitializeComponent();
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rectangle, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            path.AddLine(new PointF(rectangle.Width,0), new PointF(rectangle.Width, radius));
            path.AddLine(new PointF(rectangle.Width, radius), new PointF(rectangle.Width-radius, rectangle.Height));
            path.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            RectangleF rectangleF = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            int smoothSize = 2;
            if (BorderSize > 0)
                smoothSize = BorderSize;
            if (BorderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectangleF, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectangleBorder, BorderRadius - BorderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(BorderColor, BorderSize))
                {
                    pe.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pe.Graphics.DrawPath(penSurface, pathSurface);
                    //Button border                    
                    if (BorderSize >= 1)
                        //Draw control border
                        pe.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pe.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectangleF);
                //Button border
                if (BorderSize >= 1)
                {
                    using (Pen penBorder = new Pen(BorderColor, BorderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pe.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }


        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void RoundedButton_Resize(object sender, EventArgs e)
        {
           
        }

        private void TabButton_Resize(object sender, EventArgs e)
        {
            if (this.Image == null)
                return;
            var pic = new Bitmap(this.Image, imageSize);
            this.Image = pic;
        }
    }
}
