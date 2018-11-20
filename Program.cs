using System;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{

			DateTime t = DateTime.Now;

			int[] array = GetRandomArray(100000, 1000);

			Shell(array);

			Console.WriteLine((DateTime.Now - t));
			Console.ReadLine();
		}

		public static void Vstavki(int[] array) 
		{
			for (int i = 0; i < array.Length; i++)
			{
				int temp = array[i];
				int j = i;
				while (j > 0 && array[j - 1] > temp)
				{
					array[j] = array[j - 1];
					array[j - 1] = temp;
					j--;
				}
			}
		}

		public static void VstavkiV2(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < array[i - 1])
				{
					
					int SerchingElement = array[i];

					int index = BinSearch(array, SerchingElement, i);

					while (index > 0 && array[index] >= SerchingElement )
					{
						index--;
					}

					int j = 0;

					if (index == -1)
					{
						while (i > j )
						{
							array[i - j] = array[i - j - 1];
							j++;
						}
						array[i - j] = SerchingElement;
					}else
					{
						while (i - index > j + 1)
						{
							array[i - j] = array[i - j - 1];
							j++;
						}
						array[i - j] = SerchingElement;
					}
				}
			}
		}

		private static int BinSearch(int[] a, int b, int end)
		{
			int L = 0;
			int R = end-1;
			int m = R / 2;
			while (L <= R && a[m] != b)
			{
				if (a[m] < b)
					L = m + 1;
				else
					R = m - 1;
				m = L + (R - L) / 2;
			}
			return R;
		}

		public static void Shell(int[] array)
		{
			int temp = array.Length;
			while(temp != 0)
			{
				temp = temp / 2;

				for (int i = 0; i < temp; i++)
				{
					for (int j = temp+i; j < array.Length; j += temp)
					{
						if (array[j] < array[j - temp])
						{
							int temp0 = array[j];
							array[j] = array[j - temp];
							array[j - temp] = temp0;
						}
					}
				}				
			}
			VstavkiV2(array);
		}

		public static void CountingSort(int[] array)
		{
			int max = array[0];
			for (int i = 0; i < array.Length; i++)
			{
				if (max < array[i]) { max = array[i]; }
			}

			int[] counter = new int[max+1];

			for (int i = 0; i <array.Length; i++)
			{
				counter[array[i]]++;
			}

			int j = 0;

			for (int i = 0; i < counter.Length; i++)
			{
				if (counter[i] != 0)
				{
					for (int tempo = 0; tempo < counter[i]; j++, tempo++)
					{
						array[j] = i;
					}
				}
			}
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
		/// <param name="array"></param>
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
		/// <param name="array"></param>
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
