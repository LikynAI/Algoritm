using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			Stack stack = new Stack();

			for (int i = 0; i < 20; i++)
			{
				stack.Push(i);
			}

			for (int i = 0; i < 9; i++)
			{
				stack.Pop();
			}

			for (int i = 0; i < 9; i++)
			{
				stack.Push(i);
			}

			for (int i = 0; i < 13; i++)
			{
				Console.WriteLine(stack.Pop());
			}

			Console.ReadLine();
		}
	}
}
