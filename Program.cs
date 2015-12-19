using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;

namespace Snake
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Welcome to console snake !!!");
			Console.ReadLine ();
			Console.Clear (); 
			//

			//точка старта змейки
			Point p = new Point(4,5,'*');
			//создаем змейку
			snake mySnake = new snake (p, 4, direction.RIGHT);
			//создаем генератор еды
			FoodCreator foodCreator = new FoodCreator(80, 25,'$');
			//создаем точку-еду
			Point food = foodCreator.CreateFood ();
			//отрисовываем еду
			food.draw ();
			//
			walls wall = new walls();
			//
			while (true) {

				if (wall.isHit (mySnake) || mySnake.isHitTail ()) {
					break;
				}

				if (mySnake.eat (food)) {
					food = foodCreator.CreateFood ();
					food.draw ();
				} else {
					mySnake.Move ();
				}
				
				//Thread.Sleep (100);

				if (Console.KeyAvailable) {
					ConsoleKeyInfo key = Console.ReadKey ();
					mySnake.HandleKey (key.Key);
					//

				}
				Thread.Sleep (100);
				mySnake.Move ();
			}
			//
		}

		//
		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
