using System;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			Graf g = new Graf("g.txt",4);

			g.Show();
			Console.WriteLine();

			int[] i = g.FindMinPathFrom(2);

			foreach (int j in i)
			{
				Console.WriteLine(j);
			}

			Console.ReadLine();
		}
	}
}
