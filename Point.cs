//используем системную библиотеку
using System;

//пространство имен "змейка"
namespace Snake
{
	//класс точка
	public class Point
	{
		//координата Х точки
		public int x;
		//координата Y точки
		public int y;
		//символ точки
		public char ch;

		//отрисовка точки
		public void draw()
		{
			//установку курсора вывода точки
			Console.SetCursorPosition (x, y);
			//вывод точки
			Console.Write (ch);
		}

		//конструктор класса
		public Point(Point p)
		{
			//устанавливаем передаваемые координаты и символ
			x = p.x;
			y = p.y;
			ch = p.ch;
		}

		//перемещение точки по нажатой кнопке
		public void Move(int offset, direction direct )
		{
			if (direct == direction.RIGHT) {
				x += offset;
			} else if (direct == direction.LEFT) {
				x -= offset;
			} else if (direct == direction.UP) {
				y -= offset;
			} else if (direct == direction.DOWN) {
				y += offset;
			}
		}

		//альтернативный конструктор
		public Point(int _x, int _y, char _s)
		{
			x = _x;
			y = _y;
			ch = _s;
		}

		//очистка текущей точки
		public void Clear()
		{
			ch = ' ';
			draw ();
		}

		//конструктор класса
		public Point ()
		{
			Console.WriteLine ("создается новая точка");
		}

		//вывод в терминал содержимого точки
		public override string ToString ()
		{
			return x + ", " + y + ", " + ch;
		}

		//сравнение точки на столкновение
		public bool isHit(Point p)
		{
			return p.x == this.x && this.y == p.y;
		}
	}
}

