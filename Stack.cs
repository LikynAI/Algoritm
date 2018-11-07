using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Stack
	{
		int[] vs = new int[13];
		int start = -1;
		int end = 12;

		public void Push(int a)
		{
			if (start == 12) { start = 0; }
			else { start++; }
			vs[start] = a;

			if (start == end) { end++; }
			if (end == 13) { end = 0; }
		}

		public int Peek()
		{
			if (start == end) { throw new IndexOutOfRangeException(); };
			return vs[start];
		}

		public int Pop()
		{
			if (start == end) { throw new IndexOutOfRangeException(); };

			int a = start;

			if (start == 0) { start = 12; }
			else { start--; }

			if (start == end) { end--; }
			if (end == -1) { end = 12; }

			return vs[a];
		}
	}
}
