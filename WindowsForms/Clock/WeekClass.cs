using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
	internal class WeekClass
	{
		public byte Days { get; set; }
		public WeekClass(byte days) { Days = days; }
		public override string ToString()
		{
			return $"{Days}";
		}
	}
}
