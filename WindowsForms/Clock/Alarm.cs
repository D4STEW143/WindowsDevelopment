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
	public partial class Alarm : Form
	{
		AddAlarmDialog dialog;
		public Alarm()
		{
			InitializeComponent();
			dialog = new AddAlarmDialog();
		}

		private void btn_Add_Click(object sender, EventArgs e)
		{
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				lb_Alarms.Items.Add(new AlarmClass(dialog.Alarm));
			}
		}

		private void lb_Alarms_DoubleClick(object sender, EventArgs e)
		{
			if(lb_Alarms.SelectedItem == null) return;
			dialog.Alarm = lb_Alarms.SelectedItem as AlarmClass;
			dialog.ShowDialog();
			if (dialog.DialogResult == DialogResult.OK)	lb_Alarms.Items[lb_Alarms.SelectedIndex] = dialog.Alarm;
		}
	}
}
