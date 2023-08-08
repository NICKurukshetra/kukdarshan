using DeafDumb.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DeafDumb
{
	public class FrmWall : Form
	{
		private IContainer components = null;

		private PictureBox cmdClose;

		private TableLayoutPanel tableLayoutPanel1;

		private Panel panel4;

		private Panel panel3;

		private Panel panel2;

		private Panel panel47;

		private Panel panel46;

		private Panel panel45;

		private Panel panel44;

		private Panel panel43;

		private Panel panel42;

		private Panel panel41;

		private Panel panel40;

		private Panel panel39;

		private Panel panel38;

		private Panel panel36;

		private Panel panel35;

		private Panel panel34;

		private Panel panel33;

		private Panel panel32;

		private Panel panel31;

		private Panel panel30;

		private Panel panel28;

		private Panel panel27;

		private Panel panel26;

		private Panel panel25;

		private Panel panel24;

		private Panel panel23;

		private Panel panel22;

		private Panel panel20;

		private Panel panel19;

		private Panel panel18;

		private Panel panel17;

		private Panel panel15;

		private Panel panel14;

		private Panel panel12;

		private Panel panel11;

		private Panel panel10;

		private Panel panel8;

		private Panel panel7;

		private Panel panel6;

		private Panel panel5;

		private Panel panel16;

		private Panel panel1;

		public FrmWall()
		{
			this.InitializeComponent();
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void FrmWall_Click(object sender, EventArgs e)
		{
			int x = Control.MousePosition.X;
			string str = x.ToString();
			x = Control.MousePosition.Y;
			MessageBox.Show(string.Concat(str, ",", x.ToString()));
		}

		private void FrmWall_Load(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			this.tableLayoutPanel1.Width = base.Width - 40;
			this.tableLayoutPanel1.Height = base.Height - 40;
			this.cmdClose.Left = base.Width - 20;
			this.cmdClose.Top = 2;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			//this.panel1.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "//wall/1.jpg"));
			//this.panel2.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "/wall/2.jpg"));
			//this.panel3.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "/wall/3.jpg"));
			//this.panel4.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "/wall/4.jpg"));
			//this.panel5.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "/wall/5.jpg"));
			//this.panel6.BackgroundImage = Image.FromFile(string.Concat(Application.StartupPath, "/wall/6.jpg"));


			string imageFolderPath = Path.Combine(Application.StartupPath, "wall");
			string[] imageFiles = Directory.GetFiles(imageFolderPath, "*.jpg");
			//Array.Sort(imageFiles);
			for (int i = 0; i < imageFiles.Length; i++)
			{
				string panelName = "panel" + (i + 1);
				Panel panel = this.Controls.Find(panelName, true).FirstOrDefault() as Panel;
				int imgname = i + 1;
				if (panel != null)
				{
					panel.BackgroundImage = Image.FromFile(Application.StartupPath+ "/wall/"+imgname+".jpg");
                    
				}
			}


			this.panel1.Tag = "http://103.87.24.58/tourguide/secpage.html?id=11";
			this.panel2.Tag = 2;
			this.panel3.Tag = 3;
			this.panel4.Tag = 4;
			this.panel5.Tag = 5;
			this.panel6.Tag = 6;
			this.panel7.Tag = 7;
			this.panel8.Tag = 8;
			this.panel10.Tag = 10;
			this.panel11.Tag = 11;
			this.panel12.Tag = 12;
			this.panel14.Tag = 14;
			this.panel15.Tag = 15;
			this.panel16.Tag = 16;
			this.panel17.Tag = 17;
			this.panel18.Tag = 18;
			this.panel19.Tag = 19;
			this.panel20.Tag = 20;
			this.panel22.Tag = 22;
			this.panel23.Tag = 23;
			this.panel24.Tag = 24;
			this.panel25.Tag = 25;
			this.panel26.Tag = 26;
			this.panel27.Tag = 27;
			this.panel28.Tag = 28;
			this.panel30.Tag = 30;
			this.panel31.Tag = 31;
			this.panel32.Tag = 32;
			this.panel33.Tag = 33;
			this.panel34.Tag = 34;
			this.panel35.Tag = 35;
			this.panel36.Tag = 36;
			this.panel38.Tag = 38;
			this.panel39.Tag = 39;
			this.panel40.Tag = 40;
			this.panel41.Tag = 41;
			this.panel42.Tag = 42;
			this.panel43.Tag = 43;
			this.panel44.Tag = 44;
			this.panel45.Tag = 45;
			this.panel46.Tag = 46;
			this.panel47.Tag = 47;
		}

		private void InitializeComponent()
		{
            this.cmdClose = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel47 = new System.Windows.Forms.Panel();
            this.panel46 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdClose
            // 
            this.cmdClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdClose.Image = global::DeafDumb.Properties.Resources.close_button_md;
            this.cmdClose.Location = new System.Drawing.Point(1158, 1);
            this.cmdClose.Margin = new System.Windows.Forms.Padding(10);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Padding = new System.Windows.Forms.Padding(2);
            this.cmdClose.Size = new System.Drawing.Size(41, 40);
            this.cmdClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cmdClose.TabIndex = 58;
            this.cmdClose.TabStop = false;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.panel47, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel46, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel45, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel44, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel43, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel42, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel41, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel40, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel39, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel38, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel36, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel35, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel34, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel33, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel32, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel31, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel30, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel28, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel27, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel26, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel25, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel24, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel23, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel22, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel20, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel19, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel18, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel17, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 12);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 373);
            this.tableLayoutPanel1.TabIndex = 60;
            // 
            // panel47
            // 
            this.panel47.BackColor = System.Drawing.Color.DarkRed;
            this.panel47.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel47.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel47.Location = new System.Drawing.Point(573, 313);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(89, 57);
            this.panel47.TabIndex = 46;
            this.panel47.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel46
            // 
            this.panel46.BackColor = System.Drawing.Color.DarkRed;
            this.panel46.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel46.Location = new System.Drawing.Point(478, 313);
            this.panel46.Name = "panel46";
            this.panel46.Size = new System.Drawing.Size(89, 57);
            this.panel46.TabIndex = 45;
            this.panel46.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel45
            // 
            this.panel45.BackColor = System.Drawing.Color.DarkRed;
            this.panel45.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(383, 313);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(89, 57);
            this.panel45.TabIndex = 44;
            this.panel45.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel44
            // 
            this.panel44.BackColor = System.Drawing.Color.DarkRed;
            this.panel44.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel44.Location = new System.Drawing.Point(288, 313);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(89, 57);
            this.panel44.TabIndex = 43;
            this.panel44.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel43
            // 
            this.panel43.BackColor = System.Drawing.Color.DarkRed;
            this.panel43.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel43.Location = new System.Drawing.Point(193, 313);
            this.panel43.Name = "panel43";
            this.panel43.Size = new System.Drawing.Size(89, 57);
            this.panel43.TabIndex = 42;
            this.panel43.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel42
            // 
            this.panel42.BackColor = System.Drawing.Color.DarkRed;
            this.panel42.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel42.Location = new System.Drawing.Point(98, 313);
            this.panel42.Name = "panel42";
            this.panel42.Size = new System.Drawing.Size(89, 57);
            this.panel42.TabIndex = 41;
            this.panel42.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel41
            // 
            this.panel41.BackColor = System.Drawing.Color.DarkRed;
            this.panel41.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(3, 313);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(89, 57);
            this.panel41.TabIndex = 40;
            this.panel41.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.Color.DarkRed;
            this.panel40.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel40.Location = new System.Drawing.Point(668, 251);
            this.panel40.Name = "panel40";
            this.tableLayoutPanel1.SetRowSpan(this.panel40, 2);
            this.panel40.Size = new System.Drawing.Size(93, 119);
            this.panel40.TabIndex = 39;
            this.panel40.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.Color.DarkRed;
            this.panel39.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel39.Location = new System.Drawing.Point(573, 251);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(89, 56);
            this.panel39.TabIndex = 38;
            this.panel39.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel38
            // 
            this.panel38.BackColor = System.Drawing.Color.DarkRed;
            this.panel38.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel38.Location = new System.Drawing.Point(478, 251);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(89, 56);
            this.panel38.TabIndex = 37;
            this.panel38.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.Color.DarkRed;
            this.panel36.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.panel36, 2);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(288, 251);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(184, 56);
            this.panel36.TabIndex = 35;
            this.panel36.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel35
            // 
            this.panel35.BackColor = System.Drawing.Color.DarkRed;
            this.panel35.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel35.Location = new System.Drawing.Point(193, 251);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(89, 56);
            this.panel35.TabIndex = 34;
            this.panel35.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel34
            // 
            this.panel34.BackColor = System.Drawing.Color.DarkRed;
            this.panel34.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(98, 251);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(89, 56);
            this.panel34.TabIndex = 33;
            this.panel34.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel33
            // 
            this.panel33.BackColor = System.Drawing.Color.DarkRed;
            this.panel33.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel33.Location = new System.Drawing.Point(3, 251);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(89, 56);
            this.panel33.TabIndex = 32;
            this.panel33.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel32
            // 
            this.panel32.BackColor = System.Drawing.Color.DarkRed;
            this.panel32.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(668, 189);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(93, 56);
            this.panel32.TabIndex = 31;
            this.panel32.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.Color.DarkRed;
            this.panel31.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel31.Location = new System.Drawing.Point(573, 189);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(89, 56);
            this.panel31.TabIndex = 30;
            this.panel31.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel30
            // 
            this.panel30.BackColor = System.Drawing.Color.DarkRed;
            this.panel30.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(478, 189);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(89, 56);
            this.panel30.TabIndex = 29;
            this.panel30.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.DarkRed;
            this.panel28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.panel28, 2);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(288, 189);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(184, 56);
            this.panel28.TabIndex = 27;
            this.panel28.Tag = "Braham Sarovar";
            this.panel28.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel27
            // 
            this.panel27.BackColor = System.Drawing.Color.DarkRed;
            this.panel27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel27.Location = new System.Drawing.Point(193, 189);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(89, 56);
            this.panel27.TabIndex = 26;
            this.panel27.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel26
            // 
            this.panel26.BackColor = System.Drawing.Color.DarkRed;
            this.panel26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(98, 189);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(89, 56);
            this.panel26.TabIndex = 25;
            this.panel26.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel25
            // 
            this.panel25.BackColor = System.Drawing.Color.DarkRed;
            this.panel25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel25.Location = new System.Drawing.Point(3, 189);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(89, 56);
            this.panel25.TabIndex = 24;
            this.panel25.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.Color.DarkRed;
            this.panel24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(668, 127);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(93, 56);
            this.panel24.TabIndex = 23;
            this.panel24.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.DarkRed;
            this.panel23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(573, 127);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(89, 56);
            this.panel23.TabIndex = 22;
            this.panel23.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel22
            // 
            this.panel22.BackColor = System.Drawing.Color.DarkRed;
            this.panel22.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(478, 127);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(89, 56);
            this.panel22.TabIndex = 21;
            this.panel22.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.DarkRed;
            this.panel20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.panel20, 2);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(288, 127);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(184, 56);
            this.panel20.TabIndex = 19;
            this.panel20.Tag = "Braham Sarovar";
            this.panel20.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.DarkRed;
            this.panel19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(193, 127);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(89, 56);
            this.panel19.TabIndex = 18;
            this.panel19.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.DarkRed;
            this.panel18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(98, 127);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(89, 56);
            this.panel18.TabIndex = 17;
            this.panel18.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.DarkRed;
            this.panel17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(3, 127);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(89, 56);
            this.panel17.TabIndex = 16;
            this.panel17.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.DarkRed;
            this.panel16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(668, 65);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(93, 56);
            this.panel16.TabIndex = 15;
            this.panel16.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.DarkRed;
            this.panel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(573, 65);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(89, 56);
            this.panel15.TabIndex = 14;
            this.panel15.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkRed;
            this.panel14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(478, 65);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(89, 56);
            this.panel14.TabIndex = 13;
            this.panel14.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkRed;
            this.panel12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.panel12, 2);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(288, 65);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(184, 56);
            this.panel12.TabIndex = 11;
            this.panel12.Tag = "Sannehit Sarovar";
            this.panel12.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkRed;
            this.panel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(193, 65);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(89, 56);
            this.panel11.TabIndex = 10;
            this.panel11.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DarkRed;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(98, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(89, 56);
            this.panel10.TabIndex = 9;
            this.panel10.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkRed;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(668, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(93, 56);
            this.panel8.TabIndex = 7;
            this.panel8.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkRed;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(573, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(89, 56);
            this.panel7.TabIndex = 6;
            this.panel7.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkRed;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(478, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(89, 56);
            this.panel6.TabIndex = 5;
            this.panel6.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkRed;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(383, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(89, 56);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkRed;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(288, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(89, 56);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(193, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(89, 56);
            this.panel3.TabIndex = 2;
            this.panel3.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkRed;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(98, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(89, 56);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.panel1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(89, 118);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // FrmWall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1203, 465);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWall";
            this.Text = "FrmWall";
            this.Load += new System.EventHandler(this.FrmWall_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmdClose)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		private void panel1_Click(object sender, EventArgs e)
		{
			(new PhotoViewer(((Panel)sender).Tag.ToString())).Show();
		}

		private void panel1_DoubleClick(object sender, EventArgs e)
		{
		}
	}
}