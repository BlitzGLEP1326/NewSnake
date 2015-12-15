using System;

namespace Snake
{
	public class Point
	{
		public int x;
		public int y;
		public char ch;

		public void draw()
		{
			Console.SetCursorPosition (x, y);
			Console.Write (ch);
		}

		public Point(int _x, int _y, char _s)
		{
			x = _x;
			y = _y;
			ch = _s;
		}

		public Point ()
		{
			Console.WriteLine ("создается новая точка");
		}
	}
}

