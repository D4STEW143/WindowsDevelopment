using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class AlarmClass : IComparable<AlarmClass>
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

		public AlarmClass(string alarmString)
		{

		}

		public static bool operator >(AlarmClass left, AlarmClass right)
		{
			return left.Time > right.Time;
		}
		public static bool operator <(AlarmClass left, AlarmClass right)
		{
			return left.Time < right.Time;
		}

		public int CompareTo(AlarmClass other)
		{
			return this.Time.CompareTo(other.Time);
		}

		public string ToFormatString()
		{
			string info = "";
			if (this.Date != DateTime.MinValue)
			{
				info += $"{this.Date.ToString("dd.MM.yyyy")}|";
			}
			else info += "NoDate|";
			info += $"{(DateTime.Now.Date + Time).ToString("HH:mm:ss")}|{this.Week.ToFormatString()}|{this.Message}|{this.FileName}";
			return info;
		}

		public override string ToString()
		{
			string info = "";
			info += $"{(DateTime.Now.Date + Time).ToString("HH:mm:ss")}\t{this.Week}\t{this.FileName.Split('\\').Last()}\t";
			if (this.Date != DateTime.MinValue) info += this.Date.ToString("dd.MM.yyyy");
			return info;
		}
	}
}
