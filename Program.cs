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
			int[] vs = CreateMassive(10000);

			Console.WriteLine("Start 1");
			DateTime start = DateTime.Now;
			Shaker(vs);
			Console.WriteLine((start - DateTime.Now).Milliseconds);

			Console.ReadLine();
		}

		/// <summary>
		/// Осуществляет поиск элемента в массиве и возвпащает его индекс
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		/// <returns></returns>
		private static int BinSearch(int[] a, int b)
		{
			int left = 0;
			int right = a.Length - 1;
			while (left != right)
			{
				int tryindex = (left + right) / 2;

				if (a[tryindex] > b) { right = tryindex; }
				else if (a[tryindex] < b) { left = tryindex; }
				else { return tryindex; }
			}
			return -1;
		}

		/// <summary>
		/// Обычная сортировка пузырьком
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static int[] Puzirok(int []a)
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

		/// <summary>
		/// Сортировка пузырьком возвращающая к-во этераций
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static int PuzirokCount(int[] a)
		{
			int Count = 0;
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a.Length - 1; j++)
				{
					Count++;
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
				}
			}
			return Count;
		}

		/// <summary>
		/// Улучшенная сортировка пузырьком
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static int[] PuzirokV2(int[] a)
		{
			
			int i = 0;
			bool c = true;
			while (c)
			{
				c = false;
				int j = 0;
				while ( j < a.Length - 1)
				{
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
						c = true;
					}
					j++;
				}
				i++;
			}
			return a;
		}

		/// <summary>
		/// Улучшенная шейкерная сортировка
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static int[] Shaker(int[] a)
		{
			int i = 0;
			int c = 1;
			int j;
			while (c == 1 && i < a.Length / 2)
			{
				c = j = 0;
				while (j < a.Length - 1)
				{
					if (a[j] > a[j + 1])
					{
						int temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
					j++;
				}
				j = a.Length - 1;
				while (j > 1)
				{
					if (a[j] < a[j - 1])
					{
						int temp = a[j - 1];
						a[j - 1] = a[j];
						a[j] = temp;
						c = 1;
					}
					j--;
				}
				i++;
			}
			return a;
		}

		/// <summary>
		/// Функция вывода массива в консоль
		/// </summary>
		/// <param name="a"></param>
		public static void Show(int[] a)
		{
			foreach (int item in a)
			{
				Console.WriteLine(item);
			}
		}

		/// <summary>
		/// Создает массив и заполняет его рандомными числами
		/// </summary>
		/// <param name="v"></param> размер
		/// <returns></returns>
		public static int[] CreateMassive(int v)
		{
			int[] mass = new int[v];

			Random r = new Random();

			int i = 0;
			while (i < v)
			{
				mass[i] = r.Next(1000);
				i++;
			}
			return mass;
		}

		
	}
}
