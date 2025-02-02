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
			this.toolStripMenuItemTopmost = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowControls = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMeniItemShowConsole = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemShowDate = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemShowWeekday = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemChooseFont = new System.Windows.Forms.ToolStripMenuItem();
			this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItemForegroundColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemAlarms = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripMenuItemLoadOnWindowsStartUp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.checkBoxShowDate = new System.Windows.Forms.CheckBox();
			this.checkBoxShowWeekday = new System.Windows.Forms.CheckBox();
			this.buttonHideControls = new System.Windows.Forms.Button();
			this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.colorDialog = new System.Windows.Forms.ColorDialog();
			this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.ContextMenuStrip = this.contextMenuStrip;
			this.labelTime.Font = new System.Drawing.Font("Arial Narrow", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTime.Location = new System.Drawing.Point(12, 9);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(101, 52);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "Time";
			this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelTime.DoubleClick += new System.EventHandler(this.labelTime_DoubleClick);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemTopmost,
            this.toolStripMenuItemShowControls,
            this.toolStripMeniItemShowConsole,
            this.toolStripSeparator4,
            this.toolStripMenuItemShowDate,
            this.toolStripMenuItemShowWeekday,
            this.toolStripSeparator5,
            this.toolStripMenuItemChooseFont,
            this.colorsToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItemAlarms,
            this.toolStripSeparator3,
            this.toolStripMenuItemLoadOnWindowsStartUp,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(214, 254);
			// 
			// toolStripMenuItemTopmost
			// 
			this.toolStripMenuItemTopmost.CheckOnClick = true;
			this.toolStripMenuItemTopmost.Name = "toolStripMenuItemTopmost";
			this.toolStripMenuItemTopmost.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemTopmost.Text = "Topmost";
			this.toolStripMenuItemTopmost.CheckedChanged += new System.EventHandler(this.toolStripMenuITemTopmost_CheckedChanged);
			// 
			// toolStripMenuItemShowControls
			// 
			this.toolStripMenuItemShowControls.Checked = true;
			this.toolStripMenuItemShowControls.CheckOnClick = true;
			this.toolStripMenuItemShowControls.CheckState = System.Windows.Forms.CheckState.Checked;
			this.toolStripMenuItemShowControls.Name = "toolStripMenuItemShowControls";
			this.toolStripMenuItemShowControls.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemShowControls.Text = "Show controls";
			this.toolStripMenuItemShowControls.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowControls_CheckedChanged);
			// 
			// toolStripMeniItemShowConsole
			// 
			this.toolStripMeniItemShowConsole.CheckOnClick = true;
			this.toolStripMeniItemShowConsole.Name = "toolStripMeniItemShowConsole";
			this.toolStripMeniItemShowConsole.Size = new System.Drawing.Size(213, 22);
			this.toolStripMeniItemShowConsole.Text = "Show console";
			this.toolStripMeniItemShowConsole.CheckedChanged += new System.EventHandler(this.toolStripMeniItemShowConsole_CheckedChanged);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(210, 6);
			// 
			// toolStripMenuItemShowDate
			// 
			this.toolStripMenuItemShowDate.CheckOnClick = true;
			this.toolStripMenuItemShowDate.Name = "toolStripMenuItemShowDate";
			this.toolStripMenuItemShowDate.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemShowDate.Text = "Show date";
			this.toolStripMenuItemShowDate.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowDate_CheckedChanged);
			// 
			// toolStripMenuItemShowWeekday
			// 
			this.toolStripMenuItemShowWeekday.CheckOnClick = true;
			this.toolStripMenuItemShowWeekday.Name = "toolStripMenuItemShowWeekday";
			this.toolStripMenuItemShowWeekday.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemShowWeekday.Text = "Show weekday";
			this.toolStripMenuItemShowWeekday.CheckedChanged += new System.EventHandler(this.toolStripMenuItemShowWeekday_CheckedChanged);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(210, 6);
			// 
			// toolStripMenuItemChooseFont
			// 
			this.toolStripMenuItemChooseFont.Name = "toolStripMenuItemChooseFont";
			this.toolStripMenuItemChooseFont.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemChooseFont.Text = "Choose font";
			this.toolStripMenuItemChooseFont.Click += new System.EventHandler(this.toolStripMenuItemChooseFont_Click);
			// 
			// colorsToolStripMenuItem
			// 
			this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemBackgroundColor,
            this.toolStripMenuItemForegroundColor});
			this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
			this.colorsToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.colorsToolStripMenuItem.Text = "Colors";
			// 
			// toolStripMenuItemBackgroundColor
			// 
			this.toolStripMenuItemBackgroundColor.Name = "toolStripMenuItemBackgroundColor";
			this.toolStripMenuItemBackgroundColor.Size = new System.Drawing.Size(168, 22);
			this.toolStripMenuItemBackgroundColor.Text = "Background color";
			this.toolStripMenuItemBackgroundColor.ToolTipText = "Choose a color for timer background. Don\'t change color of programm itself.\r\n";
			this.toolStripMenuItemBackgroundColor.Click += new System.EventHandler(this.toolStripMenuItemBackgroundColor_Click);
			// 
			// toolStripMenuItemForegroundColor
			// 
			this.toolStripMenuItemForegroundColor.Name = "toolStripMenuItemForegroundColor";
			this.toolStripMenuItemForegroundColor.Size = new System.Drawing.Size(168, 22);
			this.toolStripMenuItemForegroundColor.Text = "Foreground color";
			this.toolStripMenuItemForegroundColor.Click += new System.EventHandler(this.toolStripMenuItemForegroundColor_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(210, 6);
			// 
			// toolStripMenuItemAlarms
			// 
			this.toolStripMenuItemAlarms.Name = "toolStripMenuItemAlarms";
			this.toolStripMenuItemAlarms.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemAlarms.Text = "Alarms";
			this.toolStripMenuItemAlarms.Click += new System.EventHandler(this.ToolStripMenuItemAlarms_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(210, 6);
			// 
			// toolStripMenuItemLoadOnWindowsStartUp
			// 
			this.toolStripMenuItemLoadOnWindowsStartUp.CheckOnClick = true;
			this.toolStripMenuItemLoadOnWindowsStartUp.Name = "toolStripMenuItemLoadOnWindowsStartUp";
			this.toolStripMenuItemLoadOnWindowsStartUp.Size = new System.Drawing.Size(213, 22);
			this.toolStripMenuItemLoadOnWindowsStartUp.Text = "Load on Windows Start up";
			this.toolStripMenuItemLoadOnWindowsStartUp.CheckedChanged += new System.EventHandler(this.toolStripMenuItemLoadOnWindowsStartUp_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(210, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
			this.checkBoxShowDate.Location = new System.Drawing.Point(19, 214);
			this.checkBoxShowDate.Name = "checkBoxShowDate";
			this.checkBoxShowDate.Size = new System.Drawing.Size(132, 29);
			this.checkBoxShowDate.TabIndex = 1;
			this.checkBoxShowDate.Text = "Show date";
			this.checkBoxShowDate.UseVisualStyleBackColor = true;
			this.checkBoxShowDate.CheckedChanged += new System.EventHandler(this.checkBoxShowDate_CheckedChanged);
			// 
			// checkBoxShowWeekday
			// 
			this.checkBoxShowWeekday.AutoSize = true;
			this.checkBoxShowWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.checkBoxShowWeekday.Location = new System.Drawing.Point(19, 245);
			this.checkBoxShowWeekday.Name = "checkBoxShowWeekday";
			this.checkBoxShowWeekday.Size = new System.Drawing.Size(175, 29);
			this.checkBoxShowWeekday.TabIndex = 2;
			this.checkBoxShowWeekday.Text = "Show weekday";
			this.checkBoxShowWeekday.UseVisualStyleBackColor = true;
			this.checkBoxShowWeekday.CheckedChanged += new System.EventHandler(this.checkBoxShowWeekday_CheckedChanged);
			// 
			// buttonHideControls
			// 
			this.buttonHideControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonHideControls.Location = new System.Drawing.Point(10, 275);
			this.buttonHideControls.Name = "buttonHideControls";
			this.buttonHideControls.Size = new System.Drawing.Size(274, 53);
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
			this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
			// 
			// axWindowsMediaPlayer1
			// 
			this.axWindowsMediaPlayer1.Enabled = true;
			this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(13, 346);
			this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
			this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
			this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(271, 48);
			this.axWindowsMediaPlayer1.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(294, 415);
			this.Controls.Add(this.axWindowsMediaPlayer1);
			this.Controls.Add(this.buttonHideControls);
			this.Controls.Add(this.checkBoxShowWeekday);
			this.Controls.Add(this.checkBoxShowDate);
			this.Controls.Add(this.labelTime);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Clock VPD_311";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
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
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemTopmost;
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
		private System.Windows.Forms.ColorDialog colorDialog;
		private System.Windows.Forms.ToolStripMenuItem toolStripMeniItemShowConsole;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAlarms;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
	}
}

