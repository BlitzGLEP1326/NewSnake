using System;

namespace Snake
{
	//генератор еды
	public class FoodCreator
	{
		//ширина карты
		int mapWidth;
		//высота карты
		int mapHeight;
		//символ еды
		char sym;

		Random random = new Random();

		//конструктор генератора еды
		public FoodCreator (int mapWidth, int mapHeight, char sym)
		{
			this.mapWidth = mapWidth;
			this.mapHeight = mapHeight;
			this.sym = sym;
		}

		//метод создания еды
		public Point CreateFood()
		{
			//в случайном месте карты создаем точку-еду
			int x = random.Next (2, mapWidth - 2);
			int y = random.Next (2, mapHeight - 2);
			return new Point (x, y, sym);
		}
	}
}

