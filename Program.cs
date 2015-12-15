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
			Point p1 = new Point (3, 1, '*');
			Point p2 = new Point (2, 5, '#');
			//
			p1.draw();
			p2.draw();
			//
			HorizontalLine line = new HorizontalLine(5, 10, 3, '*');
			line.draw ();
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
