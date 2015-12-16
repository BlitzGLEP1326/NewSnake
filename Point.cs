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

		public Point(Point p)
		{
			x = p.x;
			y = p.y;
			ch = p.ch;
		}

		public void Move(int offset, direction direct )
		{
			if (direct == direction.RIGHT) {
				x += offset;
			} else if (direct == direction.LEFT) {
				x -= offset;
			} else if (direct == direction.UP) {
				y -= offset;
			} else if (direct == direction.DOWN) {
				y += offset;
			}
		}

		public Point(int _x, int _y, char _s)
		{
			x = _x;
			y = _y;
			ch = _s;
		}

		public void Clear()
		{
			ch = ' ';
			draw ();
		}

		public Point ()
		{
			Console.WriteLine ("создается новая точка");
		}

		public override string ToString ()
		{
			return x + ", " + y + ", " + ch;
		}
	}
}

