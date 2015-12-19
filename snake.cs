using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

//пространство имен "змейка"
namespace Snake
{
	//класс змейки - дочерний класс класса фигура
	public class snake : figure
	{
		//перечисление "направление"
		public direction direct;

		//конструктор (стартовая точка, длина, направление)
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

		//перемещаем змейку
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

		//проверка ест ли
		internal bool eat(Point food)
		{
			Point head = GetNextPoint ();
			if (head.isHit (food)) {
				food.ch = head.ch;
				pList.Add (food);
				return true;
			} else
				return false;
		}

		//получить следующую точку
		public Point GetNextPoint()
		{
			Point head = pList [pList.Count  - 1];
			Point nextPoint = new Point(head);
			nextPoint.Move (1, direct);
			return nextPoint;
		}

		//проверка на столкновение с хвостом
		internal bool isHitTail()
		{
			var head = pList.Last ();
			for (int i = 0; i < pList.Count - 2; i++) {
				if (head.isHit (pList [i]))
					return true;
			}
			return false;
		}

		//обработчик нажатия клавиш (вверх, вниз, вправо, влево)
		public void HandleKey(ConsoleKey key)
		{
			if(key == ConsoleKey.LeftArrow)
				direct = direction.LEFT;
			else if(key == ConsoleKey.RightArrow)
				direct = direction.RIGHT;
			else if(key == ConsoleKey.UpArrow)
				direct = direction.UP;
			else if(key == ConsoleKey.DownArrow)
				direct = direction.DOWN;
		}
	}
}