using System;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			//CreateDoska(7, 7);

			//kon[] hodi = Solution(CreateDoska(7, 7));

			//Show(hodi);
			

			int[] vs1 = new int[] { 1, 3, 5, 8, 5, 7, 2, 1, 9 };
			int[] vs2 = new int[] { 2, 5, 8, 9, 4, 7, 8, 5, 1 };

			Console.WriteLine(	Length.Fin(vs1, vs2));
			Console.ReadLine();
		}

		/// <summary>
		/// Создает доску размером v1 на v2
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		private static int[,] CreateDoska(int v1, int v2)
		{
			int[,] doska = new int[v1, v2];

			for (int i = 0; i < doska.GetLength(0); i++)
			{
				for (int j = 0; j < doska.GetLength(1); j++)
				{
					doska[i, j] = 0;
				}
			}
			return doska;
		}

		/// <summary>
		/// Решает задочу о ходе коня для заданной доски
		/// </summary>
		/// <param name="doska"></param> 
		/// <returns></returns>
		public static kon[] Solution(int[,] doska)
		{
			int[] vozvrati = new int[doska.Length];
			foreach (int i in vozvrati)
			{
				vozvrati[i] = 0;
			}


			kon kon1 = new kon(0, 0);

			kon[] hodi = new kon[doska.Length];
			hodi[0] = new kon(kon1.x, kon1.y);

			int step = 0;
			while (step != doska.Length-1)
			{
				doska[kon1.x, kon1.y] = 1;
				if (kon1.move(doska, vozvrati[step]))
				{
					step++;
					hodi[step] = new kon(kon1.x, kon1.y); ;
				}
				else
				{
					doska[kon1.x, kon1.y] = 0;

					vozvrati[step] = 0;

					hodi[step] = null;
					step--;
					kon kont = new kon(hodi[step]);
					kon1 = kont;
					
					vozvrati[step]++;
				}
			}
			return hodi;
		}

		/// <summary>
		/// выводит на консоль информацию о том как ходил конь
		/// </summary>
		/// <param name="hodi"></param>
		public static void Show(kon[] hodi)
		{
			int o = 0;

			foreach (kon k in hodi)
			{
				Console.SetCursorPosition(k.x * 3, k.y * 2);
				Console.Write(++o);
			}
		}
	}
}
