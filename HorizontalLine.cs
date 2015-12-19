//использование системной библиотеки
using System;
//использование библиотеки
using System.Collections.Generic;

//пространство имен змейка
namespace Snake
{
	//класс горизонтальных линий - дочерний класс класса фигура
	public class HorizontalLine : figure
	{
		//конструктор класса
		public HorizontalLine (int xLeft, int xRight, int y, char s)
		{
			//список точек горизонтальной линии
			pList = new List<Point>();
			//по количеству координат в цикле создаем точки и добавляем их в список
			for (int x = xLeft; x <= xRight; x++) {
				Point p = new Point (x, y, s);
				pList.Add (p);
			}
		}

		//собственная реализация виртуального метода отрисовки
		public override void draw()
		{
			//устанавливаем цвет переднего плана шрифта
			Console.ForegroundColor = ConsoleColor.Blue;
			//отрисовываем ))
			base.draw ();
			//меняем обратно ))
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}

