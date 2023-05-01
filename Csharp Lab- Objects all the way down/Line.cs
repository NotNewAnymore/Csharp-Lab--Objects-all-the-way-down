using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lab__Objects_all_the_way_down
{
	internal class Line
	{
		string _text;

		public Line(string text)
		{
			if (text.Length < 100)
			{
				_text = text;
			}
			else
			{
				throw new ArgumentException("Error- tried to create a too long string!");
			}
		}

		public void AddText(string text)
		{
			if (text.Length < 100)
			{
				_text += text;
			}
			else
			{
				throw new ArgumentException("Error- tried to create a too long string!");
			}
		}
		public override string ToString()
		{
			return _text += "\n";
		}
	}
}
