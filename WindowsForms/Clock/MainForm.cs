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

namespace Clock
{
	public partial class MainForm : Form
	{
		static int onLoadFontID = 1;
		public MainForm()
		{
			InitializeComponent();
			labelTime.BackColor = Color.AliceBlue;
			this.Location = new Point(Screen.PrimaryScreen.Bounds.Width - this.Width, 50);
			PrivateFontCollection userFontCollection = LoadFont();
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
			
		}



		/////////////////////////////////////////////////////////////////////




	}
}
