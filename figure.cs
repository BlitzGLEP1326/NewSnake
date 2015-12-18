using System;
using System.Collections.Generic;

namespace Snake
{
	public class figure
	{
		//список точек
		protected List<Point> pList; 

		public figure ()
		{
			
		}

		//отрисовка фигуры
		public virtual void draw()
		{
			foreach (Point p in pList) {
				p.draw ();
			}
		}
	}
}

