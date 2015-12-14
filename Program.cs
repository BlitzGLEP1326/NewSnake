using System;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to console snake !!!");
			Console.ReadLine ();
			Point p1 = new Point();
			p1.x = 1;
			p1.y = 3;
			p1.ch = '*';
			p1.draw();
			Console.ReadLine ();
		}

		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
