using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class AlarmClass
	{
		public DateTime Date { get; set; }
		public TimeSpan Time { get; set; }
		public WeekClass Week { get; set; }
		public string FileName { get; set; }
		public string Message { get; set; }
		public AlarmClass() { this.Week = new WeekClass(); }
		public AlarmClass(AlarmClass other)
		{
			this.Date = other.Date;
			this.Time = other.Time;
			this.Week = new WeekClass(other.Week);
			this.FileName = other.FileName;
			this.Message = other.Message;
		}
		public override string ToString()
		{
			string info = "";
			info += $"{(DateTime.Now.Date+Time).ToString("HH:mm:ss")}\t\t{this.Week}\t\t{this.FileName.Split('\\').Last()}\t\t";
			if (this.Date != DateTime.MinValue) info += this.Date.ToString("dd.MM.yyyy");
			return info;
		}
	}
}
