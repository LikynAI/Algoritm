using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] vs = CreateMassive(1000000);
			int[] vs2 = vs;

			DateTime start = DateTime.Now;
			Puzirok(vs);
			Console.WriteLine((start - DateTime.Now).Milliseconds);

			start = DateTime.Now;
			PuzirokV2(vs2);
			Console.WriteLine((start - DateTime.Now).Milliseconds);

			Console.ReadLine();
		}

		public static int[] Puzirok(int []a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a.Length - 1; j++)
				{
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
				}
			}
			return a;
		}

		private static int[] PuzirokV2(int[] a)
		{
			int i = 0;
			while( i < a.Length)
			{
				int j = 0;
				while ( j < a.Length - 1)
				{
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
					j++;
				}
				i++;
			}
			return a;
		}

		public static void Show(int[] a)
		{
			foreach (int item in a)
			{
				Console.WriteLine(item);
			}
		}

		public static int[] CreateMassive(int v)
		{
			int[] mass = new int[v];

			Random r = new Random();

			int i = 0;
			while (i < v)
			{
				mass[i] = r.Next(10);
				i++;
			}
			return mass;
		}

		
	}
}
