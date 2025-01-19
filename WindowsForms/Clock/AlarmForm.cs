using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
	public partial class AlarmForm : Form
	{
		public DateTime AlarmTime { get; set; }
		public string AlarmName { get; set; }
		public AlarmForm()
		{
			InitializeComponent();

		}

		private void timerAlarm_Tick(object sender, EventArgs e)
		{
			labelAlarmTime.Text = DateTime.Now.ToString("HH:mm");
		}

		private void buttonSetAlarm_Click(object sender, EventArgs e)
		{
			AlarmName = textBoxAlarmName.Text;
			AlarmTime = Convert.ToDateTime(AlarmTime);
			Alarm alarm = new Alarm(AlarmName, AlarmTime);
			this.Close();
		}
	}
	public partial class Alarm
	{
		public string Name { get; set; }
		public DateTime Time { get; set; }
		public Alarm(string name, DateTime time)
		{
			Name = name;
			Time = time;
		}
	}
}
