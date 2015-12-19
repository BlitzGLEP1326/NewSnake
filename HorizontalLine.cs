using System;
using System.Collections.Generic;

namespace Snake
{
	public class HorizontalLine : figure
	{
		//конструктор класса
		public HorizontalLine (int xLeft, int xRight, int y, char s)
		{
			pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++) {
				Point p = new Point (x, y, s);
				pList.Add (p);
			}
		}

		public override void draw()
		{
			Console.ForegroundColor = ConsoleColor.Blue;

			base.draw ();
		}
	}
}

