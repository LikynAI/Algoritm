﻿using System;

namespace ConsoleApp4
{
	public class kon
	{
		public int x, y;

		public kon(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public kon(kon kon1)
		{
			x = kon1.x;
			y = kon1.y;
		}

		/// <summary>
		/// передвигает коня на n-ную клетку
		/// </summary>
		/// <param name="mas"></param>
		/// <param name="n"></param> указывает сколько ближайших клеток должен пропустить конь
		/// <returns></returns>
		public bool move(int[,] mas, int n)
		{
			int tempo = -1;
			for (int x = 0; x < mas.GetLength(0); x++)
			{
				for (int y = 0; y < mas.GetLength(1); y++)
				{
					if (mas[x,y] == 0 && Possible(x, y))
					{
						tempo++;
						if (n == tempo)
						{
							this.x = x;
							this.y = y;
							return true;
						}
					}
				}
			}
			return false;
		}

		/// <summary>
		/// проверяет может ли конь передвинуться на клетку с координатами Х и У за один ход
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns></returns>
		private bool Possible(int x, int y)
		{
			if ((Math.Pow(this.x - x,2) + Math.Pow(this.y - y,2)) == 5)
			{
				return true;
			}
			return false;
		}
	}
}
