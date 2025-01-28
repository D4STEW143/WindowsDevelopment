using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	public class WeekClass
	{
		static readonly string[] DAY_NAMES = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };
		public byte Days { get; set; }
		public WeekClass(byte days = 127)
		{
			this.Days = days;
		}

		public WeekClass(bool[] days)
		{
			for (byte i = 0; i < days.Length; i++)
			{
				if (days[i]) this.Days |= (byte)(1 << i);
			}
		}
		public WeekClass(WeekClass other)
		{
			this.Days = other.Days;
		}
		public bool[] ToArray()
		{
			bool[] selectedDays = new bool[7];
			for (byte i = 0; i < selectedDays.Length; i++)
			{
				selectedDays[i] = (Days & (byte)(1 << i)) != 0;
			}
			return selectedDays;
		}
		public override string ToString()
		{
			if (Days == 127) return "Каждый день";
			if (Days == 0) return "Один раз";
			if (Days == 31) return "По будням";
			if (Days == 96) return "По выходным";
			string dayNames = "";
			for (byte i = 0; i < DAY_NAMES.Length; i++)
			{
				if ((Days & (byte)(1 << i)) != 0) dayNames += $"{DAY_NAMES[i]},";
			}
			return dayNames;
		}
	}
}
