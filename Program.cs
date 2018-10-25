using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			_14(25);
			Console.ReadLine();
		}

		private static void _14(int v)
		{
			for (int i = 1; i <= v; i++)
			{
				for (int j = 1;  i*i / j != 0 ; j*=10)
				{
					if (i * i % j == i) { Console.WriteLine(i);break; } 
				}
			}
		}

		private static void _12(int v1, int v2, int v3)
		{
			if (v1 >= v2 && v1 >= v3) { Console.WriteLine(v2); }
			else if (v2 >= v3) { Console.WriteLine(v2); }
			else Console.WriteLine(v3);		
		}

		private static void _11()
		{
			int sum = 0;
			int count = 0;

			while (true)
			{
				int i = Convert.ToInt32(Console.ReadLine());

				if (i % 10 == 8) { sum += i; count++; }
				else if (i == 0) { Console.WriteLine(sum/count);break; }
			}
		}

		private static void _10(int v)
		{
			bool b = false;

			while (v != 0)
			{
				if (v % 2 == 1) { b = true; break; }
				v /= 10;
			}
			Console.WriteLine(b);
		}

		private static void _9(int v1, int v2)
		{
			int i;
			for (i = 0; v1 < v2; i++)
			{
				v1 -= v2; 
			}
			Console.WriteLine($"{v2} ост {v1}");
		}

		private static void _8(int a, int b)
		{
			if (a < b) { _3(a, b); }
			Console.WriteLine($"{a} {b}");

			for (int i = b; i <= a; i++)
			{
				Console.WriteLine($"{Math.Pow(a, i)} {Math.Pow(b, i)}");
			}	
		}

		private static void _7(int v1, int v2, int a1, int a2)
		{
			if (v1 % 2 == a1 % 2)
			{
				if (v2 % 2 == a2 % 2) { Console.WriteLine("Одного цвета"); }
				else { Console.WriteLine("Не одного цвета"); }
			}

			else
			{
				if (v2 % 2 == a2 % 2) { Console.WriteLine("Не одного цвета"); }
				else { Console.WriteLine("Одного цвета"); }
			}
		}

		private static void _6(int v)
		{
			if (v / 10 == 1) { Console.WriteLine(v + " лет"); }
			else
			{
				int vdev = v % 10;
				if (vdev == 1) { Console.WriteLine(v + " год"); }
				else if (vdev == 2 || vdev == 3 || vdev == 4) { Console.WriteLine(v + " года"); }
				else { Console.WriteLine(v + " лет"); }
			}
		}

		private static void _5(int v)
		{
			v++;
			if (v == 13) { v = 1; }

			if (v <= 3) { Console.WriteLine("Зима"); }
			else if (v <= 6) { Console.WriteLine("Весна"); }
			else if (v <= 9) { Console.WriteLine("Лето"); }
			else { Console.WriteLine("Осень"); }

		}

		private static void _4(int a, int b, int c)
		{
			double Dsqrt = Math.Sqrt(b * b - 4 * a * c);
			Console.WriteLine($"x1 = {-b - Dsqrt / a}");
			Console.WriteLine($"x2 = {-b + Dsqrt / a}");
		}

		private static void _3v2(int v1, int v2)
		{
			v1 += v2;
			v2 = v1 - v2;
			v1 -= v2; 
		}

		private static void _3(int v1, int v2)
		{
			int tempo = v1;
			v1 = v2;
			v2 = tempo;
		}

		private static void _2(int v1, int v2, int v3, int v4)
		{
			if (v1 > v2 && v1 > v3 && v1 > v4){ Console.WriteLine(v1); }
			else if (v2 >v3 && v2 >v4) { Console.WriteLine(v2); }
			else if (v3 > v4) { Console.WriteLine(v3); }
			else Console.WriteLine(v4);
		}

		private static void _1(int h, int m)
		{
			Console.WriteLine(m / (h * h));
		}
	}
}
