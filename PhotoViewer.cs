using CefSharp.WinForms;
using DeafDumb.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeafDumb
{
	public class PhotoViewer : Form
	{
		private string place = "";

		private IContainer components = null;
        private Panel panel1;
        private Button button1;
        private ChromiumWebBrowser chromiumWebBrowser1;
        private PictureBox cmdClose;

		public PhotoViewer(string fname)
		{
			this.InitializeComponent();
			this.place = fname;
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.cmdClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.Image = global::DeafDumb.Properties.Resources.close_button_md;
            this.cmdClose.Location = new System.Drawing.Point(1256, -97);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(67, 65);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 54;
            this.cmdClose.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(10, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1545, 53);
            this.panel1.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(574, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(21, 61);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(301, 100);
            this.chromiumWebBrowser1.TabIndex = 57;
            // 
            // PhotoViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1567, 883);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhotoViewer";
            this.Text = "Webview";
            this.Load += new System.EventHandler(this.PhotoViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private void PhotoViewer_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
            this.chromiumWebBrowser1.Width = base.Width - 40;
            this.chromiumWebBrowser1.Height = base.Height - 40;
            object[] startupPath = new object[] { Application.StartupPath, "\\", this.place, "\\", 1, ".png" };

            // webBrowser1.Url = new Uri(place);
            chromiumWebBrowser1.Load(place);
            

			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            FrmWall frmWall = new FrmWall();
            frmWall.Show();
        }
    }
}