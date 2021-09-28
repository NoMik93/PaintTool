namespace PaintTool
{
    partial class PaintTool
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintTool));
            this.ms = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지지우기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsb_Color = new System.Windows.Forms.ToolStripButton();
            this.tsb_Pensil = new System.Windows.Forms.ToolStripButton();
            this.tsb_Brush = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_Line = new System.Windows.Forms.ToolStripButton();
            this.tsb_Rect = new System.Windows.Forms.ToolStripButton();
            this.tsb_Oval = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsb_LineWid = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmi_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_5 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsb_Fill = new System.Windows.Forms.ToolStripDropDownButton();
            this.채우기없음ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.단색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.cd = new System.Windows.Forms.ColorDialog();
            this.ms.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.이미지IToolStripMenuItem});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(800, 24);
            this.ms.TabIndex = 0;
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.toolStripMenuItem1,
            this.끝내기XToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일ToolStripMenuItem.Text = "파일(&F)";
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(&N)";
            this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.열기OToolStripMenuItem.Text = "열기(&O)";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Enabled = false;
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.저장SToolStripMenuItem.Text = "저장(&S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
            // 
            // 끝내기XToolStripMenuItem
            // 
            this.끝내기XToolStripMenuItem.Name = "끝내기XToolStripMenuItem";
            this.끝내기XToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.끝내기XToolStripMenuItem.Text = "끝내기(&X)";
            this.끝내기XToolStripMenuItem.Click += new System.EventHandler(this.끝내기XToolStripMenuItem_Click);
            // 
            // 이미지IToolStripMenuItem
            // 
            this.이미지IToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.이미지지우기NToolStripMenuItem});
            this.이미지IToolStripMenuItem.Name = "이미지IToolStripMenuItem";
            this.이미지IToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.이미지IToolStripMenuItem.Text = "이미지(&I)";
            // 
            // 이미지지우기NToolStripMenuItem
            // 
            this.이미지지우기NToolStripMenuItem.Enabled = false;
            this.이미지지우기NToolStripMenuItem.Name = "이미지지우기NToolStripMenuItem";
            this.이미지지우기NToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.이미지지우기NToolStripMenuItem.Text = "이미지 지우기(&N)";
            this.이미지지우기NToolStripMenuItem.Click += new System.EventHandler(this.이미지지우기NToolStripMenuItem_Click);
            // 
            // ts
            // 
            this.ts.Dock = System.Windows.Forms.DockStyle.Left;
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Color,
            this.tsb_Pensil,
            this.tsb_Brush,
            this.toolStripSeparator1,
            this.tsb_Line,
            this.tsb_Rect,
            this.tsb_Oval,
            this.toolStripSeparator2,
            this.tsb_LineWid,
            this.tsb_Fill});
            this.ts.Location = new System.Drawing.Point(0, 24);
            this.ts.Name = "ts";
            this.ts.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ts.Size = new System.Drawing.Size(30, 426);
            this.ts.TabIndex = 1;
            // 
            // tsb_Color
            // 
            this.tsb_Color.AutoSize = false;
            this.tsb_Color.BackColor = System.Drawing.Color.Black;
            this.tsb_Color.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tsb_Color.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Color.Name = "tsb_Color";
            this.tsb_Color.Size = new System.Drawing.Size(29, 29);
            this.tsb_Color.ToolTipText = "색";
            this.tsb_Color.Click += new System.EventHandler(this.tsb_Color_Click);
            // 
            // tsb_Pensil
            // 
            this.tsb_Pensil.AutoSize = false;
            this.tsb_Pensil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Pensil.Image = global::PaintTool.Properties.Resources.pencil_48;
            this.tsb_Pensil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Pensil.Name = "tsb_Pensil";
            this.tsb_Pensil.Size = new System.Drawing.Size(29, 29);
            this.tsb_Pensil.ToolTipText = "연필";
            this.tsb_Pensil.Click += new System.EventHandler(this.tsb_Pensil_Click);
            // 
            // tsb_Brush
            // 
            this.tsb_Brush.AutoSize = false;
            this.tsb_Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Brush.Image = global::PaintTool.Properties.Resources.brush_48;
            this.tsb_Brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Brush.Name = "tsb_Brush";
            this.tsb_Brush.Size = new System.Drawing.Size(29, 29);
            this.tsb_Brush.ToolTipText = "브러쉬";
            this.tsb_Brush.Click += new System.EventHandler(this.tsb_Brush_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // tsb_Line
            // 
            this.tsb_Line.AutoSize = false;
            this.tsb_Line.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Line.Image = global::PaintTool.Properties.Resources.line_48;
            this.tsb_Line.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Line.Name = "tsb_Line";
            this.tsb_Line.Size = new System.Drawing.Size(29, 29);
            this.tsb_Line.ToolTipText = "선";
            this.tsb_Line.Click += new System.EventHandler(this.tsb_Line_Click);
            // 
            // tsb_Rect
            // 
            this.tsb_Rect.AutoSize = false;
            this.tsb_Rect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Rect.Image = global::PaintTool.Properties.Resources.rectangular_48;
            this.tsb_Rect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Rect.Name = "tsb_Rect";
            this.tsb_Rect.Size = new System.Drawing.Size(29, 29);
            this.tsb_Rect.ToolTipText = "사각형";
            this.tsb_Rect.Click += new System.EventHandler(this.tsb_Rect_Click);
            // 
            // tsb_Oval
            // 
            this.tsb_Oval.AutoSize = false;
            this.tsb_Oval.BackColor = System.Drawing.Color.DarkGray;
            this.tsb_Oval.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Oval.Image = global::PaintTool.Properties.Resources.oval_48;
            this.tsb_Oval.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Oval.Name = "tsb_Oval";
            this.tsb_Oval.Size = new System.Drawing.Size(29, 29);
            this.tsb_Oval.ToolTipText = "타원";
            this.tsb_Oval.Click += new System.EventHandler(this.tsb_Oval_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(27, 6);
            // 
            // tsb_LineWid
            // 
            this.tsb_LineWid.AutoSize = false;
            this.tsb_LineWid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_LineWid.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_1,
            this.tsmi_2,
            this.tsmi_3,
            this.tsmi_4,
            this.tsmi_5});
            this.tsb_LineWid.Image = global::PaintTool.Properties.Resources.line_width_48;
            this.tsb_LineWid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_LineWid.Name = "tsb_LineWid";
            this.tsb_LineWid.Size = new System.Drawing.Size(29, 29);
            this.tsb_LineWid.ToolTipText = "선 굵기";
            // 
            // tsmi_1
            // 
            this.tsmi_1.Checked = true;
            this.tsmi_1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmi_1.Name = "tsmi_1";
            this.tsmi_1.Size = new System.Drawing.Size(81, 22);
            this.tsmi_1.Text = "1";
            this.tsmi_1.Click += new System.EventHandler(this.tsmi_1_Click);
            // 
            // tsmi_2
            // 
            this.tsmi_2.Name = "tsmi_2";
            this.tsmi_2.Size = new System.Drawing.Size(81, 22);
            this.tsmi_2.Text = "2";
            this.tsmi_2.Click += new System.EventHandler(this.tsmi_2_Click);
            // 
            // tsmi_3
            // 
            this.tsmi_3.Name = "tsmi_3";
            this.tsmi_3.Size = new System.Drawing.Size(81, 22);
            this.tsmi_3.Text = "3";
            this.tsmi_3.Click += new System.EventHandler(this.tsmi_3_Click);
            // 
            // tsmi_4
            // 
            this.tsmi_4.Name = "tsmi_4";
            this.tsmi_4.Size = new System.Drawing.Size(81, 22);
            this.tsmi_4.Text = "4";
            this.tsmi_4.Click += new System.EventHandler(this.tsmi_4_Click);
            // 
            // tsmi_5
            // 
            this.tsmi_5.Name = "tsmi_5";
            this.tsmi_5.Size = new System.Drawing.Size(81, 22);
            this.tsmi_5.Text = "5";
            this.tsmi_5.Click += new System.EventHandler(this.tsmi_5_Click);
            // 
            // tsb_Fill
            // 
            this.tsb_Fill.AutoSize = false;
            this.tsb_Fill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsb_Fill.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.채우기없음ToolStripMenuItem,
            this.단색ToolStripMenuItem});
            this.tsb_Fill.Image = global::PaintTool.Properties.Resources.rectangle_48;
            this.tsb_Fill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Fill.Name = "tsb_Fill";
            this.tsb_Fill.Size = new System.Drawing.Size(29, 29);
            this.tsb_Fill.ToolTipText = "채우기";
            // 
            // 채우기없음ToolStripMenuItem
            // 
            this.채우기없음ToolStripMenuItem.Checked = true;
            this.채우기없음ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.채우기없음ToolStripMenuItem.Name = "채우기없음ToolStripMenuItem";
            this.채우기없음ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.채우기없음ToolStripMenuItem.Text = "채우기 없음";
            this.채우기없음ToolStripMenuItem.Click += new System.EventHandler(this.채우기없음ToolStripMenuItem_Click);
            // 
            // 단색ToolStripMenuItem
            // 
            this.단색ToolStripMenuItem.Name = "단색ToolStripMenuItem";
            this.단색ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.단색ToolStripMenuItem.Text = "단색";
            this.단색ToolStripMenuItem.Click += new System.EventHandler(this.단색ToolStripMenuItem_Click);
            // 
            // ofd
            // 
            this.ofd.Filter = "JPEG(*jpeg)|*.jpeg|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp|PNG(*.png)|*.png";
            // 
            // PaintTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms;
            this.Name = "PaintTool";
            this.Text = "그림판";
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 끝내기XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지지우기NToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsb_Color;
        private System.Windows.Forms.ToolStripButton tsb_Pensil;
        private System.Windows.Forms.ToolStripButton tsb_Brush;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsb_Line;
        private System.Windows.Forms.ToolStripButton tsb_Rect;
        private System.Windows.Forms.ToolStripButton tsb_Oval;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.ColorDialog cd;
        private System.Windows.Forms.ToolStripDropDownButton tsb_LineWid;
        private System.Windows.Forms.ToolStripMenuItem tsmi_1;
        private System.Windows.Forms.ToolStripMenuItem tsmi_2;
        private System.Windows.Forms.ToolStripMenuItem tsmi_3;
        private System.Windows.Forms.ToolStripMenuItem tsmi_4;
        private System.Windows.Forms.ToolStripMenuItem tsmi_5;
        private System.Windows.Forms.ToolStripDropDownButton tsb_Fill;
        private System.Windows.Forms.ToolStripMenuItem 채우기없음ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 단색ToolStripMenuItem;
    }
}

