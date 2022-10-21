namespace MTextEditor
{
	partial class FEditor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEditor));
			this.TSTopToolStrip = new System.Windows.Forms.ToolStrip();
			this.TSNew = new System.Windows.Forms.ToolStripButton();
			this.TSOpen = new System.Windows.Forms.ToolStripButton();
			this.TSSave = new System.Windows.Forms.ToolStripButton();
			this.TSSaveAs = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.TSBold = new System.Windows.Forms.ToolStripButton();
			this.TSUnderline = new System.Windows.Forms.ToolStripButton();
			this.TSItalics = new System.Windows.Forms.ToolStripButton();
			this.TSFontSize = new System.Windows.Forms.ToolStripComboBox();
			this.TSAbout = new System.Windows.Forms.ToolStripButton();
			this.LLoggedInUser = new System.Windows.Forms.ToolStripLabel();
			this.TSLeftToolStrip = new System.Windows.Forms.ToolStrip();
			this.TSCut = new System.Windows.Forms.ToolStripButton();
			this.TSCopy = new System.Windows.Forms.ToolStripButton();
			this.TSPaste = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.TSCompile = new System.Windows.Forms.ToolStripButton();
			this.RTextArea = new System.Windows.Forms.RichTextBox();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MSNew = new System.Windows.Forms.ToolStripMenuItem();
			this.MSOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.MSSave = new System.Windows.Forms.ToolStripMenuItem();
			this.MSSaveAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.MSLogout = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MSCut = new System.Windows.Forms.ToolStripMenuItem();
			this.MSCopy = new System.Windows.Forms.ToolStripMenuItem();
			this.MSPaste = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MSAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.MSMenuStrip = new System.Windows.Forms.MenuStrip();
			this.TSTopToolStrip.SuspendLayout();
			this.TSLeftToolStrip.SuspendLayout();
			this.MSMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// TSTopToolStrip
			// 
			this.TSTopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSNew,
            this.TSOpen,
            this.TSSave,
            this.TSSaveAs,
            this.toolStripSeparator3,
            this.TSBold,
            this.TSUnderline,
            this.TSItalics,
            this.TSFontSize,
            this.TSAbout,
            this.LLoggedInUser});
			this.TSTopToolStrip.Location = new System.Drawing.Point(0, 24);
			this.TSTopToolStrip.Name = "TSTopToolStrip";
			this.TSTopToolStrip.Size = new System.Drawing.Size(1264, 25);
			this.TSTopToolStrip.TabIndex = 1;
			this.TSTopToolStrip.Text = "toolStrip1";
			// 
			// TSNew
			// 
			this.TSNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSNew.Image = ((System.Drawing.Image)(resources.GetObject("TSNew.Image")));
			this.TSNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSNew.Name = "TSNew";
			this.TSNew.Size = new System.Drawing.Size(23, 22);
			this.TSNew.Text = "New";
			this.TSNew.Click += new System.EventHandler(this.Tools_New);
			// 
			// TSOpen
			// 
			this.TSOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSOpen.Image = ((System.Drawing.Image)(resources.GetObject("TSOpen.Image")));
			this.TSOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSOpen.Name = "TSOpen";
			this.TSOpen.Size = new System.Drawing.Size(23, 22);
			this.TSOpen.Text = "Open";
			this.TSOpen.Click += new System.EventHandler(this.Tools_Open);
			// 
			// TSSave
			// 
			this.TSSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSSave.Image = ((System.Drawing.Image)(resources.GetObject("TSSave.Image")));
			this.TSSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSSave.Name = "TSSave";
			this.TSSave.Size = new System.Drawing.Size(23, 22);
			this.TSSave.Text = "Save";
			this.TSSave.Click += new System.EventHandler(this.Tools_Save);
			// 
			// TSSaveAs
			// 
			this.TSSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("TSSaveAs.Image")));
			this.TSSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSSaveAs.Name = "TSSaveAs";
			this.TSSaveAs.Size = new System.Drawing.Size(23, 22);
			this.TSSaveAs.Text = "Save As";
			this.TSSaveAs.Click += new System.EventHandler(this.Tools_SaveAs);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// TSBold
			// 
			this.TSBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSBold.Image = ((System.Drawing.Image)(resources.GetObject("TSBold.Image")));
			this.TSBold.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBold.Name = "TSBold";
			this.TSBold.Size = new System.Drawing.Size(23, 22);
			this.TSBold.Text = "Bold";
			this.TSBold.Click += new System.EventHandler(this.Tools_Bold);
			// 
			// TSUnderline
			// 
			this.TSUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSUnderline.Image = ((System.Drawing.Image)(resources.GetObject("TSUnderline.Image")));
			this.TSUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSUnderline.Name = "TSUnderline";
			this.TSUnderline.Size = new System.Drawing.Size(23, 22);
			this.TSUnderline.Text = "Underline";
			this.TSUnderline.Click += new System.EventHandler(this.Tools_Underline);
			// 
			// TSItalics
			// 
			this.TSItalics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSItalics.Image = ((System.Drawing.Image)(resources.GetObject("TSItalics.Image")));
			this.TSItalics.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSItalics.Name = "TSItalics";
			this.TSItalics.Size = new System.Drawing.Size(23, 22);
			this.TSItalics.Text = "Italics";
			this.TSItalics.Click += new System.EventHandler(this.Tools_Italics);
			// 
			// TSFontSize
			// 
			this.TSFontSize.Name = "TSFontSize";
			this.TSFontSize.Size = new System.Drawing.Size(121, 25);
			this.TSFontSize.Leave += new System.EventHandler(this.Tools_FontSize_LeftFocus);
			this.TSFontSize.TextChanged += new System.EventHandler(this.Tools_FontSize);
			// 
			// TSAbout
			// 
			this.TSAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSAbout.Image = ((System.Drawing.Image)(resources.GetObject("TSAbout.Image")));
			this.TSAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSAbout.Name = "TSAbout";
			this.TSAbout.Size = new System.Drawing.Size(23, 22);
			this.TSAbout.Text = "About";
			this.TSAbout.ToolTipText = "About";
			this.TSAbout.Click += new System.EventHandler(this.Tools_About);
			// 
			// LLoggedInUser
			// 
			this.LLoggedInUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.LLoggedInUser.Name = "LLoggedInUser";
			this.LLoggedInUser.Size = new System.Drawing.Size(131, 22);
			this.LLoggedInUser.Text = "## LOGGED IN USER ##";
			// 
			// TSLeftToolStrip
			// 
			this.TSLeftToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
			this.TSLeftToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSCut,
            this.TSCopy,
            this.TSPaste,
            this.toolStripSeparator4,
            this.TSCompile});
			this.TSLeftToolStrip.Location = new System.Drawing.Point(0, 49);
			this.TSLeftToolStrip.Name = "TSLeftToolStrip";
			this.TSLeftToolStrip.Size = new System.Drawing.Size(24, 632);
			this.TSLeftToolStrip.TabIndex = 2;
			this.TSLeftToolStrip.Text = "toolStrip1";
			// 
			// TSCut
			// 
			this.TSCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSCut.Image = ((System.Drawing.Image)(resources.GetObject("TSCut.Image")));
			this.TSCut.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSCut.Name = "TSCut";
			this.TSCut.Size = new System.Drawing.Size(21, 20);
			this.TSCut.Text = "Cut";
			this.TSCut.Click += new System.EventHandler(this.Tools_Cut);
			// 
			// TSCopy
			// 
			this.TSCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSCopy.Image = ((System.Drawing.Image)(resources.GetObject("TSCopy.Image")));
			this.TSCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSCopy.Name = "TSCopy";
			this.TSCopy.Size = new System.Drawing.Size(21, 20);
			this.TSCopy.Text = "Copy";
			this.TSCopy.Click += new System.EventHandler(this.Tools_Copy);
			// 
			// TSPaste
			// 
			this.TSPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSPaste.Image = ((System.Drawing.Image)(resources.GetObject("TSPaste.Image")));
			this.TSPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSPaste.Name = "TSPaste";
			this.TSPaste.Size = new System.Drawing.Size(21, 20);
			this.TSPaste.Text = "Paste";
			this.TSPaste.Click += new System.EventHandler(this.Tools_Paste);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(21, 6);
			// 
			// TSCompile
			// 
			this.TSCompile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.TSCompile.Image = ((System.Drawing.Image)(resources.GetObject("TSCompile.Image")));
			this.TSCompile.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSCompile.Name = "TSCompile";
			this.TSCompile.Size = new System.Drawing.Size(21, 20);
			this.TSCompile.Text = "Compile C# Source";
			this.TSCompile.Click += new System.EventHandler(this.Tools_Compile);
			// 
			// RTextArea
			// 
			this.RTextArea.AcceptsTab = true;
			this.RTextArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.RTextArea.Location = new System.Drawing.Point(27, 52);
			this.RTextArea.Name = "RTextArea";
			this.RTextArea.Size = new System.Drawing.Size(1225, 617);
			this.RTextArea.TabIndex = 8;
			this.RTextArea.Text = "";
			this.RTextArea.TextChanged += new System.EventHandler(this.RTextChanged);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSNew,
            this.MSOpen,
            this.toolStripSeparator1,
            this.MSSave,
            this.MSSaveAs,
            this.toolStripSeparator2,
            this.MSLogout});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// MSNew
			// 
			this.MSNew.Image = ((System.Drawing.Image)(resources.GetObject("MSNew.Image")));
			this.MSNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSNew.Name = "MSNew";
			this.MSNew.ShortcutKeyDisplayString = "";
			this.MSNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.MSNew.Size = new System.Drawing.Size(202, 38);
			this.MSNew.Text = "New";
			this.MSNew.Click += new System.EventHandler(this.Tools_New);
			// 
			// MSOpen
			// 
			this.MSOpen.Image = ((System.Drawing.Image)(resources.GetObject("MSOpen.Image")));
			this.MSOpen.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSOpen.Name = "MSOpen";
			this.MSOpen.ShortcutKeyDisplayString = "";
			this.MSOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.MSOpen.Size = new System.Drawing.Size(202, 38);
			this.MSOpen.Text = "Open";
			this.MSOpen.Click += new System.EventHandler(this.Tools_Open);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
			// 
			// MSSave
			// 
			this.MSSave.Image = ((System.Drawing.Image)(resources.GetObject("MSSave.Image")));
			this.MSSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSSave.Name = "MSSave";
			this.MSSave.ShortcutKeyDisplayString = "";
			this.MSSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.MSSave.Size = new System.Drawing.Size(202, 38);
			this.MSSave.Text = "Save";
			this.MSSave.Click += new System.EventHandler(this.Tools_Save);
			// 
			// MSSaveAs
			// 
			this.MSSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("MSSaveAs.Image")));
			this.MSSaveAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSSaveAs.Name = "MSSaveAs";
			this.MSSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.MSSaveAs.Size = new System.Drawing.Size(202, 38);
			this.MSSaveAs.Text = "Save As";
			this.MSSaveAs.Click += new System.EventHandler(this.Tools_SaveAs);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(199, 6);
			// 
			// MSLogout
			// 
			this.MSLogout.Image = ((System.Drawing.Image)(resources.GetObject("MSLogout.Image")));
			this.MSLogout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSLogout.Name = "MSLogout";
			this.MSLogout.Size = new System.Drawing.Size(202, 38);
			this.MSLogout.Text = "Logout";
			this.MSLogout.Click += new System.EventHandler(this.Tools_Logout);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSCut,
            this.MSCopy,
            this.MSPaste});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// MSCut
			// 
			this.MSCut.Image = ((System.Drawing.Image)(resources.GetObject("MSCut.Image")));
			this.MSCut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSCut.Name = "MSCut";
			this.MSCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
			this.MSCut.Size = new System.Drawing.Size(160, 38);
			this.MSCut.Text = "Cut";
			this.MSCut.Click += new System.EventHandler(this.Tools_Cut);
			// 
			// MSCopy
			// 
			this.MSCopy.Image = ((System.Drawing.Image)(resources.GetObject("MSCopy.Image")));
			this.MSCopy.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSCopy.Name = "MSCopy";
			this.MSCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
			this.MSCopy.Size = new System.Drawing.Size(160, 38);
			this.MSCopy.Text = "Copy";
			this.MSCopy.Click += new System.EventHandler(this.Tools_Copy);
			// 
			// MSPaste
			// 
			this.MSPaste.Image = ((System.Drawing.Image)(resources.GetObject("MSPaste.Image")));
			this.MSPaste.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSPaste.Name = "MSPaste";
			this.MSPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
			this.MSPaste.Size = new System.Drawing.Size(160, 38);
			this.MSPaste.Text = "Paste";
			this.MSPaste.Click += new System.EventHandler(this.Tools_Paste);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSAbout});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// MSAbout
			// 
			this.MSAbout.Image = ((System.Drawing.Image)(resources.GetObject("MSAbout.Image")));
			this.MSAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
			this.MSAbout.Name = "MSAbout";
			this.MSAbout.Size = new System.Drawing.Size(132, 38);
			this.MSAbout.Text = "About...";
			this.MSAbout.Click += new System.EventHandler(this.Tools_About);
			// 
			// MSMenuStrip
			// 
			this.MSMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.MSMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MSMenuStrip.Name = "MSMenuStrip";
			this.MSMenuStrip.Size = new System.Drawing.Size(1264, 24);
			this.MSMenuStrip.TabIndex = 0;
			this.MSMenuStrip.Text = "menuStrip1";
			// 
			// FEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.RTextArea);
			this.Controls.Add(this.TSLeftToolStrip);
			this.Controls.Add(this.TSTopToolStrip);
			this.Controls.Add(this.MSMenuStrip);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.MSMenuStrip;
			this.Name = "FEditor";
			this.Text = "Text Editor";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FEditor_Closing);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FEditor_FormClosed);
			this.Load += new System.EventHandler(this.Start);
			this.TSTopToolStrip.ResumeLayout(false);
			this.TSTopToolStrip.PerformLayout();
			this.TSLeftToolStrip.ResumeLayout(false);
			this.TSLeftToolStrip.PerformLayout();
			this.MSMenuStrip.ResumeLayout(false);
			this.MSMenuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ToolStrip TSTopToolStrip;
		private ToolStripButton TSNew;
		private ToolStripButton TSOpen;
		private ToolStripButton TSSave;
		private ToolStripButton TSSaveAs;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripButton TSBold;
		private ToolStripButton TSUnderline;
		private ToolStripButton TSItalics;
		private ToolStrip TSLeftToolStrip;
		private ToolStripButton TSCut;
		private ToolStripButton TSCopy;
		private ToolStripButton TSPaste;
		private ToolStripComboBox TSFontSize;
		private ToolStripLabel LLoggedInUser;
		private RichTextBox RTextArea;
		private ToolStripButton TSAbout;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem MSNew;
		private ToolStripMenuItem MSOpen;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem MSSave;
		private ToolStripMenuItem MSSaveAs;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem MSLogout;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem MSCut;
		private ToolStripMenuItem MSCopy;
		private ToolStripMenuItem MSPaste;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ToolStripMenuItem MSAbout;
		private MenuStrip MSMenuStrip;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton TSCompile;
	}
}