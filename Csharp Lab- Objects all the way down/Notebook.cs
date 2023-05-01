using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Lab__Objects_all_the_way_down
{
	internal class Notebook
	{
		List<Page> pages;

		internal List<Page> Pages { get => pages; }

		public void InsertPage(Page page, int index)
		{
			pages.Insert(index, page);
		}
		public void InsertPage(Page page)
		{
			pages.Add(page);
		}

		public Notebook()
		{
			this.pages = new List<Page>();
		}

		public override string ToString()
		{
			string accum = "";
			for (int i = 0; i < pages.Count; i++)
			{
				accum += pages[i].ToString();
				accum += "\n\n";
			}
			return accum;
		}
	}
}
