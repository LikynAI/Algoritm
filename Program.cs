using System;


namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] doska = new int[5,10];

			for (int i = 0; i < doska.GetLength(0); i++)
			{
				for (int j = 0; j < doska.GetLength(1); j++)
				{
					doska[i, j] = 0;
				}
			}

			kon[] hodi = Solution(doska);

			int o = 0;
			
			foreach (kon k in hodi)
			{
				Console.SetCursorPosition(k.x*3, k.y*2);
				Console.Write(++o);
			}

			Console.ReadLine();
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

	}
}
