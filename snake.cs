using System;

namespace Snake
{
	public class snake : figure
	{
		public snake (Point tail, int length, direction direct)
		{
			for(int i = 0; i <= length; i++)
			{
				Point p = new Point (tail);
				p.Move (i, direct);
				pList.Add (p);
			}
		}
	}
}

