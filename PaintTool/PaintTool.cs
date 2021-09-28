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

namespace PaintTool
{
    public partial class PaintTool : Form
    {
        int imageForm_num = 0;

        public PaintTool()
        {
            InitializeComponent();
        }

        public void FormClose()
        {
            imageForm_num--;
            if(imageForm_num == 0)
            {
                this.저장SToolStripMenuItem.Enabled = false;
                this.이미지지우기NToolStripMenuItem.Enabled = false;
            }
        }

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImageForm imageForm = new ImageForm();
            imageForm.parent = this;
            imageForm.WindowState = FormWindowState.Maximized;
            imageForm.TopLevel = false;
            imageForm.MdiParent = this;
            imageForm.Show();

            imageForm_num++;
            this.저장SToolStripMenuItem.Enabled = true;
            this.이미지지우기NToolStripMenuItem.Enabled = true;
        }

        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(ofd.FileName);

                ImageForm imageForm = new ImageForm();
                imageForm.parent = this;
                imageForm.setImage(image);
                imageForm.setPath(ofd.FileName);
                imageForm.Size = new Size(image.Width + 16, image.Height + 39);
                imageForm.Location = new Point(32, 24);
                imageForm.Text = Path.GetFileName(ofd.FileName);
                imageForm.TopLevel = false;
                imageForm.MdiParent = this;
                imageForm.imageLoad = true;
                imageForm.Show();

                imageForm_num++;
                this.저장SToolStripMenuItem.Enabled = true;
                this.이미지지우기NToolStripMenuItem.Enabled = true;
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).saveImage();
        }

        private void 끝내기XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).saveImage();
            this.Close();
        }

        private void 이미지지우기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                ((ImageForm)this.MdiChildren[i]).clear();
                ((ImageForm)this.MdiChildren[i]).change = true;
            }
        }

        private void tsb_Color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            tsb_Color.BackColor = cd.Color;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setColor(cd.Color);
        }

        private void tsb_Pensil_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setMode("pen");
            resetBackColor();
            tsb_Pensil.BackColor = Color.Gray;
        }

        private void tsb_Brush_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setMode("bru");
            resetBackColor();
            tsb_Brush.BackColor = Color.Gray;
        }

        private void tsb_Line_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setMode("lin");
            resetBackColor();
            tsb_Line.BackColor = Color.Gray;
        }

        private void tsb_Rect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setMode("rec");
            resetBackColor();
            tsb_Rect.BackColor = Color.Gray;
        }

        private void tsb_Oval_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setMode("ova");
            resetBackColor();
            tsb_Oval.BackColor = Color.Gray;
        }

        private void resetBackColor()
        {
            tsb_Pensil.BackColor = Color.DarkGray;
            tsb_Brush.BackColor = Color.DarkGray;
            tsb_Line.BackColor = Color.DarkGray;
            tsb_Rect.BackColor = Color.DarkGray;
            tsb_Oval.BackColor = Color.DarkGray;
        }

        private void tsmi_1_Click(object sender, EventArgs e)
        {
            tsmi_1.Checked = true;
            tsmi_2.Checked = false;
            tsmi_3.Checked = false;
            tsmi_4.Checked = false;
            tsmi_5.Checked = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setThick(1);
        }

        private void tsmi_2_Click(object sender, EventArgs e)
        {
            tsmi_1.Checked = false;
            tsmi_2.Checked = true;
            tsmi_3.Checked = false;
            tsmi_4.Checked = false;
            tsmi_5.Checked = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setThick(2);
        }

        private void tsmi_3_Click(object sender, EventArgs e)
        {
            tsmi_1.Checked = false;
            tsmi_2.Checked = false;
            tsmi_3.Checked = true;
            tsmi_4.Checked = false;
            tsmi_5.Checked = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setThick(3);
        }

        private void tsmi_4_Click(object sender, EventArgs e)
        {
            tsmi_1.Checked = false;
            tsmi_2.Checked = false;
            tsmi_3.Checked = false;
            tsmi_4.Checked = true;
            tsmi_5.Checked = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setThick(4);
        }

        private void tsmi_5_Click(object sender, EventArgs e)
        {
            tsmi_1.Checked = false;
            tsmi_2.Checked = false;
            tsmi_3.Checked = false;
            tsmi_4.Checked = false;
            tsmi_5.Checked = true;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setThick(5);
        }

        private void 채우기없음ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            채우기없음ToolStripMenuItem.Checked = true;
            단색ToolStripMenuItem.Checked = false;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setFill(false);
        }

        private void 단색ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            채우기없음ToolStripMenuItem.Checked = false;
            단색ToolStripMenuItem.Checked = true;
            for (int i = 0; i < this.MdiChildren.Length; i++)
                ((ImageForm)this.MdiChildren[i]).setFill(true);
        }
    }
}
