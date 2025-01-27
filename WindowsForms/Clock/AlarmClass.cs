using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	internal class AlarmClass
	{
		public static readonly List<AlarmClass> alarmsList = new List<AlarmClass>();
		public DateTime Date {  get; set; }
		public TimeSpan Time { get; set; }
		public WeekClass Week { get; set; }
		public string FileName { get; set; }
		public string Message {  get; set; }
		public AlarmClass(TimeSpan time, WeekClass weekdays, string fileName, string message) 
		{
			Time = time;
			Week = weekdays;
			FileName = fileName;
			Message = message;
			alarmsList.Add(this);
		}
		public AlarmClass(DateTime date,TimeSpan time, WeekClass weekdays, string fileName, string message) 
		{
			Date = date;
			Time = time;
			Week = weekdays;
			FileName = fileName;
			Message = message;
			alarmsList.Add(this);
		}
		public static IEnumerable<AlarmClass> GetAllAlarms()
		{
			return alarmsList;
		}
		public override string ToString() 
		{
			if (Date.Year != 0001) return ($"{Date.DayOfYear}, {Time}, {Week}, {FileName}, {Message}");
			else return ($"{Time}, {Week}, {FileName}, {Message}");
		}
		
	}
}
