using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			int[,] doska = new int[3,10];

			for (int i = 0; i < doska.GetLength(0); i++)
			{
				for (int j = 0; j < doska.GetLength(1); j++)
				{
					doska[i, j] = 0;
				}
			}

			Stack<kon> hodi = Solution(doska);

			int o = doska.Length;
			
			foreach (kon k in hodi)
			{
				Console.SetCursorPosition(k.x*3, k.y*2);
				Console.Write(o--);
			}

			Console.ReadLine();
		}

		/// <summary>
		/// Решает задочу о ходе коня для заданной доски
		/// </summary>
		/// <param name="doska"></param> 
		/// <returns></returns>
		public static Stack<kon> Solution(int[,] doska)
		{
			int[] vozvrati = new int[doska.Length];
			foreach (int i in vozvrati)
			{
				vozvrati[i] = 0;
			}


			kon kon1 = new kon(0, 0);

			Stack<kon> hodi = new Stack<kon>();
			hodi.Push(new kon(kon1.x, kon1.y));

			int step = 0;
			while (step != doska.Length-1)
			{
				doska[kon1.x, kon1.y] = 1;
				if (kon1.move(doska, vozvrati[hodi.Count]))
				{
					kon kont = new kon(kon1.x, kon1.y);
					hodi.Push(kont);
					step++;
				}
				else
				{
					doska[kon1.x, kon1.y] = 0;

					step--;

					vozvrati[hodi.Count] = 0;

					hodi.Pop();
					kon kont = new kon(hodi.Peek());
					kon1 = kont;

					vozvrati[hodi.Count]++;
				}
			}
			return hodi;
		}

	}
}
