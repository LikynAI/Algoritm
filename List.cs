using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public int Peek(int v)
		{
			if (v > 12){ throw new IndexOutOfRangeException(); }
			else return vs[start+v-1];
		}

		public void Show()
		{
			while (end != start)
			{
				Console.WriteLine(vs[end--]);
				if (end == -1) { end = 12; }
			}
		}
	}
}
