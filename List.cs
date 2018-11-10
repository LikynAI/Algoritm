using System;

namespace ConsoleApp5
{
	class List
	{
		public int[] vs = new int[13];
		int end = 0;
		int start = 0;

		public void Add(int a)
		{
			vs[end] = a;

			if (end == 12) { end = 0; }
			else { end++; }

			if (end == start) { start++; }
			if (start == 13) { start = 0; }
		}

		public int Last(int v)
		{
			if (v > 12){ throw new IndexOutOfRangeException(); }
			else return vs[start+v-1];
		}

		public void Show()
		{
			while (end != start)
			{
				start--;
				if (start == -1) { start = 12; }
				Console.WriteLine(vs[start]);
			}
		}

		public bool Empty()
		{
			if (start == end) { return true; }
			else return false;
		}
	}
}
