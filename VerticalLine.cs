using System;
using System.Collections.Generic;

//пространство имен "змейка"
namespace Snake
{
	//класс вертикальных линий - дочерний класс класса фигура
	public class VerticalLine : figure
	{
		//конструктор класса вертикальных линий
		public VerticalLine (int yUp, int yDown, int x, char s)
		{
			//создаем список точек
			pList = new List<Point>();
			//в цикле создаем точки по разряду координат и добавляем их в список
			for (int y = yUp; y <= yDown; y++) {
				Point p = new Point (x, y, s);
				pList.Add (p);
			}
		}
	}
}

