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
				Console.WriteLine(chklb_WeekDays.GetItemChecked(i) + "\t");
				Console.WriteLine();
			}

			TimeSpan userTime;
			TimeSpan.TryParseExact(dtp_Time.Text.ToString(), @"hh\:mm", null, out userTime);
			WeekClass weekDay = new WeekClass(GetByteFlag());
			if (chkbx_UseDate.Checked) 
			{
				AlarmClass alarmClass = new AlarmClass(dtp_Date.Value.Date, userTime, weekDay, lbl_FileName.Text, tb_UserMessage.Text);
				Console.WriteLine(alarmClass);
			}
			else if(!chkbx_UseDate.Checked) 
			{
				AlarmClass alarmClass = new AlarmClass(userTime, weekDay, lbl_FileName.Text, tb_UserMessage.Text); 
				Console.WriteLine(alarmClass);
			}

            Console.WriteLine(userTime);
		}

		public byte GetByteFlag()
		{
			byte weekDays = 0;
			int mul = 1;
			for (int i = 0; i < chklb_WeekDays.Items.Count; i++)
			{
				if (chklb_WeekDays.GetItemChecked(i)) weekDays |= (byte)mul;
				mul *= 2;
			}
			return weekDays;
		}
	}
}
