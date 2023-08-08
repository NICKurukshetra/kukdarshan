using DeafDumb.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DeafDumb
{
	public class alertwindow : Form
	{
		private IContainer components = null;

		private PictureBox pictureBox1;

		private PictureBox pictureBox2;

		private Timer timer1;

		public string a;

		public alertwindow(string s)
		{
			this.InitializeComponent();
			this.a = s;
		}

		private void alertwindow_Load(object sender, EventArgs e)
		{
			this.timer1.Enabled = true;
			if (!(this.a == "1"))
			{
				this.pictureBox2.Visible = true;
			}
			else
			{
				this.pictureBox1.Visible = true;
			}
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.timer1 = new Timer(this.components);
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.pictureBox2.Image = Resources.down;
			this.pictureBox2.Location = new Point(-1, -4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(372, 321);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Visible = false;
			this.pictureBox1.Image = Resources.up;
			this.pictureBox1.Location = new Point(-1, -4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(370, 320);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Visible = false;
			this.timer1.Interval = 2000;
			this.timer1.Tick += new EventHandler(this.timer1_Tick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(363, 313);
			base.ControlBox = false;
			base.Controls.Add(this.pictureBox2);
			base.Controls.Add(this.pictureBox1);
			base.Name = "alertwindow";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = FormStartPosition.CenterScreen;
			base.Load += new EventHandler(this.alertwindow_Load);
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}