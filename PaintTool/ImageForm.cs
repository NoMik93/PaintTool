using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace PaintTool
{
    public partial class ImageForm : Form
    {
        public PaintTool parent;

        Image image;
        string path, mode;
        int thick = 1;
        Color color = Color.Black;
        bool fill = false;
        public bool change = false;
        public bool imageLoad = false;
        bool hold;

        private Point start, end;
        Pen pen;
        Brush brush;

        ArrayList save = new ArrayList();

        public class Data
        {
            public Point start, end;
            public Color color;
            public float w, h;
            public bool fill;
            public int thick;
            public string mode;

            public Data(Point start, Point end, Color color, int thick, string mode)
            {
                this.start = start;
                this.end = end;
                this.color = color;
                this.thick = thick;
                this.mode = mode;
            }

            public Data(Point start, Point end, Color color, float w, float h, bool fill, int thick, string mode)
            {
                this.start = start;
                this.end = end;
                this.color = color;
                this.w = w;
                this.h = h;
                this.fill = fill;
                this.thick = thick;
                this.mode = mode;
            }

            public void draw(Graphics g)
            {
                Pen pen = new Pen(color, thick);
                Brush brush = new SolidBrush(color);
                switch (mode)
                {
                    case "pen":
                        pen = new Pen(color);
                        g.DrawLine(pen, start, end);
                        start = end;
                        break;
                    case "bru":
                        pen = new Pen(color, 5);
                        g.DrawLine(pen, start, end);
                        start = end;
                        break;
                    case "lin":
                        g.DrawLine(pen, start, end);
                        break;
                    case "rec":
                        float recx = Math.Min(start.X, end.X);
                        float recy = Math.Min(start.Y, end.Y);
                        float recw = Math.Abs(start.X - end.X);
                        float rech = Math.Abs(start.Y - end.Y);
                        if (fill)
                        {
                            g.FillRectangle(brush, recx, recy, recw, rech);
                        }
                        else
                        {
                            g.DrawRectangle(pen, recx, recy, recw, rech);
                        }
                        break;
                    case "ova":
                        float ovax = Math.Min(start.X, end.X);
                        float ovay = Math.Min(start.Y, end.Y);
                        float ovaw = Math.Abs(start.X - end.X);
                        float ovah = Math.Abs(start.Y - end.Y);
                        if (fill)
                        {
                            g.FillEllipse(brush, ovax, ovay, ovaw, ovah);
                        }
                        else
                        {
                            g.DrawEllipse(pen, ovax, ovay, ovaw, ovah);
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public class DoubleBufferPanel : Panel
        {
            public DoubleBufferPanel()
            {
                this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
                this.UpdateStyles();
            }
        }

        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (change)
            {
                if (MessageBox.Show("저장하시겠습니까?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    saveImage();
            }
            parent.FormClose();
            this.Dispose();
        }

        private void pn_image_Paint(object sender, PaintEventArgs e)
        {
            if (imageLoad)
            {
                Graphics g = e.Graphics;
                g.DrawImage(image, 0, 0);
            }

            foreach (Data data in save)
                data.draw(e.Graphics);
        }

        private void pn_image_MouseDown(object sender, MouseEventArgs e)
        {
            change = true;
            if (e.Button != MouseButtons.Left)
                return;

            start = e.Location;
            hold = true;
        }

        private void pn_image_MouseMove(object sender, MouseEventArgs e)
        {
            if (hold)
            {
                end = e.Location;

                if (start == end)
                    return;

                Graphics g = pn_image.CreateGraphics();

                g = pn_image.CreateGraphics();
                pn_image.Invalidate();
                pn_image.Update();

                switch (mode)
                {
                    case "pen":
                        Data penData = new Data(start, end, color, 1, "lin");
                        save.Add(penData);
                        start = end;
                        break;
                    case "bru":
                        Data bruData = new Data(start, end, color, 5, "lin");
                        save.Add(bruData);
                        start = end;
                        break;
                    case "lin":
                        pen = new Pen(color, thick);
                        g.DrawLine(pen, start, end);
                        break;
                    case "rec":
                        float recx = Math.Min(start.X, end.X);
                        float recy = Math.Min(start.Y, end.Y);
                        float recw = Math.Abs(start.X - end.X);
                        float rech = Math.Abs(start.Y - end.Y);
                        if (fill)
                        {
                            brush = new SolidBrush(color);
                            g.FillRectangle(brush, recx, recy, recw, rech);
                        }
                        else
                        {
                            pen = new Pen(color, thick);
                            g.DrawRectangle(pen, recx, recy, recw, rech);
                        }
                        break;
                    case "ova":
                        float ovax = Math.Min(start.X, end.X);
                        float ovay = Math.Min(start.Y, end.Y);
                        float ovaw = Math.Abs(start.X - end.X);
                        float ovah = Math.Abs(start.Y - end.Y);
                        if (fill)
                        {
                            brush = new SolidBrush(color);
                            g.FillEllipse(brush, ovax, ovay, ovaw, ovah);
                        }
                        else
                        {
                            pen = new Pen(color, thick);
                            g.DrawEllipse(pen, ovax, ovay, ovaw, ovah);
                        }
                        break;
                    default:
                        break;
                }
                g.Dispose();
            }
        }

        private void pn_image_MouseUp(object sender, MouseEventArgs e)
        {
            hold = false;
            end = e.Location;

            Graphics g = pn_image.CreateGraphics();

            switch (mode)
            {
                case "lin":
                    Data linData = new Data(start, end, color, thick, "lin");
                    save.Add(linData);
                    break;
                case "rec":
                    float recw = Math.Abs(start.X - end.X);
                    float rech = Math.Abs(start.Y - end.Y);
                    Data recData = new Data(start, end, color, recw, rech, fill, thick, "rec");
                    save.Add(recData);
                    break;
                case "ova":
                    float ovaw = Math.Abs(start.X - end.X);
                    float ovah = Math.Abs(start.Y - end.Y);
                    Data ovaData = new Data(start, end, color, ovaw, ovah, fill, thick, "ova");
                    save.Add(ovaData);
                    break;
                default:
                    break;
            }
        }

        public void saveImage()
        {
            Bitmap bmp = new Bitmap(pn_image.Width, pn_image.Height);
            pn_image.DrawToBitmap(bmp, new Rectangle(0, 0, pn_image.Width, pn_image.Height));
            if (image != null)
                image.Dispose();
            try
            {
                if (path == null)
                {
                    sfd.ShowDialog();
                    path = sfd.FileName;
                }
                else if (File.Exists(path))
                    File.Delete(path);
                string ext = Path.GetExtension(path);
                System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Jpeg;
                switch (ext)
                {
                    case "jpeg":
                    case "jpg":
                    case "JPEG":
                    case "JPG":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case "bmp":
                    case "BMP":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    case "png":
                    case "PNG":
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                }
                bmp.Save(path, format);
                this.Text = Path.GetFileName(sfd.FileName);
            }
            finally
            {
                bmp.Dispose();
            }
            change = false;
            image = Image.FromFile(path);
            this.Text = Path.GetFileName(path);
        }

        public void clear()
        {
            save.Clear();
            if (imageLoad)
                image.Dispose();
            imageLoad = false;
            this.Refresh();
        }

        public void setImage(Image image)
        {
            this.image = image;
        }

        public void setPath(string path)
        {
            this.path = path;
        }

        public void setMode(string mode)
        {
            this.mode = mode;
        }

        public void setThick(int thick)
        {
            this.thick = thick;
        }

        public void setColor(Color color)
        {
            this.color = color;
        }

        public void setFill(bool fill)
        {
            this.fill = fill;
        }
    }
}
