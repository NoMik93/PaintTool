namespace PaintTool
{
    partial class ImageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageForm));
            this.pn_image = new DoubleBufferPanel();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // pn_image
            // 
            this.pn_image.BackColor = System.Drawing.Color.White;
            this.pn_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_image.Location = new System.Drawing.Point(0, 0);
            this.pn_image.Name = "pn_image";
            this.pn_image.Size = new System.Drawing.Size(800, 450);
            this.pn_image.TabIndex = 0;
            this.pn_image.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_image_Paint);
            this.pn_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_image_MouseDown);
            this.pn_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_image_MouseMove);
            this.pn_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_image_MouseUp);
            // 
            // sfd
            // 
            this.sfd.Filter = "JPEG(*jpeg)|*.jpeg|JPG(*.jpg)|*.jpg|BMP(*.bmp)|*.bmp|PNG(*.png)|*.png";
            // 
            // ImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_image);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ImageForm";
            this.Text = "제목 없음";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ImageForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog sfd;
        private DoubleBufferPanel pn_image;
    }
}