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

		//отрисовка фигуры (виртуальный метод)
		public virtual void draw()
		{
			foreach (Point p in pList) {
				p.draw ();
			}
		}

		//проверка на столкновение
		internal bool IsHit(figure fig)
		{
			foreach (var p in pList) {
				if (fig.IsHit (p))
					return true;
			}
			return false;
		}	

		//
		private bool IsHit(Point fig)
		{
			foreach (var p in pList) {
				if (fig.IsHit (p))
					return true;
			}
			return false;
		}
	}
}

