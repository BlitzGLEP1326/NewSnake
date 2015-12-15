using System;
using System.Collections.Generic;

namespace Snake
{
	public class VerticalLine : figure
	{
		public VerticalLine (int yUp, int yDown, int x, char s)
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++) {
				Point p = new Point (x, y, s);
				pList.Add (p);
			}
		}
	}
}

