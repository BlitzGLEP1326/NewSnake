using System;
using System.Collections.Generic;

//пространство имен "змейка"
namespace Snake
{
	//класс фигур
	public class figure
	{
		//список точек
		protected List<Point> pList; 

		//конструктор
		public figure ()
		{
			
		}

		//отрисовка фигуры (виртуальный метод)
		public virtual void draw()
		{
			//для каждого элемента списка точек производим отрисовку ))
			foreach (Point p in pList) {
				p.draw ();
			}
		}

		//проверка на столкновение (в качестве параметра передаем фигуру)
		internal bool IsHit(figure fig)
		{
			//для каждого элемента списка фигур сверяем на совпадение координат точек
			foreach (var p in pList) {
				if (fig.IsHit (p))
					//если совпало - возвращаем true
					return true;
			}
			//иначе - говорим что все в порядке
			return false;
		}	

		//проверяем на совпадение координат (в качестве параметра передаем точку)
		private bool IsHit(Point fig)
		{
			//для каждого элемента списка проверяем на 
			foreach (var p in pList) {
				if ((p.x == fig.x) && (p.y == fig.y))
					return true;
			}
			return false;
		}
	}
}

