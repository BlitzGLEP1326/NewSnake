using System;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x1 = 1;
			int y1 = 3;
			char sym1 = '*';
			Console.ReadLine ();
			Console.SetCursorPosition (x1, y1);
			Console.Write (sym1);
		}

		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
