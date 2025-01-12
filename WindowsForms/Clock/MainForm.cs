using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;
using System.Xml.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Clock
{
	public partial class MainForm : Form
	{
		FontDialog fontDialog;
		//const string progName = "Clock";
		//static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WinFormsClock";
		//static string filePath = folderPath + @"\Config.txt";
		public MainForm()
		{
			InitializeComponent();
			toolStripMeniItemShowConsole.Checked = true;
			fontDialog = new FontDialog();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			//SetVisibility(true);
			toolStripMenuItemShowControls.Checked = true;


            Console.WriteLine(Directory.GetCurrentDirectory());
		}

		void SetVisibility(bool visible)
		{
			checkBoxShowDate.Visible = visible;
			checkBoxShowWeekday.Visible = visible;
			buttonHideControls.Visible = visible;
			this.FormBorderStyle = visible ? FormBorderStyle.FixedDialog : FormBorderStyle.None;
			this.ShowInTaskbar = visible;
			this.TransparencyKey = visible ? Color.Empty : this.BackColor;
		}

		//void CreateConfig()
		//{
		//	int FontID = 0;
		//	//if (moscowToolStripMenuItem.Checked == true) FontID = 0;
		//	//else if (theCaptToolStripMenuItem.Checked == true) FontID = 1;
		//	string conf = this.BackColor.R.ToString() + "\n"
		//				+ this.BackColor.G.ToString() + "\n"
		//				+ this.BackColor.B.ToString() + "\n"
		//				+ labelTime.ForeColor.R.ToString() + "\n"
		//				+ labelTime.ForeColor.G.ToString() + "\n"
		//				+ labelTime.ForeColor.B.ToString() + "\n"
		//				+ toolStripMenuITemTopmost.Checked + "\n"
		//				+ toolStripMenuItemShowControls.Checked + "\n"
		//				+ toolStripMenuItemShowDate.Checked + "\n"
		//				+ toolStripMenuItemShowWeekday.Checked + "\n"
		//				//+ moscowToolStripMenuItem.Checked + "\n"
		//				//+ theCaptToolStripMenuItem.Checked + "\n"
		//				+ FontID + "\n";
		//	File.WriteAllText(filePath, conf);
		//}

		//void ReadConfig()
		//{
		//	int FormColorR = Convert.ToInt32(File.ReadAllLines(filePath).First());
		//	int FormColorG = Convert.ToInt32(File.ReadAllLines(filePath).Skip(1).First());
		//	int FormColorB = Convert.ToInt32(File.ReadAllLines(filePath).Skip(2).First());
		//	int labelColorR = Convert.ToInt32(File.ReadAllLines(filePath).Skip(3).First());
		//	int labelColorG = Convert.ToInt32(File.ReadAllLines(filePath).Skip(4).First());
		//	int labelColorB = Convert.ToInt32(File.ReadAllLines(filePath).Skip(5).First());
		//	bool TopmostStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(6).First());
		//	bool ControlsStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(7).First());
		//	bool DateStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(8).First());
		//	bool WeekdayStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(9).First());
		//	//bool FontMoscowStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(10).First());
		//	//bool FontCaptStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(11).First());
		//	//int FontID = Convert.ToInt32(File.ReadAllLines(filePath).Skip(12).First());

		//	this.BackColor = Color.FromArgb(FormColorR, FormColorG, FormColorB);
		//	labelTime.ForeColor = Color.FromArgb(labelColorR, labelColorG, labelColorB);
		//	toolStripMenuITemTopmost.Checked = TopmostStatus;
		//	toolStripMenuItemShowControls.Checked = ControlsStatus;
		//	toolStripMenuItemShowDate.Checked = DateStatus;
		//	toolStripMenuItemShowWeekday.Checked = WeekdayStatus;
		//	//moscowToolStripMenuItem.Checked = FontMoscowStatus;
		//	//theCaptToolStripMenuItem.Checked = FontCaptStatus;
		//	//onLoadFontID = FontID;
		//	//SetFont(userFontCollection, FontID);
		//}

		private void timer_Tick(object sender, EventArgs e)
		{
			//labelTime.Text = DateTime.Now.ToString("hh:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
			labelTime.Text = DateTime.Now.ToString("HH:mm:ss");
			if(checkBoxShowDate.Checked )
			{
				labelTime.Text += $"\n{DateTime.Now.ToString("yyyy.MM.dd")}";
			}
			if (checkBoxShowWeekday.Checked)
			{
				labelTime.Text += $"\n{DateTime.Now.DayOfWeek}";
			}
			notifyIcon.Text = $"{DateTime.Now.ToString("hh:mm tt")}\n{DateTime.Now.ToString("yyyy.MM.dd")}\n{DateTime.Now.DayOfWeek}";
		}

		//////////////////////////////Topmost////////////////////////////////
		private void toolStripMenuITemTopmost_CheckedChanged(object sender, EventArgs e)
		{
			if(toolStripMenuITemTopmost.Checked) TopMost = true;
			else TopMost = false;
		}
		/////////////////////////////////////////////////////////////////////

		//////////////////////////////Show controls//////////////////////////
		private void toolStripMenuItemShowControls_CheckedChanged(object sender, EventArgs e)
		{
			SetVisibility(toolStripMenuItemShowControls.Checked);
		}
		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			toolStripMenuItemShowControls.Checked = false;
		}
		private void labelTime_DoubleClick(object sender, EventArgs e) => toolStripMenuItemShowControls.Checked=true;
		/////////////////////////////////////////////////////////////////////

		//////////////////////////////Show date//////////////////////////////
		private void toolStripMenuItemShowDate_CheckedChanged(object sender, EventArgs e) =>
			checkBoxShowDate.Checked = toolStripMenuItemShowDate.Checked;
		
		private void checkBoxShowDate_CheckedChanged(object sender, EventArgs e) =>
			toolStripMenuItemShowDate.Checked=checkBoxShowDate.Checked;

		/////////////////////////////////////////////////////////////////////

		////////////////////////////Show weekday/////////////////////////////
		private void toolStripMenuItemShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			checkBoxShowWeekday.Checked = toolStripMenuItemShowWeekday.Checked;
		private void checkBoxShowWeekday_CheckedChanged(object sender, EventArgs e) =>
			toolStripMenuItemShowWeekday.Checked=checkBoxShowWeekday.Checked;
		
		/////////////////////////////////////////////////////////////////////

		////////////////////////////Choose font//////////////////////////////
		private void toolStripMenuItemChooseFont_Click(object sender, EventArgs e)
		{
			if(fontDialog.ShowDialog(this)==DialogResult.OK)
			{
				labelTime.Font = fontDialog.Font;
			}
		}
		
		/////////////////////////////////////////////////////////////////////


		//////////////////////////////Colors/////////////////////////////////
		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.BackColor;
			DialogResult result = colorDialog.ShowDialog(this);
			if(result == DialogResult.OK) labelTime.BackColor = colorDialog.Color;
		}

		private void toolStripMenuItemForegroundColor_Click(object sender, EventArgs e)
		{
			colorDialog.Color = labelTime.ForeColor;
			if (colorDialog.ShowDialog(this) == DialogResult.OK) labelTime.ForeColor = colorDialog.Color;
		}

		/////////////////////////////////////////////////////////////////////
		

		/////////////////////////////////////////////////////////////////////
		private void MainForm_Load(object sender, EventArgs e)
		{
			//if(File.Exists(filePath))
			//{
			//	ReadConfig();
			//}
			toolStripMenuItemShowControls.Checked = false;
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			//if(!Directory.Exists(folderPath))
			//{
			//	Directory.CreateDirectory(folderPath);
			//	using (File.Create(filePath)) ; 
			//}
			//else
			//{
			//	if (!File.Exists(filePath)) File.Create(filePath);
			//	else { }
			//}
			//CreateConfig();
		}

		/////////////////////////////////////////////////////////////////////

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void notifyIcon_DoubleClick(object sender, EventArgs e)
		{
			if(!this.TopMost)
			{
				this.TopMost = true;
				this.TopMost = false;
			}
		}

		private void toolStripMeniItemShowConsole_CheckedChanged(object sender, EventArgs e)
		{
			bool show = toolStripMeniItemShowConsole.Checked? AllocConsole(): FreeConsole();
		}
		[DllImport("kernel32.dll")]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		static extern bool FreeConsole();
	}
}
