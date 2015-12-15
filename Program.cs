using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to console snake !!!");
			Console.ReadLine ();
			Console.Clear ();
			//
			//Console.SetBufferSize (80, 25);
			//отрисовка рамки
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
			//
			upLine.draw();
			downLine.draw();
			leftLine.draw();
			rightLine.draw();
			//
			Point p = new Point(4,5,'*');
			snake mySnake = new snake (p, 3, direction.RIGHT);
			//
			Console.ReadLine ();
		}

		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
