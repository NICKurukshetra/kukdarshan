using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DeafDumb
{
	public class MDIParent1 : Form
	{
		private int childFormNumber = 0;

		private IContainer components = null;

		private MenuStrip menuStrip;

		private ToolStrip toolStrip;

		private StatusStrip statusStrip;

		private ToolStripSeparator toolStripSeparator1;

		private ToolStripSeparator toolStripSeparator2;

		private ToolStripSeparator toolStripSeparator3;

		private ToolStripSeparator toolStripSeparator4;

		private ToolStripSeparator toolStripSeparator5;

		private ToolStripSeparator toolStripSeparator6;

		private ToolStripMenuItem printSetupToolStripMenuItem;

		private ToolStripSeparator toolStripSeparator7;

		private ToolStripSeparator toolStripSeparator8;

		private ToolStripStatusLabel toolStripStatusLabel;

		private ToolStripMenuItem aboutToolStripMenuItem;

		private ToolStripMenuItem tileHorizontalToolStripMenuItem;

		private ToolStripMenuItem fileMenu;

		private ToolStripMenuItem newToolStripMenuItem;

		private ToolStripMenuItem openToolStripMenuItem;

		private ToolStripMenuItem saveToolStripMenuItem;

		private ToolStripMenuItem saveAsToolStripMenuItem;

		private ToolStripMenuItem printToolStripMenuItem;

		private ToolStripMenuItem printPreviewToolStripMenuItem;

		private ToolStripMenuItem exitToolStripMenuItem;

		private ToolStripMenuItem editMenu;

		private ToolStripMenuItem undoToolStripMenuItem;

		private ToolStripMenuItem redoToolStripMenuItem;

		private ToolStripMenuItem cutToolStripMenuItem;

		private ToolStripMenuItem copyToolStripMenuItem;

		private ToolStripMenuItem pasteToolStripMenuItem;

		private ToolStripMenuItem selectAllToolStripMenuItem;

		private ToolStripMenuItem viewMenu;

		private ToolStripMenuItem toolBarToolStripMenuItem;

		private ToolStripMenuItem statusBarToolStripMenuItem;

		private ToolStripMenuItem toolsMenu;

		private ToolStripMenuItem optionsToolStripMenuItem;

		private ToolStripMenuItem windowsMenu;

		private ToolStripMenuItem newWindowToolStripMenuItem;

		private ToolStripMenuItem cascadeToolStripMenuItem;

		private ToolStripMenuItem tileVerticalToolStripMenuItem;

		private ToolStripMenuItem closeAllToolStripMenuItem;

		private ToolStripMenuItem arrangeIconsToolStripMenuItem;

		private ToolStripMenuItem helpMenu;

		private ToolStripMenuItem contentsToolStripMenuItem;

		private ToolStripMenuItem indexToolStripMenuItem;

		private ToolStripMenuItem searchToolStripMenuItem;

		private ToolStripButton newToolStripButton;

		private ToolStripButton openToolStripButton;

		private ToolStripButton saveToolStripButton;

		private ToolStripButton printToolStripButton;

		private ToolStripButton printPreviewToolStripButton;

		private ToolStripButton helpToolStripButton;

		private ToolTip toolTip;

		public MDIParent1()
		{
			this.InitializeComponent();
		}

		private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.ArrangeIcons);
		}

		private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.Cascade);
		}

		private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form[] mdiChildren = base.MdiChildren;
			for (int i = 0; i < (int)mdiChildren.Length; i++)
			{
				mdiChildren[i].Close();
			}
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void CutToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MDIParent1));
			this.menuStrip = new MenuStrip();
			this.fileMenu = new ToolStripMenuItem();
			this.newToolStripMenuItem = new ToolStripMenuItem();
			this.openToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator3 = new ToolStripSeparator();
			this.saveToolStripMenuItem = new ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator4 = new ToolStripSeparator();
			this.printToolStripMenuItem = new ToolStripMenuItem();
			this.printPreviewToolStripMenuItem = new ToolStripMenuItem();
			this.printSetupToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator5 = new ToolStripSeparator();
			this.exitToolStripMenuItem = new ToolStripMenuItem();
			this.editMenu = new ToolStripMenuItem();
			this.undoToolStripMenuItem = new ToolStripMenuItem();
			this.redoToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator6 = new ToolStripSeparator();
			this.cutToolStripMenuItem = new ToolStripMenuItem();
			this.copyToolStripMenuItem = new ToolStripMenuItem();
			this.pasteToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator7 = new ToolStripSeparator();
			this.selectAllToolStripMenuItem = new ToolStripMenuItem();
			this.viewMenu = new ToolStripMenuItem();
			this.toolBarToolStripMenuItem = new ToolStripMenuItem();
			this.statusBarToolStripMenuItem = new ToolStripMenuItem();
			this.toolsMenu = new ToolStripMenuItem();
			this.optionsToolStripMenuItem = new ToolStripMenuItem();
			this.windowsMenu = new ToolStripMenuItem();
			this.newWindowToolStripMenuItem = new ToolStripMenuItem();
			this.cascadeToolStripMenuItem = new ToolStripMenuItem();
			this.tileVerticalToolStripMenuItem = new ToolStripMenuItem();
			this.tileHorizontalToolStripMenuItem = new ToolStripMenuItem();
			this.closeAllToolStripMenuItem = new ToolStripMenuItem();
			this.arrangeIconsToolStripMenuItem = new ToolStripMenuItem();
			this.helpMenu = new ToolStripMenuItem();
			this.contentsToolStripMenuItem = new ToolStripMenuItem();
			this.indexToolStripMenuItem = new ToolStripMenuItem();
			this.searchToolStripMenuItem = new ToolStripMenuItem();
			this.toolStripSeparator8 = new ToolStripSeparator();
			this.aboutToolStripMenuItem = new ToolStripMenuItem();
			this.toolStrip = new ToolStrip();
			this.newToolStripButton = new ToolStripButton();
			this.openToolStripButton = new ToolStripButton();
			this.saveToolStripButton = new ToolStripButton();
			this.toolStripSeparator1 = new ToolStripSeparator();
			this.printToolStripButton = new ToolStripButton();
			this.printPreviewToolStripButton = new ToolStripButton();
			this.toolStripSeparator2 = new ToolStripSeparator();
			this.helpToolStripButton = new ToolStripButton();
			this.statusStrip = new StatusStrip();
			this.toolStripStatusLabel = new ToolStripStatusLabel();
			this.toolTip = new ToolTip(this.components);
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			base.SuspendLayout();
			ToolStripItemCollection items = this.menuStrip.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.fileMenu, this.editMenu, this.viewMenu, this.toolsMenu, this.windowsMenu, this.helpMenu };
			items.AddRange(toolStripItemArray);
			this.menuStrip.Location = new Point(0, 0);
			this.menuStrip.MdiWindowListItem = this.windowsMenu;
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(632, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "MenuStrip";
			this.menuStrip.Visible = false;
			ToolStripItemCollection dropDownItems = this.fileMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.newToolStripMenuItem, this.openToolStripMenuItem, this.toolStripSeparator3, this.saveToolStripMenuItem, this.saveAsToolStripMenuItem, this.toolStripSeparator4, this.printToolStripMenuItem, this.printPreviewToolStripMenuItem, this.printSetupToolStripMenuItem, this.toolStripSeparator5, this.exitToolStripMenuItem };
			dropDownItems.AddRange(toolStripItemArray);
			this.fileMenu.ImageTransparentColor = SystemColors.ActiveBorder;
			this.fileMenu.Name = "fileMenu";
			this.fileMenu.Size = new System.Drawing.Size(37, 20);
			this.fileMenu.Text = "&File";
			this.newToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("newToolStripMenuItem.Image");
			this.newToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.ShortcutKeys = Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.Back | Keys.LineFeed | Keys.Clear | Keys.B | Keys.D | Keys.F | Keys.H | Keys.J | Keys.L | Keys.N | Keys.Control;
			this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.newToolStripMenuItem.Text = "&New";
			this.newToolStripMenuItem.Click += new EventHandler(this.ShowNewForm);
			this.openToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("openToolStripMenuItem.Image");
			this.openToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.MButton | Keys.XButton1 | Keys.XButton2 | Keys.Back | Keys.Tab | Keys.LineFeed | Keys.Clear | Keys.Return | Keys.Enter | Keys.A | Keys.B | Keys.C | Keys.D | Keys.E | Keys.F | Keys.G | Keys.H | Keys.I | Keys.J | Keys.K | Keys.L | Keys.M | Keys.N | Keys.O | Keys.Control;
			this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.openToolStripMenuItem.Text = "&Open";
			this.openToolStripMenuItem.Click += new EventHandler(this.OpenFile);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
			this.saveToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("saveToolStripMenuItem.Image");
			this.saveToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.ShiftKey | Keys.ControlKey | Keys.Menu | Keys.Pause | Keys.A | Keys.B | Keys.C | Keys.P | Keys.Q | Keys.R | Keys.S | Keys.Control;
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveToolStripMenuItem.Text = "&Save";
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.saveAsToolStripMenuItem.Text = "Save &As";
			this.saveAsToolStripMenuItem.Click += new EventHandler(this.SaveAsToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(143, 6);
			this.printToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("printToolStripMenuItem.Image");
			this.printToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.printToolStripMenuItem.Name = "printToolStripMenuItem";
			this.printToolStripMenuItem.ShortcutKeys = Keys.ShiftKey | Keys.P | Keys.Control;
			this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.printToolStripMenuItem.Text = "&Print";
			this.printPreviewToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("printPreviewToolStripMenuItem.Image");
			this.printPreviewToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
			this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
			this.printSetupToolStripMenuItem.Name = "printSetupToolStripMenuItem";
			this.printSetupToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.printSetupToolStripMenuItem.Text = "Print Setup";
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(143, 6);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new EventHandler(this.ExitToolsStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections = this.editMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.undoToolStripMenuItem, this.redoToolStripMenuItem, this.toolStripSeparator6, this.cutToolStripMenuItem, this.copyToolStripMenuItem, this.pasteToolStripMenuItem, this.toolStripSeparator7, this.selectAllToolStripMenuItem };
			toolStripItemCollections.AddRange(toolStripItemArray);
			this.editMenu.Name = "editMenu";
			this.editMenu.Size = new System.Drawing.Size(39, 20);
			this.editMenu.Text = "&Edit";
			this.undoToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("undoToolStripMenuItem.Image");
			this.undoToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
			this.undoToolStripMenuItem.ShortcutKeys = Keys.RButton | Keys.Back | Keys.LineFeed | Keys.ShiftKey | Keys.Menu | Keys.FinalMode | Keys.B | Keys.H | Keys.J | Keys.P | Keys.R | Keys.X | Keys.Z | Keys.Control;
			this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.undoToolStripMenuItem.Text = "&Undo";
			this.redoToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("redoToolStripMenuItem.Image");
			this.redoToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
			this.redoToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.Back | Keys.Tab | Keys.ShiftKey | Keys.ControlKey | Keys.FinalMode | Keys.HanjaMode | Keys.KanjiMode | Keys.A | Keys.H | Keys.I | Keys.P | Keys.Q | Keys.X | Keys.Y | Keys.Control;
			this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.redoToolStripMenuItem.Text = "&Redo";
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(161, 6);
			this.cutToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("cutToolStripMenuItem.Image");
			this.cutToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.ShortcutKeys = Keys.Back | Keys.ShiftKey | Keys.FinalMode | Keys.H | Keys.P | Keys.X | Keys.Control;
			this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.cutToolStripMenuItem.Text = "Cu&t";
			this.cutToolStripMenuItem.Click += new EventHandler(this.CutToolStripMenuItem_Click);
			this.copyToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("copyToolStripMenuItem.Image");
			this.copyToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.RButton | Keys.Cancel | Keys.A | Keys.B | Keys.C | Keys.Control;
			this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.copyToolStripMenuItem.Text = "&Copy";
			this.copyToolStripMenuItem.Click += new EventHandler(this.CopyToolStripMenuItem_Click);
			this.pasteToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("pasteToolStripMenuItem.Image");
			this.pasteToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.ShortcutKeys = Keys.RButton | Keys.MButton | Keys.XButton2 | Keys.ShiftKey | Keys.Menu | Keys.Capital | Keys.CapsLock | Keys.B | Keys.D | Keys.F | Keys.P | Keys.R | Keys.T | Keys.V | Keys.Control;
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.pasteToolStripMenuItem.Text = "&Paste";
			this.pasteToolStripMenuItem.Click += new EventHandler(this.PasteToolStripMenuItem_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(161, 6);
			this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
			this.selectAllToolStripMenuItem.ShortcutKeys = Keys.LButton | Keys.A | Keys.Control;
			this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
			this.selectAllToolStripMenuItem.Text = "Select &All";
			ToolStripItemCollection dropDownItems1 = this.viewMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.toolBarToolStripMenuItem, this.statusBarToolStripMenuItem };
			dropDownItems1.AddRange(toolStripItemArray);
			this.viewMenu.Name = "viewMenu";
			this.viewMenu.Size = new System.Drawing.Size(44, 20);
			this.viewMenu.Text = "&View";
			this.toolBarToolStripMenuItem.Checked = true;
			this.toolBarToolStripMenuItem.CheckOnClick = true;
			this.toolBarToolStripMenuItem.CheckState = CheckState.Checked;
			this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
			this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.toolBarToolStripMenuItem.Text = "&Toolbar";
			this.toolBarToolStripMenuItem.Click += new EventHandler(this.ToolBarToolStripMenuItem_Click);
			this.statusBarToolStripMenuItem.Checked = true;
			this.statusBarToolStripMenuItem.CheckOnClick = true;
			this.statusBarToolStripMenuItem.CheckState = CheckState.Checked;
			this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
			this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.statusBarToolStripMenuItem.Text = "&Status Bar";
			this.statusBarToolStripMenuItem.Click += new EventHandler(this.StatusBarToolStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections1 = this.toolsMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.optionsToolStripMenuItem };
			toolStripItemCollections1.AddRange(toolStripItemArray);
			this.toolsMenu.Name = "toolsMenu";
			this.toolsMenu.Size = new System.Drawing.Size(48, 20);
			this.toolsMenu.Text = "&Tools";
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			ToolStripItemCollection dropDownItems2 = this.windowsMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.newWindowToolStripMenuItem, this.cascadeToolStripMenuItem, this.tileVerticalToolStripMenuItem, this.tileHorizontalToolStripMenuItem, this.closeAllToolStripMenuItem, this.arrangeIconsToolStripMenuItem };
			dropDownItems2.AddRange(toolStripItemArray);
			this.windowsMenu.Name = "windowsMenu";
			this.windowsMenu.Size = new System.Drawing.Size(68, 20);
			this.windowsMenu.Text = "&Windows";
			this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
			this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.newWindowToolStripMenuItem.Text = "&New Window";
			this.newWindowToolStripMenuItem.Click += new EventHandler(this.ShowNewForm);
			this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
			this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.cascadeToolStripMenuItem.Text = "&Cascade";
			this.cascadeToolStripMenuItem.Click += new EventHandler(this.CascadeToolStripMenuItem_Click);
			this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
			this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
			this.tileVerticalToolStripMenuItem.Click += new EventHandler(this.TileVerticalToolStripMenuItem_Click);
			this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
			this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
			this.tileHorizontalToolStripMenuItem.Click += new EventHandler(this.TileHorizontalToolStripMenuItem_Click);
			this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
			this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.closeAllToolStripMenuItem.Text = "C&lose All";
			this.closeAllToolStripMenuItem.Click += new EventHandler(this.CloseAllToolStripMenuItem_Click);
			this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
			this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
			this.arrangeIconsToolStripMenuItem.Click += new EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
			ToolStripItemCollection toolStripItemCollections2 = this.helpMenu.DropDownItems;
			toolStripItemArray = new ToolStripItem[] { this.contentsToolStripMenuItem, this.indexToolStripMenuItem, this.searchToolStripMenuItem, this.toolStripSeparator8, this.aboutToolStripMenuItem };
			toolStripItemCollections2.AddRange(toolStripItemArray);
			this.helpMenu.Name = "helpMenu";
			this.helpMenu.Size = new System.Drawing.Size(44, 20);
			this.helpMenu.Text = "&Help";
			this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
			this.contentsToolStripMenuItem.ShortcutKeys = Keys.ShiftKey | Keys.Space | Keys.D0 | Keys.P | Keys.NumPad0 | Keys.F1 | Keys.Control;
			this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.contentsToolStripMenuItem.Text = "&Contents";
			this.indexToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("indexToolStripMenuItem.Image");
			this.indexToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
			this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.indexToolStripMenuItem.Text = "&Index";
			this.searchToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("searchToolStripMenuItem.Image");
			this.searchToolStripMenuItem.ImageTransparentColor = Color.Black;
			this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
			this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.searchToolStripMenuItem.Text = "&Search";
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.aboutToolStripMenuItem.Text = "&About ... ...";
			ToolStripItemCollection items1 = this.toolStrip.Items;
			toolStripItemArray = new ToolStripItem[] { this.newToolStripButton, this.openToolStripButton, this.saveToolStripButton, this.toolStripSeparator1, this.printToolStripButton, this.printPreviewToolStripButton, this.toolStripSeparator2, this.helpToolStripButton };
			items1.AddRange(toolStripItemArray);
			this.toolStrip.Location = new Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(632, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.Text = "ToolStrip";
			this.toolStrip.Visible = false;
			this.newToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.newToolStripButton.Image = (Image)componentResourceManager.GetObject("newToolStripButton.Image");
			this.newToolStripButton.ImageTransparentColor = Color.Black;
			this.newToolStripButton.Name = "newToolStripButton";
			this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.newToolStripButton.Text = "New";
			this.newToolStripButton.Click += new EventHandler(this.ShowNewForm);
			this.openToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.openToolStripButton.Image = (Image)componentResourceManager.GetObject("openToolStripButton.Image");
			this.openToolStripButton.ImageTransparentColor = Color.Black;
			this.openToolStripButton.Name = "openToolStripButton";
			this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.openToolStripButton.Text = "Open";
			this.openToolStripButton.Click += new EventHandler(this.OpenFile);
			this.saveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.saveToolStripButton.Image = (Image)componentResourceManager.GetObject("saveToolStripButton.Image");
			this.saveToolStripButton.ImageTransparentColor = Color.Black;
			this.saveToolStripButton.Name = "saveToolStripButton";
			this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.saveToolStripButton.Text = "Save";
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			this.printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.printToolStripButton.Image = (Image)componentResourceManager.GetObject("printToolStripButton.Image");
			this.printToolStripButton.ImageTransparentColor = Color.Black;
			this.printToolStripButton.Name = "printToolStripButton";
			this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printToolStripButton.Text = "Print";
			this.printPreviewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.printPreviewToolStripButton.Image = (Image)componentResourceManager.GetObject("printPreviewToolStripButton.Image");
			this.printPreviewToolStripButton.ImageTransparentColor = Color.Black;
			this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
			this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.printPreviewToolStripButton.Text = "Print Preview";
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			this.helpToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = (Image)componentResourceManager.GetObject("helpToolStripButton.Image");
			this.helpToolStripButton.ImageTransparentColor = Color.Black;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "Help";
			ToolStripItemCollection items2 = this.statusStrip.Items;
			toolStripItemArray = new ToolStripItem[] { this.toolStripStatusLabel };
			items2.AddRange(toolStripItemArray);
			this.statusStrip.Location = new Point(0, 431);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(632, 22);
			this.statusStrip.TabIndex = 2;
			this.statusStrip.Text = "StatusStrip";
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
			this.toolStripStatusLabel.Text = "Status";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(632, 453);
			base.Controls.Add(this.statusStrip);
			base.Controls.Add(this.toolStrip);
			base.Controls.Add(this.menuStrip);
			base.IsMdiContainer = true;
			base.MainMenuStrip = this.menuStrip;
			base.Name = "MDIParent1";
			this.Text = "Saarthak";
			base.WindowState = FormWindowState.Maximized;
			base.Load += new EventHandler(this.MDIParent1_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void MDIParent1_Load(object sender, EventArgs e)
		{
		}

		private void OpenFile(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
			};
			if (openFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				string fileName = openFileDialog.FileName;
			}
		}

		private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog()
			{
				InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
			};
			if (saveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
			{
				string fileName = saveFileDialog.FileName;
			}
		}

		private void ShowNewForm(object sender, EventArgs e)
		{
			Form form = new Form()
			{
				MdiParent = this
			};
			MDIParent1 mDIParent1 = this;
			int num = mDIParent1.childFormNumber;
			int num1 = num;
			mDIParent1.childFormNumber = num + 1;
			form.Text = string.Concat("Window ", num1);
			form.Show();
		}

		private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.statusStrip.Visible = this.statusBarToolStripMenuItem.Checked;
		}

		private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.TileHorizontal);
		}

		private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			base.LayoutMdi(MdiLayout.TileVertical);
		}

		private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.toolStrip.Visible = this.toolBarToolStripMenuItem.Checked;
		}
	}
}