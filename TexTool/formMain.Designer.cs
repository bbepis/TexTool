namespace TexTool
{
	partial class formMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.imgTexture = new System.Windows.Forms.PictureBox();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbFormat = new System.Windows.Forms.ComboBox();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.jPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dDSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.chkConvert = new System.Windows.Forms.CheckBox();
			this.numX = new System.Windows.Forms.NumericUpDown();
			this.numY = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgTexture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(880, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.numY);
			this.panel1.Controls.Add(this.numX);
			this.panel1.Controls.Add(this.chkConvert);
			this.panel1.Controls.Add(this.cmbFormat);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.txtPath);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 442);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(880, 58);
			this.panel1.TabIndex = 1;
			// 
			// imgTexture
			// 
			this.imgTexture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
			this.imgTexture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.imgTexture.Location = new System.Drawing.Point(0, 24);
			this.imgTexture.Name = "imgTexture";
			this.imgTexture.Size = new System.Drawing.Size(880, 418);
			this.imgTexture.TabIndex = 2;
			this.imgTexture.TabStop = false;
			this.imgTexture.Resize += new System.EventHandler(this.imgTexture_Resize);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.openToolStripMenuItem.Text = "Open...";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Internal path:";
			// 
			// txtPath
			// 
			this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPath.Enabled = false;
			this.txtPath.Location = new System.Drawing.Point(83, 6);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(584, 20);
			this.txtPath.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(673, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Format:";
			// 
			// cmbFormat
			// 
			this.cmbFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbFormat.Enabled = false;
			this.cmbFormat.FormattingEnabled = true;
			this.cmbFormat.Items.AddRange(new object[] {
            "ARGB32 (PNG)",
            "RGB24 (JPEG)",
            "DXT1 (DDS)",
            "DXT5 (DDS)"});
			this.cmbFormat.Location = new System.Drawing.Point(721, 6);
			this.cmbFormat.Name = "cmbFormat";
			this.cmbFormat.Size = new System.Drawing.Size(147, 21);
			this.cmbFormat.TabIndex = 3;
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Enabled = false;
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Enabled = false;
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.toolStripSeparator2,
            this.batchToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pNGToolStripMenuItem,
            this.jPGToolStripMenuItem,
            this.dDSToolStripMenuItem});
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportToolStripMenuItem.Text = "Export";
			// 
			// pNGToolStripMenuItem
			// 
			this.pNGToolStripMenuItem.Enabled = false;
			this.pNGToolStripMenuItem.Name = "pNGToolStripMenuItem";
			this.pNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.pNGToolStripMenuItem.Text = "PNG";
			this.pNGToolStripMenuItem.Click += new System.EventHandler(this.pNGToolStripMenuItem_Click);
			// 
			// jPGToolStripMenuItem
			// 
			this.jPGToolStripMenuItem.Enabled = false;
			this.jPGToolStripMenuItem.Name = "jPGToolStripMenuItem";
			this.jPGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.jPGToolStripMenuItem.Text = "JPG";
			this.jPGToolStripMenuItem.Click += new System.EventHandler(this.jPGToolStripMenuItem_Click);
			// 
			// dDSToolStripMenuItem
			// 
			this.dDSToolStripMenuItem.Enabled = false;
			this.dDSToolStripMenuItem.Name = "dDSToolStripMenuItem";
			this.dDSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.dDSToolStripMenuItem.Text = "DDS";
			this.dDSToolStripMenuItem.Click += new System.EventHandler(this.dDSToolStripMenuItem_Click);
			// 
			// importToolStripMenuItem
			// 
			this.importToolStripMenuItem.Name = "importToolStripMenuItem";
			this.importToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.importToolStripMenuItem.Text = "Import";
			this.importToolStripMenuItem.Click += new System.EventHandler(this.importToolStripMenuItem_Click);
			// 
			// chkConvert
			// 
			this.chkConvert.AutoSize = true;
			this.chkConvert.Checked = true;
			this.chkConvert.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkConvert.Location = new System.Drawing.Point(721, 33);
			this.chkConvert.Name = "chkConvert";
			this.chkConvert.Size = new System.Drawing.Size(142, 17);
			this.chkConvert.TabIndex = 4;
			this.chkConvert.Text = "Convert format on save?";
			this.chkConvert.UseVisualStyleBackColor = true;
			// 
			// numX
			// 
			this.numX.Enabled = false;
			this.numX.Location = new System.Drawing.Point(83, 30);
			this.numX.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
			this.numX.Name = "numX";
			this.numX.Size = new System.Drawing.Size(106, 20);
			this.numX.TabIndex = 5;
			// 
			// numY
			// 
			this.numY.Enabled = false;
			this.numY.Location = new System.Drawing.Point(213, 30);
			this.numY.Maximum = new decimal(new int[] {
            1048576,
            0,
            0,
            0});
			this.numY.Name = "numY";
			this.numY.Size = new System.Drawing.Size(106, 20);
			this.numY.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Texture size:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(195, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(12, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "x";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// batchToolStripMenuItem
			// 
			this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem1,
            this.exportToolStripMenuItem1});
			this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
			this.batchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.batchToolStripMenuItem.Text = "Batch";
			// 
			// importToolStripMenuItem1
			// 
			this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
			this.importToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.importToolStripMenuItem1.Text = "Import (to .tex)";
			this.importToolStripMenuItem1.Click += new System.EventHandler(this.importToolStripMenuItem1_Click);
			// 
			// exportToolStripMenuItem1
			// 
			this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
			this.exportToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.exportToolStripMenuItem1.Text = "Export (from .tex)";
			this.exportToolStripMenuItem1.Click += new System.EventHandler(this.exportToolStripMenuItem1_Click);
			// 
			// formMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(880, 500);
			this.Controls.Add(this.imgTexture);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "formMain";
			this.Text = "TexTool";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imgTexture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox imgTexture;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ComboBox cmbFormat;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pNGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem jPGToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dDSToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
		private System.Windows.Forms.CheckBox chkConvert;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numY;
		private System.Windows.Forms.NumericUpDown numX;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem1;
	}
}