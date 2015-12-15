using System;
using System.Collections.Generic;

namespace Snake
{
	public class snake : figure
	{
		direction direct;
		public snake (Point tail, int length, direction _direct)
		{
			direct = _direct;
			pList = new List<Point> ();
			for (int i = 0; i <= length; i++) {
				Point p = new Point (tail);
				p.Move (i, direct);
				pList.Add (p);
			}
		}

		internal void Move()
		{
			Point tail = pList [0];
			pList.Remove (tail);
			Point head = GetNextPoint ();
			pList.Add (head);
			//
			tail.Clear();
			head.draw ();
		}

		public Point GetNextPoint()
		{
			Point head = pList [pList.Count  - 1];
			Point nextPoint = new Point(head);
			nextPoint.Move (1, direct);
			return nextPoint;
		}
	}
}