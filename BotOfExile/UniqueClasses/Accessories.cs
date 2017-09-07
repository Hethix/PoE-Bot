using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BotOfExile.Uniques
{
	class Accessories : Unique
	{
		public StatText Has_stat_text { get; set; }
		public string Has_level_requirement { get; set; }

		public class StatText
		{
			public string Has_implicit_stat_text { get; set; }
			public string Has_explicit_stat_text { get; set; }
		}
	}
}
