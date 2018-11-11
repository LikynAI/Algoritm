using System;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			Tree t = new Tree("10(7(5(1,6),8),15(12(11,14),16))",20);

			Console.WriteLine(t.tree[t.Find(12)]);
			Console.ReadLine();
		}
	}
}
