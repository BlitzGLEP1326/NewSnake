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
			//Console.SetBufferSize (80, 25);
			//отрисовка рамки
			HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
			VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
			//
			upLine.draw();
			downLine.draw();
			leftLine.draw();
			rightLine.draw();
			//
			Point p = new Point(4,5,'*');
			snake mySnake = new snake (p, 4, direction.RIGHT);
			//
			FoodCreator foodCreator = new FoodCreator(80, 25,'$');
			Point food = foodCreator.CreateFood ();
			food.draw ();
			//
			while (true) {
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

		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
