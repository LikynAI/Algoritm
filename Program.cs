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
			int[,] doska = new int[8,8];

			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					doska[i, j] = 0;
				}
			}

			int[] vozvrati = new int[65];
			foreach (int i in vozvrati)
			{
				vozvrati[i] = 0;
			}

			
			kon kon1 = new kon(0,0);

			Stack<kon> hodi = new Stack<kon>(); 
			hodi.Push(new kon(kon1.x,kon1.y));

			int step = 0;
			while (step != 63)
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

			int o = 0;
			foreach (kon k in hodi)
			{
				Console.SetCursorPosition(k.x*3, k.y*2);
				Console.Write(++o);
			}

			Console.ReadLine();
		}
	}
}
