using AxWMPLib;
using DeafDumb.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace DeafDumb
{
	public class Form1 : Form
	{
		private IContainer components = null;

		private AxWindowsMediaPlayer axWindowsMediaPlayer2;

		private Panel panel1;

		private PictureBox cmdClose;

		private PictureBox pictureBox1;

		private PictureBox pictureBox4;

		private PictureBox pictureBox3;

		private PictureBox pictureBox2;

		private WebBrowser webBrowser1;

		private Label label1;

		private PictureBox PhotoViewer;

		private ComboBox comboBox1;

		private PictureBox btnNext;

		private PictureBox btnPrev;

		private OleDbConnection con = new OleDbConnection();

		private Random r = new Random();

		public static int qid;

		private string fname = "";

		private string fid = "";

		public Form1(string str)
		{
			this.InitializeComponent();
			this.fid = str;
			this.fname = str;
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			string[] startupPath;
			if (this.comboBox1.SelectedIndex >= this.comboBox1.Items.Count - 1)
			{
				this.comboBox1.SelectedIndex = 0;
				PictureBox photoViewer = this.PhotoViewer;
				startupPath = new string[] { Application.StartupPath, "\\photo\\", this.fname, "\\", this.comboBox1.SelectedItem.ToString() };
				photoViewer.ImageLocation = string.Concat(startupPath);
			}
			else
			{
				this.comboBox1.SelectedIndex = this.comboBox1.SelectedIndex + 1;
				PictureBox pictureBox = this.PhotoViewer;
				startupPath = new string[] { Application.StartupPath, "\\photo\\", this.fname, "\\", this.comboBox1.SelectedItem.ToString() };
				pictureBox.ImageLocation = string.Concat(startupPath);
			}
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			string[] startupPath;
			if (this.comboBox1.SelectedIndex < 1)
			{
				this.comboBox1.SelectedIndex = this.comboBox1.Items.Count - 1;
				PictureBox photoViewer = this.PhotoViewer;
				startupPath = new string[] { Application.StartupPath, "\\photo\\", this.fname, "\\", this.comboBox1.SelectedItem.ToString() };
				photoViewer.ImageLocation = string.Concat(startupPath);
			}
			else
			{
				this.comboBox1.SelectedIndex = this.comboBox1.SelectedIndex - 1;
				PictureBox pictureBox = this.PhotoViewer;
				startupPath = new string[] { Application.StartupPath, "\\photo\\", this.fname, "\\", this.comboBox1.SelectedItem.ToString() };
				pictureBox.ImageLocation = string.Concat(startupPath);
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

		private void Form1_Load(object sender, EventArgs e)
		{
			this.con.ConnectionString = string.Concat("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=", Application.StartupPath, "\\kkr.mdb;Persist Security Info=True");
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(string.Concat("select * from butmaster where butid=", this.fname), this.con);
			DataSet dataSet = new DataSet();
			oleDbDataAdapter.Fill(dataSet);
			if (dataSet.Tables[0].Rows.Count >= 1)
			{
				this.fname = dataSet.Tables[0].Rows[0]["buttondesc"].ToString();
			}
			dataSet.Dispose();
			oleDbDataAdapter.Dispose();
			base.WindowState = FormWindowState.Maximized;
			this.panel1.Width = base.Width - 40;
			this.panel1.Height = base.Height - 50;
			this.cmdClose.Left = base.Width - 80;
			this.cmdClose.Top = 10;
			this.label1.Text = this.fname.ToUpper();
			if (!File.Exists(string.Concat(Application.StartupPath, "\\pdf\\", this.fid, ".pdf")))
			{
				this.pictureBox1.Visible = false;
			}
			else
			{
				this.pictureBox1.Visible = true;
			}
			if (!Directory.Exists(string.Concat(Application.StartupPath, "\\photo\\", this.fname)))
			{
				this.pictureBox2.Visible = false;
			}
			else
			{
				this.pictureBox2.Visible = true;
			}
			if (!File.Exists(string.Concat(Application.StartupPath, "\\VIDEOS\\", this.fid, ".avi")))
			{
				this.pictureBox3.Visible = false;
			}
			else
			{
				this.pictureBox3.Visible = true;
			}
			if (!File.Exists(string.Concat(Application.StartupPath, "\\MAPS\\", this.fid, ".jpg")))
			{
				this.pictureBox4.Visible = false;
			}
			else
			{
				this.pictureBox4.Visible = true;
			}
			this.pictureBox1.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/Know About it.png");
			this.pictureBox2.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/photo Gallery.png");
			this.pictureBox3.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/Video Gallery.png");
			this.pictureBox4.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/Route Map.png");
			this.btnNext.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/next.png");
			this.btnPrev.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/prev.png");
			this.webBrowser1.Navigate(new Uri(string.Concat(Application.StartupPath, "\\pdf\\", this.fid, ".pdf")));
		}

		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
			this.panel1 = new Panel();
			this.comboBox1 = new ComboBox();
			this.webBrowser1 = new WebBrowser();
			this.axWindowsMediaPlayer2 = new AxWindowsMediaPlayer();
			this.label1 = new Label();
			this.cmdClose = new PictureBox();
			this.btnNext = new PictureBox();
			this.btnPrev = new PictureBox();
			this.pictureBox4 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.PhotoViewer = new PictureBox();
			this.panel1.SuspendLayout();
			this.axWindowsMediaPlayer2.BeginInit();
			((ISupportInitialize)this.cmdClose).BeginInit();
			((ISupportInitialize)this.btnNext).BeginInit();
			((ISupportInitialize)this.btnPrev).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.PhotoViewer).BeginInit();
			base.SuspendLayout();
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Controls.Add(this.btnPrev);
			this.panel1.Controls.Add(this.comboBox1);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.PhotoViewer);
			this.panel1.Controls.Add(this.webBrowser1);
			this.panel1.Controls.Add(this.axWindowsMediaPlayer2);
			this.panel1.Location = new Point(12, 36);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1358, 736);
			this.panel1.TabIndex = 41;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new Point(68, 17);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 71;
			this.comboBox1.Visible = false;
			this.webBrowser1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.webBrowser1.Location = new Point(347, 17);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(917, 647);
			this.webBrowser1.TabIndex = 69;
			this.axWindowsMediaPlayer2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.axWindowsMediaPlayer2.Enabled = true;
			this.axWindowsMediaPlayer2.Location = new Point(347, 17);
			this.axWindowsMediaPlayer2.Name = "axWindowsMediaPlayer2";

			this.axWindowsMediaPlayer2.Size = new System.Drawing.Size(898, 647);
			this.axWindowsMediaPlayer2.TabIndex = 35;
			this.axWindowsMediaPlayer2.Visible = false;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Red;
			this.label1.Location = new Point(354, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(396, 33);
			this.label1.TabIndex = 53;
			this.label1.Text = "KURUKSHETRA DARSHAN";
			this.cmdClose.Cursor = Cursors.Hand;
			this.cmdClose.Image = Resources.close_button_md;
			this.cmdClose.Location = new Point(1303, 12);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(67, 65);
			this.cmdClose.SizeMode = PictureBoxSizeMode.StretchImage;
			this.cmdClose.TabIndex = 52;
			this.cmdClose.TabStop = false;
			this.cmdClose.Click += new EventHandler(this.pictureBox6_Click_1);
			this.btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.btnNext.Cursor = Cursors.Hand;
			this.btnNext.Location = new Point(783, 662);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(83, 57);
			this.btnNext.SizeMode = PictureBoxSizeMode.StretchImage;
			this.btnNext.TabIndex = 73;
			this.btnNext.TabStop = false;
			this.btnNext.Visible = false;
			this.btnNext.Click += new EventHandler(this.btnNext_Click);
			this.btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.btnPrev.Cursor = Cursors.Hand;
			this.btnPrev.Location = new Point(627, 662);
			this.btnPrev.Name = "btnPrev";
			this.btnPrev.Size = new System.Drawing.Size(83, 57);
			this.btnPrev.SizeMode = PictureBoxSizeMode.StretchImage;
			this.btnPrev.TabIndex = 72;
			this.btnPrev.TabStop = false;
			this.btnPrev.Visible = false;
			this.btnPrev.Click += new EventHandler(this.btnPrev_Click);
			this.pictureBox4.Cursor = Cursors.Hand;
			this.pictureBox4.Location = new Point(43, 515);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(242, 131);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 67;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox4_Click_1);
			this.pictureBox3.Cursor = Cursors.Hand;
			this.pictureBox3.Location = new Point(43, 358);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(242, 131);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 66;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox3_Click_1);
			this.pictureBox2.Cursor = Cursors.Hand;
			this.pictureBox2.Location = new Point(43, 201);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(242, 131);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 65;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new EventHandler(this.pictureBox2_Click_1);
			this.pictureBox1.Cursor = Cursors.Hand;
			this.pictureBox1.Location = new Point(43, 44);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(242, 131);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 64;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click_1);
			this.PhotoViewer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.PhotoViewer.Cursor = Cursors.Hand;
			this.PhotoViewer.Location = new Point(347, 17);
			this.PhotoViewer.Name = "PhotoViewer";
			this.PhotoViewer.Size = new System.Drawing.Size(917, 647);
			this.PhotoViewer.SizeMode = PictureBoxSizeMode.Zoom;
			this.PhotoViewer.TabIndex = 70;
			this.PhotoViewer.TabStop = false;
			this.PhotoViewer.Visible = false;
			this.PhotoViewer.DoubleClick += new EventHandler(this.PhotoViewer_DoubleClick);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1382, 784);
			base.ControlBox = false;
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cmdClose);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Form1";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Videos";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.axWindowsMediaPlayer2.EndInit();
			((ISupportInitialize)this.cmdClose).EndInit();
			((ISupportInitialize)this.btnNext).EndInit();
			((ISupportInitialize)this.btnPrev).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.PhotoViewer).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void PhotoViewer_DoubleClick(object sender, EventArgs e)
		{
			MessageBox.Show(this.PhotoViewer.ImageLocation.ToString());
		}

		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
			this.PhotoViewer.Visible = false;
			this.btnPrev.Visible = false;
			this.btnNext.Visible = false;
			this.comboBox1.Visible = false;
			this.axWindowsMediaPlayer2.URL = "";
			this.webBrowser1.Visible = true;
			this.axWindowsMediaPlayer2.Visible = false;
			this.webBrowser1.Navigate(new Uri(string.Concat(Application.StartupPath, "\\pdf\\", this.fid, ".pdf")));
		}

		private void pictureBox2_Click_1(object sender, EventArgs e)
		{
			this.PhotoViewer.Visible = true;
			this.btnPrev.Visible = true;
			this.btnNext.Visible = true;
			this.comboBox1.Visible = false;
			this.axWindowsMediaPlayer2.close();
			this.webBrowser1.Visible = false;
			this.axWindowsMediaPlayer2.Visible = false;
			if (Directory.Exists(string.Concat(Application.StartupPath, "\\photo\\", this.fname)))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(string.Concat(Application.StartupPath, "\\photo\\", this.fname));
				FileInfo[] files = directoryInfo.GetFiles("*.jpg");
				this.comboBox1.DataSource = files;
			}
			this.PhotoViewer.Visible = true;
			PictureBox photoViewer = this.PhotoViewer;
			string[] startupPath = new string[] { Application.StartupPath, "\\photo\\", this.fname, "\\", this.fname, ".JPG" };
			photoViewer.ImageLocation = string.Concat(startupPath);
		}

		private void pictureBox3_Click_1(object sender, EventArgs e)
		{
			this.PhotoViewer.Visible = false;
			this.btnPrev.Visible = false;
			this.btnNext.Visible = false;
			this.comboBox1.Visible = false;
			this.webBrowser1.Visible = false;
			this.axWindowsMediaPlayer2.Visible = true;
			this.axWindowsMediaPlayer2.URL=(string.Concat(Application.StartupPath, "\\VIDEOS\\", this.fid, ".avi"));
		}

		private void pictureBox4_Click_1(object sender, EventArgs e)
		{
			this.PhotoViewer.Visible = true;
			this.btnPrev.Visible = true;
			this.btnNext.Visible = true;
			this.comboBox1.Visible = false;
			this.axWindowsMediaPlayer2.close();
			this.webBrowser1.Visible = false;
			this.axWindowsMediaPlayer2.Visible = false;
			this.PhotoViewer.Visible = true;
			this.PhotoViewer.ImageLocation = string.Concat(Application.StartupPath, "\\MAPS\\", this.fid, ".jpg");
		}

		private void pictureBox6_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		public void VisibleFalseAll()
		{
		}
	}
}