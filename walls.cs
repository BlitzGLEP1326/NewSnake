using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Snake
{
	public class walls
	{
		//создаем список стен
		List<figure> wallList;

		//устанавливаем габариты карты
		public walls (int mapWidth, int mapHeight)
		{
			wallList = new List<figure>();

			//отрисовка рамки
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');

			//добавляем линии в список
			wallList.Add (upLine);
			wallList.Add (downLine);
			wallList.Add (leftLine);
			wallList.Add (rightLine);
		}

		//проверка на столкновение со стеной/препятстсвием
		internal bool isHit(figure fig)
		{
			foreach (var wall in wallList) {
				if (wall.IsHit (fig))
					return true;
			}
			return false;
		}

		//
		public void draw()
		{
			foreach (var wall in wallList) {
				wall.draw ();
			}
		}
	}
}

