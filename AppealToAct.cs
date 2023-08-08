using DeafDumb.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace DeafDumb
{
	public class AppealToAct : Form
	{
		private IContainer components = null;

		private Panel panel1;

		private PictureBox pictureBox1;

		private Label label1;

		private PictureBox pictureBox2;

		private PictureBox pictureBox4;

		private PictureBox pictureBox5;

		private PictureBox pictureBox6;

		private PictureBox pictureBox3;

		private PictureBox pictureBox7;

		private PictureBox pictureBox8;

		private PictureBox pictureBox9;

		private PictureBox pictureBox10;

		private PictureBox pictureBox12;

		private PictureBox pictureBox11;

		private PictureBox pictureBox13;

		private PictureBox pictureBox14;

		private PictureBox pictureBox15;

		private PictureBox cmdClose;

		private PictureBox pictureBox20;

		private PictureBox pictureBox19;

		private PictureBox pictureBox18;

		private PictureBox pictureBox17;

		private PictureBox pictureBox16;

		private connection cn = new connection();

		private OleDbConnection con = new OleDbConnection();

		public AppealToAct()
		{
			this.InitializeComponent();
			this.con.ConnectionString = this.cn.connectionstring;
		}

		private void AppealToAct_Load(object sender, EventArgs e)
		{
			OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter("select * from butmaster order by butid", this.con);
			DataSet dataSet = new DataSet();
			oleDbDataAdapter.Fill(dataSet);
			this.pictureBox1.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[0]["ButtonDesc"].ToString(), ".png");
			this.pictureBox2.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[1]["ButtonDesc"].ToString(), ".png");
			this.pictureBox4.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[2]["ButtonDesc"].ToString(), ".png");
			this.pictureBox5.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[3]["ButtonDesc"].ToString(), ".png");
			this.pictureBox6.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[4]["ButtonDesc"].ToString(), ".png");
			this.pictureBox3.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[5]["ButtonDesc"].ToString(), ".png");
			this.pictureBox7.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[6]["ButtonDesc"].ToString(), ".png");
			this.pictureBox8.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[7]["ButtonDesc"].ToString(), ".png");
			this.pictureBox9.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[8]["ButtonDesc"].ToString(), ".png");
			this.pictureBox10.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[9]["ButtonDesc"].ToString(), ".png");
			this.pictureBox11.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[10]["ButtonDesc"].ToString(), ".png");
			this.pictureBox12.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[11]["ButtonDesc"].ToString(), ".png");
			this.pictureBox13.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[12]["ButtonDesc"].ToString(), ".png");
			this.pictureBox14.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[13]["ButtonDesc"].ToString(), ".png");
			this.pictureBox15.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[14]["ButtonDesc"].ToString(), ".png");
			this.pictureBox16.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[15]["ButtonDesc"].ToString(), ".png");
			this.pictureBox17.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[17]["ButtonDesc"].ToString(), ".png");
			this.pictureBox18.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[18]["ButtonDesc"].ToString(), ".png");
			this.pictureBox19.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[19]["ButtonDesc"].ToString(), ".png");
			this.pictureBox20.ImageLocation = string.Concat(Application.StartupPath, "/IMAGES/", dataSet.Tables[0].Rows[20]["ButtonDesc"].ToString(), ".png");
			base.WindowState = FormWindowState.Maximized;
			this.panel1.Width = base.Width - 40;
			this.panel1.Height = base.Height - 80;
			this.cmdClose.Left = base.Width - 80;
			this.cmdClose.Top = 10;
		}

		private void button1_Click(object sender, EventArgs e)
		{
		}

		private void cmdClose_Click(object sender, EventArgs e)
		{
			base.Close();
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
			this.panel1 = new Panel();
			this.pictureBox20 = new PictureBox();
			this.pictureBox19 = new PictureBox();
			this.pictureBox18 = new PictureBox();
			this.pictureBox17 = new PictureBox();
			this.pictureBox13 = new PictureBox();
			this.pictureBox14 = new PictureBox();
			this.pictureBox15 = new PictureBox();
			this.pictureBox16 = new PictureBox();
			this.pictureBox12 = new PictureBox();
			this.pictureBox11 = new PictureBox();
			this.pictureBox10 = new PictureBox();
			this.pictureBox9 = new PictureBox();
			this.pictureBox8 = new PictureBox();
			this.pictureBox7 = new PictureBox();
			this.pictureBox3 = new PictureBox();
			this.pictureBox6 = new PictureBox();
			this.pictureBox5 = new PictureBox();
			this.pictureBox4 = new PictureBox();
			this.pictureBox2 = new PictureBox();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.cmdClose = new PictureBox();
			this.panel1.SuspendLayout();
			((ISupportInitialize)this.pictureBox20).BeginInit();
			((ISupportInitialize)this.pictureBox19).BeginInit();
			((ISupportInitialize)this.pictureBox18).BeginInit();
			((ISupportInitialize)this.pictureBox17).BeginInit();
			((ISupportInitialize)this.pictureBox13).BeginInit();
			((ISupportInitialize)this.pictureBox14).BeginInit();
			((ISupportInitialize)this.pictureBox15).BeginInit();
			((ISupportInitialize)this.pictureBox16).BeginInit();
			((ISupportInitialize)this.pictureBox12).BeginInit();
			((ISupportInitialize)this.pictureBox11).BeginInit();
			((ISupportInitialize)this.pictureBox10).BeginInit();
			((ISupportInitialize)this.pictureBox9).BeginInit();
			((ISupportInitialize)this.pictureBox8).BeginInit();
			((ISupportInitialize)this.pictureBox7).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox6).BeginInit();
			((ISupportInitialize)this.pictureBox5).BeginInit();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			((ISupportInitialize)this.pictureBox1).BeginInit();
			((ISupportInitialize)this.cmdClose).BeginInit();
			base.SuspendLayout();
			this.panel1.BorderStyle = BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.pictureBox20);
			this.panel1.Controls.Add(this.pictureBox19);
			this.panel1.Controls.Add(this.pictureBox18);
			this.panel1.Controls.Add(this.pictureBox17);
			this.panel1.Controls.Add(this.pictureBox13);
			this.panel1.Controls.Add(this.pictureBox14);
			this.panel1.Controls.Add(this.pictureBox15);
			this.panel1.Controls.Add(this.pictureBox16);
			this.panel1.Controls.Add(this.pictureBox12);
			this.panel1.Controls.Add(this.pictureBox11);
			this.panel1.Controls.Add(this.pictureBox10);
			this.panel1.Controls.Add(this.pictureBox9);
			this.panel1.Controls.Add(this.pictureBox8);
			this.panel1.Controls.Add(this.pictureBox7);
			this.panel1.Controls.Add(this.pictureBox3);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.pictureBox5);
			this.panel1.Controls.Add(this.pictureBox4);
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new Point(12, 45);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(30);
			this.panel1.Size = new System.Drawing.Size(1270, 608);
			this.panel1.TabIndex = 0;
			this.pictureBox20.Cursor = Cursors.Hand;
			this.pictureBox20.Location = new Point(1022, 521);
			this.pictureBox20.Name = "pictureBox20";
			this.pictureBox20.Size = new System.Drawing.Size(196, 131);
			this.pictureBox20.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox20.TabIndex = 75;
			this.pictureBox20.TabStop = false;
			this.pictureBox20.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox19.Cursor = Cursors.Hand;
			this.pictureBox19.Location = new Point(778, 521);
			this.pictureBox19.Name = "pictureBox19";
			this.pictureBox19.Size = new System.Drawing.Size(196, 131);
			this.pictureBox19.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox19.TabIndex = 74;
			this.pictureBox19.TabStop = false;
			this.pictureBox19.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox18.Cursor = Cursors.Hand;
			this.pictureBox18.Location = new Point(534, 521);
			this.pictureBox18.Name = "pictureBox18";
			this.pictureBox18.Size = new System.Drawing.Size(196, 131);
			this.pictureBox18.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox18.TabIndex = 73;
			this.pictureBox18.TabStop = false;
			this.pictureBox18.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox17.Cursor = Cursors.Hand;
			this.pictureBox17.Location = new Point(290, 521);
			this.pictureBox17.Name = "pictureBox17";
			this.pictureBox17.Size = new System.Drawing.Size(196, 131);
			this.pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox17.TabIndex = 72;
			this.pictureBox17.TabStop = false;
			this.pictureBox17.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox13.Cursor = Cursors.Hand;
			this.pictureBox13.Location = new Point(534, 361);
			this.pictureBox13.Name = "pictureBox13";
			this.pictureBox13.Size = new System.Drawing.Size(196, 131);
			this.pictureBox13.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox13.TabIndex = 71;
			this.pictureBox13.TabStop = false;
			this.pictureBox13.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox14.Cursor = Cursors.Hand;
			this.pictureBox14.Location = new Point(778, 370);
			this.pictureBox14.Name = "pictureBox14";
			this.pictureBox14.Size = new System.Drawing.Size(196, 131);
			this.pictureBox14.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox14.TabIndex = 70;
			this.pictureBox14.TabStop = false;
			this.pictureBox14.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox15.Cursor = Cursors.Hand;
			this.pictureBox15.Location = new Point(1022, 370);
			this.pictureBox15.Name = "pictureBox15";
			this.pictureBox15.Size = new System.Drawing.Size(196, 131);
			this.pictureBox15.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox15.TabIndex = 69;
			this.pictureBox15.TabStop = false;
			this.pictureBox15.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox16.Cursor = Cursors.Hand;
			this.pictureBox16.Location = new Point(46, 521);
			this.pictureBox16.Name = "pictureBox16";
			this.pictureBox16.Size = new System.Drawing.Size(196, 131);
			this.pictureBox16.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox16.TabIndex = 68;
			this.pictureBox16.TabStop = false;
			this.pictureBox16.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox12.Cursor = Cursors.Hand;
			this.pictureBox12.Location = new Point(290, 361);
			this.pictureBox12.Name = "pictureBox12";
			this.pictureBox12.Size = new System.Drawing.Size(196, 131);
			this.pictureBox12.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox12.TabIndex = 67;
			this.pictureBox12.TabStop = false;
			this.pictureBox12.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox11.Cursor = Cursors.Hand;
			this.pictureBox11.Location = new Point(778, 204);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(196, 131);
			this.pictureBox11.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox11.TabIndex = 66;
			this.pictureBox11.TabStop = false;
			this.pictureBox11.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox10.Cursor = Cursors.Hand;
			this.pictureBox10.Location = new Point(46, 361);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(196, 131);
			this.pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 65;
			this.pictureBox10.TabStop = false;
			this.pictureBox10.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox9.Cursor = Cursors.Hand;
			this.pictureBox9.Location = new Point(1022, 204);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(196, 131);
			this.pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 64;
			this.pictureBox9.TabStop = false;
			this.pictureBox9.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox8.Cursor = Cursors.Hand;
			this.pictureBox8.Location = new Point(534, 204);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(196, 131);
			this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 63;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox7.Cursor = Cursors.Hand;
			this.pictureBox7.Location = new Point(290, 204);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(196, 131);
			this.pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 62;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox3.Cursor = Cursors.Hand;
			this.pictureBox3.Location = new Point(46, 204);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(196, 131);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 61;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox6.Cursor = Cursors.Hand;
			this.pictureBox6.Location = new Point(1022, 48);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(196, 131);
			this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 60;
			this.pictureBox6.TabStop = false;
			this.pictureBox6.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox5.Cursor = Cursors.Hand;
			this.pictureBox5.Location = new Point(778, 47);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(196, 131);
			this.pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 59;
			this.pictureBox5.TabStop = false;
			this.pictureBox5.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox4.Cursor = Cursors.Hand;
			this.pictureBox4.Location = new Point(534, 47);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(196, 131);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 56;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox2.Cursor = Cursors.Hand;
			this.pictureBox2.Location = new Point(290, 47);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(196, 131);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 54;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new EventHandler(this.pictureBox1_Click);
			this.pictureBox1.Cursor = Cursors.Hand;
			this.pictureBox1.Location = new Point(46, 47);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(196, 131);
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 45;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new EventHandler(this.pictureBox1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.Red;
			this.label1.Location = new Point(460, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(396, 33);
			this.label1.TabIndex = 46;
			this.label1.Text = "KURUKSHETRA DARSHAN";
			this.cmdClose.Cursor = Cursors.Hand;
			this.cmdClose.Image = Resources.close_button_md;
			this.cmdClose.Location = new Point(1288, 22);
			this.cmdClose.Name = "cmdClose";
			this.cmdClose.Size = new System.Drawing.Size(69, 63);
			this.cmdClose.SizeMode = PictureBoxSizeMode.StretchImage;
			this.cmdClose.TabIndex = 57;
			this.cmdClose.TabStop = false;
			this.cmdClose.Click += new EventHandler(this.cmdClose_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(1351, 752);
			base.Controls.Add(this.cmdClose);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Name = "AppealToAct";
			this.Text = "AppealToAct";
			base.Load += new EventHandler(this.AppealToAct_Load);
			this.panel1.ResumeLayout(false);
			((ISupportInitialize)this.pictureBox20).EndInit();
			((ISupportInitialize)this.pictureBox19).EndInit();
			((ISupportInitialize)this.pictureBox18).EndInit();
			((ISupportInitialize)this.pictureBox17).EndInit();
			((ISupportInitialize)this.pictureBox13).EndInit();
			((ISupportInitialize)this.pictureBox14).EndInit();
			((ISupportInitialize)this.pictureBox15).EndInit();
			((ISupportInitialize)this.pictureBox16).EndInit();
			((ISupportInitialize)this.pictureBox12).EndInit();
			((ISupportInitialize)this.pictureBox11).EndInit();
			((ISupportInitialize)this.pictureBox10).EndInit();
			((ISupportInitialize)this.pictureBox9).EndInit();
			((ISupportInitialize)this.pictureBox8).EndInit();
			((ISupportInitialize)this.pictureBox7).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox6).EndInit();
			((ISupportInitialize)this.pictureBox5).EndInit();
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			((ISupportInitialize)this.pictureBox1).EndInit();
			((ISupportInitialize)this.cmdClose).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			string str = ((PictureBox)sender).ImageLocation.Substring(7).Replace(".png", "");
			str = str.Substring(str.LastIndexOf("/") + 1).Replace(".png", "");
			(new Form1(str)).Show();
		}
	}
}