using System;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{

			//DateTime t = DateTime.Now;
			//for (int i = 0; i < 5000; i++)
			//{
			//	int[] array = GetRandomArray(100000, 100);
			//	QuickSort(array,0, array.Length-1);
			//}
			//Console.WriteLine(DateTime.Now - t);

			//t = DateTime.Now;
			//for (int i = 0; i < 5000; i++)
			//{
			//	int[] array = GetRandomArray(100000, 100);
			//	quicksort(array, 0, array.Length - 1);
			//}
			//Console.WriteLine(DateTime.Now - t);

			int[] array = GetRandomArray(1000, 10);
			simpleCountingSort(array, 1000);

			Console.ReadLine();
		}

		public static void simpleCountingSort(int[] A, int k) // где k – длина массива А,										  // а 1000 – его максимальное значение
		{
			int[] C = new int[k];
			for (int i = 0; i < k; i++)
				C[i] = 0;
			for (int i = 0; i < 1000; i++)
				C[A[i]]++;
			int b = 0;
			for (int j = 0; j < k; j++)
				for (int i = 0; i < C[j] - 1; i++)
					A[b++] = j;
		}

		private static void Puzirok(int[] a)
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
		}


		/// <summary>
		/// Улучшенная сортировка пузырьком
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static void PuzirokV2(int[] a)
		{

			int i = 0;
			bool c = true;
			while (c)
			{
				c = false;
				int j = 0;
				while (j < a.Length - 1)
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
		}

		/// <summary>
		/// Улучшенная шейкерная сортировка
		/// </summary>
		/// <param name="a"></param>
		/// <returns></returns>
		private static void Shaker(int[] a)
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
		}

		public static void min(int[] arr,int start)
		{
			if (start != arr.Length)
			{
				int tempo = arr[start];
				int memoryofindex = start;
				for (int i = start; i < arr.Length; i++)
				{
					if (tempo > arr[i])
					{
						tempo = arr[i];
						memoryofindex = i;
					}
				}
				arr[memoryofindex] = arr[start];
				arr[start] = tempo;

				min(arr, start + 1);
				
			}
		}

		/// <summary>
		/// возвращает массив заданной размерности и заполняет его рандомными значениями
		/// </summary>
		/// <param name="length"></param>
		/// <param name="maxValue"></param>
		/// <returns></returns>
		public static int[] GetRandomArray(int length,int maxValue)
		{
			Random r = new Random();

			int[] ar = new int[length];
			for (int i = 0; i < length; i++)
			{
				ar[i] = r.Next(maxValue);
			}
			return ar;
		}

		/// <summary>
		/// мой способ реализации быстрой сортировки
		/// </summary>
		/// <param name="array"></param>
		/// <param name="start"></param>
		/// <param name="end"></param>
		public static void QuickSort(int[] array, int start, int end)
		{
			if (start < end)
			{
				int OpEl = array[end];

				int _start = start;
				int _end = end;

				while (start < end)
				{
					while (start < end && array[start] <= OpEl) { start++; }
					while (end > start && array[end] > OpEl) { end--; }

					if (start < end)
					{
						int tempo = array[start];
						array[start] = array[end];
						array[end] = tempo;

					}
				}
					QuickSort(array, _start, --end);
					QuickSort(array, start, _end);			
			}
		}
	}
}
