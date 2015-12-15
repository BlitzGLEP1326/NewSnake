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
			Point p1 = new Point (3, 1, '*');
			Point p2 = new Point (2, 5, '#');
			//
			p1.draw();
			p2.draw();
			//
			List<int> numList = new List<int>();
			numList.Add (0);
			numList.Add (1);
			numList.Add (2);
			//
			int x = numList[0];
			int y = numList[1];
			int z = numList[2];
			//
			foreach (int i in numList) {
				Console.WriteLine (i);
			}
			//
			numList.RemoveAt(0);
			//
			Console.ReadLine ();
		}

		static void Draw(int x, int y, char s)
		{
			Console.SetCursorPosition (x, y);
			Console.Write (s);
		}
	}
}
