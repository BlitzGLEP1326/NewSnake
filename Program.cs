//используем системную библиотеку
using System;
//используем библиотеку Linq
using System.Linq;
//используем библиотеку потоков
using System.Threading;
//используем библиотеку списков, колекций и т.д.
using System.Collections.Generic;

//пространство имен "змейка"
namespace Snake
{
	//базовый класс
	class MainClass
	{
		//точка входа в прогамму
		public static void Main (string[] args)
		{
			//приветствуем пользователя
			Console.WriteLine ("Welcome to console snake !!!");
			//ждем нажатия ENTER
			Console.ReadLine ();
			//очищаем экран для отрисовки поля змейки
			Console.Clear (); 
			//точка старта змейки
			Point p = new Point(4,5,'*');
			//создаем змейку
			snake mySnake = new snake (p, 4, direction.RIGHT);
			mySnake.draw ();
			//создаем генератор еды
			FoodCreator foodCreator = new FoodCreator(80, 25,'$');
			//создаем точку-еду
			Point food = foodCreator.CreateFood ();
			//отрисовываем еду
			food.draw ();
			//создаем стены и препятствия
			walls wall = new walls(80,25);
			wall.draw ();
			//главный цикл программы
			while (true) {
				//если змейка столкнулась со стеной или со своим хвостом то выходим из цикла
				if (wall.isHit (mySnake) || mySnake.isHitTail ()) {
					break;
				}
				//если змейка ест то создаем новую порцию еды
				if (mySnake.eat (food)) {
					//создаем новую еду
					food = foodCreator.CreateFood ();
					//отрисовываем еду
					food.draw ();
				} else {
					//перемещаем змейку
					mySnake.Move ();
				}
				//Thread.Sleep (100);
				//читаем нажатые кнопки (вверх, вниз, вправо, влево)
				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					//отправляем в обработчик нажатую клавишу
					mySnake.HandleKey (key.Key);
				}
				//устанавливаем задержку
				Thread.Sleep (250);
				//перемещаем змейку
				mySnake.Move ();
			}
		}

		//
		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
