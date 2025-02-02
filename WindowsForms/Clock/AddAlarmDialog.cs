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
		public AlarmClass Alarm;
		OpenFileDialog openFile;
		public AddAlarmDialog()
		{
			InitializeComponent();
			dtp_Date.Enabled = false;
			Alarm = new AlarmClass();
			SetWeekDays();
			openFile = new OpenFileDialog();
		}

		void SetWeekDays()
		{
			bool[] days = Alarm.Week.ToArray();
			for (int i = 0; i < chklb_WeekDays.Items.Count; i++)
			{
				chklb_WeekDays.SetItemChecked(i, days[i]);
			}
		}

		private void chkbx_UseDate_CheckedChanged(object sender, EventArgs e)
		{
			dtp_Date.Enabled = chkbx_UseDate.Checked;
			chklb_WeekDays.Enabled = !chkbx_UseDate.Checked;

		}

		private void btn_Ok_Click(object sender, EventArgs e)
		{
			//for (int i = 0; i < chklb_WeekDays.Items.Count; i++)
			//{
			//	Console.WriteLine(chklb_WeekDays.GetItemChecked(i) + "\t");
			//	Console.WriteLine();
			//}
			//TimeSpan userTime;
			//TimeSpan.TryParseExact(dtp_Time.Text.ToString(), @"hh\:mm", null, out userTime);
			//WeekClass weekDay = new WeekClass(GetBitFlag());
			//if (chkbx_UseDate.Checked)
			//{
			//	AlarmClass alarmClass = new AlarmClass(dtp_Date.Value.Date, userTime, weekDay, lbl_FileName.Text, tb_UserMessage.Text);
			//	Console.WriteLine(alarmClass);
			//}
			//else if (!chkbx_UseDate.Checked)
			//{
			//	AlarmClass alarmClass = new AlarmClass(userTime, weekDay, lbl_FileName.Text, tb_UserMessage.Text);
			//	Console.WriteLine(alarmClass);
			//}
			//Console.WriteLine(userTime);

			this.DialogResult = DialogResult.OK;
			Alarm.Date = dtp_Date.Enabled ? dtp_Date.Value : DateTime.MinValue;
			Alarm.Time = dtp_Time.Value.TimeOfDay;
			Alarm.Week = new WeekClass
				(
					chklb_WeekDays.Items.Cast<object>().Select((item, index) => chklb_WeekDays.GetItemChecked(index)).ToArray()
				);
			if (lbl_FileName.Text != "File name" && lbl_FileName.Text != "")
			{
				Alarm.FileName = openFile.FileName;
			}
			else
			{
				MessageBox.Show(this, "Choose signal", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.DialogResult = DialogResult.None;
			}
			Alarm.Message = tb_UserMessage.Text;
		}

		private void btn_ChooseSignal_Click(object sender, EventArgs e)
		{
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				lbl_FileName.Text = $"File name:{openFile.SafeFileName}";
			}
		}

		//public byte GetBitFlag()
		//{
		//	byte weekDays = 0;
		//	int mul = 1;
		//	for (int i = 0; i < chklb_WeekDays.Items.Count; i++)
		//	{
		//		if (chklb_WeekDays.GetItemChecked(i)) weekDays |= (byte)mul;
		//		mul *= 2;
		//	}
		//	return weekDays;
		//}
		//public string ReturnBinaryFlag(byte flag)
		//{
		//	char[] bitFlag = new char[8];
		//	for (int i = 0; i < 8; i++)
		//	{
		//		bitFlag[7 - i] = (flag & (1 << i)) != 0 ? '1' : '0';
		//	}
		//	return new string(bitFlag);
		//}
	}
}
