namespace Clock
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.labelTime = new System.Windows.Forms.Label();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuITemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.moscowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.theCaptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemLoadOnWindowsStartUp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.Location = new System.Drawing.Point(12, 9);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(126, 64);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuITemTopmost,
            this.toolStripMenuItemShowControls,
            this.toolStripSeparator4,
            this.toolStripMenuItemShowDate,
            this.toolStripMenuItemShowWeekday,
            this.toolStripSeparator5,
            this.toolStripMenuItemChooseFont,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemLoadOnWindowsStartUp,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(254, 264);
			// 
			// toolStripMenuITemTopmost
			// 
			this.toolStripMenuITemTopmost.CheckOnClick = true;
			this.toolStripMenuITemTopmost.Name = "toolStripMenuITemTopmost";
			this.toolStripMenuITemTopmost.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuITemTopmost.Text = "Topmost";
			this.toolStripMenuITemTopmost.CheckedChanged += new System.EventHandler(this.toolStripMenuITemTopmost_CheckedChanged);
			// 
			// toolStripMenuItemShowControls
			// 
			this.toolStripMenuItemShowControls.Checked = true;
			this.toolStripMenuItemShowControls.CheckOnClick = true;
			this.toolStripMenuItemShowControls.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemShowControls.Name = "toolStripMenuItemShowControls";
			this.toolStripMenuItemShowControls.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuItemShowControls.Text = "Show controls";
			this.toolStripMenuItemShowControls.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowControls_CheckedChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(250, 6);
			// 
			// toolStripMenuItemShowDate
			// 
			this.toolStripMenuItemShowDate.CheckOnClick = true;
			this.toolStripMenuItemShowDate.Name = "toolStripMenuItemShowDate";
			this.toolStripMenuItemShowDate.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuItemShowDate.Text = "Show date";
			this.toolStripMenuItemShowDate.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemShowDate_CheckStateChanged);
			// 
			// toolStripMenuItemShowWeekday
			// 
			this.toolStripMenuItemShowWeekday.CheckOnClick = true;
			this.toolStripMenuItemShowWeekday.Name = "toolStripMenuItemShowWeekday";
			this.toolStripMenuItemShowWeekday.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuItemShowWeekday.Text = "Show weekday";
			this.toolStripMenuItemShowWeekday.CheckStateChanged += new System.EventHandler(this.toolStripMenuItemShowWeekday_CheckStateChanged);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(250, 6);
			// 
			// toolStripMenuItemChooseFont
			// 
			this.toolStripMenuItemChooseFont.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moscowToolStripMenuItem,
            this.theCaptToolStripMenuItem});
			this.toolStripMenuItemChooseFont.Name = "toolStripMenuItemChooseFont";
			this.toolStripMenuItemChooseFont.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuItemChooseFont.Text = "Choose font";
			// 
			// moscowToolStripMenuItem
			// 
			this.moscowToolStripMenuItem.Name = "moscowToolStripMenuItem";
			this.moscowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.moscowToolStripMenuItem.Text = "Moscow";
			this.moscowToolStripMenuItem.Click += new System.EventHandler(this.moscowToolStripMenuItem_Click);
			// 
			// theCaptToolStripMenuItem
			// 
			this.theCaptToolStripMenuItem.Name = "theCaptToolStripMenuItem";
			this.theCaptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
			this.theCaptToolStripMenuItem.Text = "The capt";
			// 
			// colorsToolStripMenuItem
			// 
			this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundColor,
            this.toolStripMenuItemForegroundColor});
			this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			this.colorsToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
			this.colorsToolStripMenuItem.Text = "Colors";
			// 
			// toolStripMenuItemBackgroundColor
			// 
			this.toolStripMenuItemBackgroundColor.Name = "toolStripMenuItemBackgroundColor";
			this.toolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(209, 26);
			this.toolStripMenuItemBackgroundColor.Text = "Background color";
			// 
			// toolStripMenuItemForegroundColor
			// 
			this.toolStripMenuItemForegroundColor.Name = "toolStripMenuItemForegroundColor";
			this.toolStripMenuItemForegroundColor.Size = new System.Drawing.Size(209, 26);
			this.toolStripMenuItemForegroundColor.Text = "Foreground color";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(250, 6);
			// 
			// toolStripMenuItemLoadOnWindowsStartUp
			// 
			this.toolStripMenuItemLoadOnWindowsStartUp.CheckOnClick = true;
			this.toolStripMenuItemLoadOnWindowsStartUp.Name = "toolStripMenuItemLoadOnWindowsStartUp";
			this.toolStripMenuItemLoadOnWindowsStartUp.Size = new System.Drawing.Size(253, 26);
			this.toolStripMenuItemLoadOnWindowsStartUp.Text = "Load on Windows Start up";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(250, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// checkBoxShowDate
			// 
			this.checkBoxShowDate.AutoSize = true;
			this.checkBoxShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowDate.Location = new System.Drawing.Point(22, 190);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(164, 35);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			this.checkBoxShowDate.CheckStateChanged += new System.EventHandler(this.checkBoxShowDate_CheckStateChanged);
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(22, 226);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(219, 35);
			this.checkBoxShowWeekday.TabIndex = 2;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			this.checkBoxShowWeekday.CheckStateChanged += new System.EventHandler(this.checkBoxShowWeekday_CheckStateChanged);
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(22, 279);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(175, 53);
			this.buttonHideControls.TabIndex = 3;
			this.buttonHideControls.Text = "Hide controls";
			this.buttonHideControls.UseVisualStyleBackColor = true;
			this.buttonHideControls.Click += new System.EventHandler(this.buttonHideControls_Click);
			// 
			// notifyIcon
			// 
			this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
			this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
			this.notifyIcon.Text = "notifyIcon1";
			this.notifyIcon.Visible = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 431);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.contextMenuStrip.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.CheckBox checkBoxShowDate;
		private System.Windows.Forms.CheckBox checkBoxShowWeekday;
		private System.Windows.Forms.Button buttonHideControls;
		private System.Windows.Forms.NotifyIcon notifyIcon;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuITemTopmost;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowControls;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowDate;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowWeekday;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemChooseFont;
		private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemBackgroundColor;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLoadOnWindowsStartUp;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForegroundColor;
		private System.Windows.Forms.ToolStripMenuItem moscowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem theCaptToolStripMenuItem;
	}
}

