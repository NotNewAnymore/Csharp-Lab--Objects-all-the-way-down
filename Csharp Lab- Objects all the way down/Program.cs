namespace Csharp_Lab__Objects_all_the_way_down
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Page testpage = new Page();
			testpage.write("Some day I should write a diary");
			testpage.write("It would contain all sorts of deep thoughts and stuff.");
			testpage.write("I could even write way too much and crash the program. But I probably should not do that.");
			//testpage.write("I could even write way too much and crash the program. But I probably should not do that. Eh, why not. Let's just keep on writing. You ever listen to Ali Project? Their music is good and interesting. Lorem, ipsum...");
			testpage.Lines[0].AddText(". With proper punctuation.");
			//Console.WriteLine(testpage);

			Page page2 = new Page();
			page2.write("This is page 2");
			page2.write("It has multiple lines");
			page2.write("They are of multiple varying lengths.");

			Page page3 = new Page();
			page3.write("This page has a single line");

			Page misplaced = new Page();
			misplaced.write("This is the page inserted later. It contains:");
			misplaced.write("A hastily written note");
			misplaced.write("A list");
			misplaced.write("and a drawing of a quarter");
			

			Notebook notebook = new Notebook();
			notebook.InsertPage(testpage);
			notebook.InsertPage(page2);
			notebook.InsertPage(page3);
			notebook.InsertPage(misplaced, 1);
			Console.WriteLine(notebook);

		}

	}
}