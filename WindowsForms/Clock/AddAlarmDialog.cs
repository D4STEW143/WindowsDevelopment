using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AddAlarmDialog : Form
	{
		public AddAlarmDialog()
		{
			InitializeComponent();
			dtp_Date.Enabled = false;
		}

		private void chkbx_UseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtp_Date.Enabled = chkbx_UseDate.Checked;
		}

		private void btn_Ok_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < chklb_WeekDays.Items.Count; i++)
			{
                Console.WriteLine(chklb_WeekDays.GetItemChecked(i)+"\t");
			}
		}
	}
}
