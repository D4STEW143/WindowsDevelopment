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
			dialog.ShowDialog();
		}
	}
}
