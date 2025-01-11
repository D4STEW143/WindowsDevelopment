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

namespace Clock
{
	public partial class MainForm : Form
	{
		static int onLoadFontID = 0;
		static PrivateFontCollection userFontCollection = null; //Переделать
		static string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\WinFormsClock";
		static string filePath = folderPath + @"\Config.txt";
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			userFontCollection = LoadFont();
			SetFont(userFontCollection,onLoadFontID);
			CheckFont(userFontCollection);
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

		PrivateFontCollection LoadFont()
		{
			PrivateFontCollection fontCollection = new PrivateFontCollection();
			fontCollection.AddFontFile("Fonts\\MOSCOW2024.otf");
			fontCollection.AddFontFile("Fonts\\thecapt.otf");
			return fontCollection;
		}

		void SetFont(PrivateFontCollection fontCollection, int fontID)
		{
			labelTime.Font = new Font(fontCollection.Families[fontID], 32f);
		}

		void CheckFont(PrivateFontCollection fontCollection)
		{
			if (fontCollection.Families[onLoadFontID].Name == fontCollection.Families[0].Name)
			{
				moscowToolStripMenuItem.Checked = true;
			}
			else if (fontCollection.Families[onLoadFontID].Name == fontCollection.Families[1].Name)
			{
				theCaptToolStripMenuItem.Checked = true;
			}
		}

		void CreateConfig()
		{
			string conf = this.BackColor.R.ToString() + "\n"
						+ this.BackColor.G.ToString() + "\n"
						+ this.BackColor.B.ToString() + "\n"
						+ labelTime.ForeColor.R.ToString() + "\n"
						+ labelTime.ForeColor.G.ToString() + "\n"
						+ labelTime.ForeColor.B.ToString() + "\n"
						+ toolStripMenuITemTopmost.Checked + "\n"
						+ toolStripMenuItemShowControls.Checked + "\n"
						+ toolStripMenuItemShowDate.Checked + "\n"
						+ toolStripMenuItemShowWeekday.Checked + "\n"
						+ moscowToolStripMenuItem.Checked + "\n"
						+ theCaptToolStripMenuItem.Checked + "\n";
			File.WriteAllText(filePath, conf);
		}

		void ReadConfig()
		{
			int FormColorR = Convert.ToInt32(File.ReadAllLines(filePath).First());
			int FormColorG = Convert.ToInt32(File.ReadAllLines(filePath).Skip(1).First());
			int FormColorB = Convert.ToInt32(File.ReadAllLines(filePath).Skip(2).First());
			int labelColorR = Convert.ToInt32(File.ReadAllLines(filePath).Skip(3).First());
			int labelColorG = Convert.ToInt32(File.ReadAllLines(filePath).Skip(4).First());
			int labelColorB = Convert.ToInt32(File.ReadAllLines(filePath).Skip(5).First());
			bool TopmostStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(6).First());
			bool ControlsStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(7).First());
			bool DateStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(8).First());
			bool WeekdayStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(9).First());
			bool FontMoscowStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(10).First());
			bool FontCaptStatus = Convert.ToBoolean(File.ReadAllLines(filePath).Skip(11).First());
		}

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

		private void buttonHideControls_Click(object sender, EventArgs e)
		{
			SetVisibility(false);
		}

		private void labelTime_DoubleClick(object sender, EventArgs e)
		{
			SetVisibility(true);
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
			if(!toolStripMenuItemShowControls.Checked) SetVisibility(false);
			else SetVisibility(true);
		}
		/////////////////////////////////////////////////////////////////////

		//////////////////////////////Show date//////////////////////////////
		private void checkBoxShowDate_CheckStateChanged(object sender, EventArgs e)
		{
			if (checkBoxShowDate.Checked) toolStripMenuItemShowDate.Checked = true;
			else toolStripMenuItemShowDate.Checked = false;
		}

		private void toolStripMenuItemShowDate_CheckStateChanged(object sender, EventArgs e)
		{
			switch(toolStripMenuItemShowDate.Checked)
			{
				case true:		checkBoxShowDate.Checked = true; break;
				case false:		checkBoxShowDate.Checked = false; break;
			}
		}
		/////////////////////////////////////////////////////////////////////

		////////////////////////////Show weekday/////////////////////////////
		private void checkBoxShowWeekday_CheckStateChanged(object sender, EventArgs e)
		{
			if(checkBoxShowWeekday.Checked) toolStripMenuItemShowWeekday.Checked = true;
			else toolStripMenuItemShowWeekday.Checked= false;
		}

		private void toolStripMenuItemShowWeekday_CheckStateChanged(object sender, EventArgs e)
		{
			switch (toolStripMenuItemShowWeekday.Checked)
			{
				case true:		checkBoxShowWeekday.Checked = true; break;
				case false :	checkBoxShowWeekday.Checked = false; break;
			}
		}

		/////////////////////////////////////////////////////////////////////

		////////////////////////////Choose font//////////////////////////////
		private void moscowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFont(userFontCollection, 0);
			moscowToolStripMenuItem.Checked = true;
		}

		private void moscowToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			if (moscowToolStripMenuItem.Checked) theCaptToolStripMenuItem.Checked = false;
		}

		private void theCaptToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SetFont(userFontCollection, 1);
			theCaptToolStripMenuItem.Checked = true;
		}

		private void theCaptToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
		{
			if(theCaptToolStripMenuItem.Checked) moscowToolStripMenuItem.Checked = false;
		}

		/////////////////////////////////////////////////////////////////////


		//////////////////////////////Colors/////////////////////////////////
		private void toolStripMenuItemBackgroundColor_Click(object sender, EventArgs e)
		{
			ColorPickForm BackgroudForm = new ColorPickForm(labelTime.BackColor.R, labelTime.BackColor.G, labelTime.BackColor.B);
			if (BackgroudForm.ShowDialog()==DialogResult.OK)
			{
				Color color = Color.FromArgb(BackgroudForm.Red, BackgroudForm.Green, BackgroudForm.Blue);
				labelTime.BackColor = color;
				this.BackColor = color;
			}
		}

		private void toolStripMenuItemForegroundColor_Click(object sender, EventArgs e)
		{
			ColorPickForm ForegroundForm = new ColorPickForm(labelTime.ForeColor.R, ForeColor.G, ForeColor.B);
			if (ForegroundForm.ShowDialog() == DialogResult.OK)
			{
				Color color = Color.FromArgb(ForegroundForm.Red, ForegroundForm.Green, ForegroundForm.Blue);
				labelTime.ForeColor = color;
			}
		}

		/////////////////////////////////////////////////////////////////////
		

		/////////////////////////////////////////////////////////////////////
		private void MainForm_Load(object sender, EventArgs e)
		{
			if(File.Exists(filePath))
			{
				
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(!Directory.Exists(folderPath))
			{
				Directory.CreateDirectory(folderPath);
				using (File.Create(filePath)) ; 
			}
			else
			{
				if (!File.Exists(filePath)) File.Create(filePath);
				else { }
			}
			CreateConfig();
		}

		/////////////////////////////////////////////////////////////////////

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
