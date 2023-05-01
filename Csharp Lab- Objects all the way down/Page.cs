using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lab__Objects_all_the_way_down
{
	internal class Page
	{
		List<Line> _lines;

		internal List<Line> Lines { get => _lines; set => _lines = value; }

		public Page()
		{
			_lines = new List<Line>();
		}

		public void write(string input)
		{
			try
			{
				_lines.Add(new Line(input));
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
		}

		public override string ToString()
		{
			string accum = "";
			for (int i = 0; i < _lines.Count; i++)
			{
				accum += _lines[i].ToString();
			}
			return accum;
		}
	}
}
