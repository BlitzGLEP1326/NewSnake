using System;
using System.Collections.Generic;

namespace Snake
{
	public class HorizontalLine
	{
		//список точек
		List<Point> pList;

		//конструктор класса
		public HorizontalLine (int xLeft, int xRight, int y, char s)
		{
			pList = new List<Point>();
			for (int x = xLeft; x <= xRight; x++) {
				Point p = new Point (x, y, s);
				pList.Add (p);
			}

		}

		public void draw()
		{
			foreach (Point p in pList) {
				p.draw ();
			}
		}
	}
}

