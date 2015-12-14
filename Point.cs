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

		public Point ()
		{
		}
	}
}

