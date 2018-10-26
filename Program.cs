using System;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			int counter = 0;
			_3(3, 20,ref counter);
			Console.WriteLine(counter);
			Console.ReadLine();
		}

		private static void _3(int a, int b, ref int counter)
		{
			if (a < b)
			{
				_3(a * 2, b, ref counter);
				_3(a + 1, b, ref counter);
			}
			else if (a == b) { counter++; } 
		}

		private static int PowV2(int a, int b)
		{
			int tempo = a;
			for (int i = 1; i < b; i++)
			{
				a *= tempo;
			}
			return a;
		}

		private static int Pow(int a, int b)
		{
			if (b > 1)
			{
				a = a * Pow(a, b-1);
			}
			return a;
		}

		private static int to01(int v,ref int a)
		{
			if (v != 0)
			{
				a += to01(v/2, ref a)*10 + v % 2;
			}
			return a;
		}
	}
}
