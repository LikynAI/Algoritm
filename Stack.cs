using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
	class Stack
	{
		object[] vs = new object[13];
		int start = 0;
		int end = 0;

		public void Push(object a)
		{
			vs[start] = a;
			if (start == 12) { start = 0; }
			else { start++; }


			if (end == start){end++;}
			if (end == 13) { end = 0; }
		}

		public object Peek()
		{
			if (start == end) { throw new IndexOutOfRangeException(); };
			return vs[start];
		}

		public object Pop()
		{
			if (start == end) { throw new IndexOutOfRangeException(); };

			int a = --start;
			if (start == -1) { start = 12; }

			return vs[a];
		}

		public void Show()
		{
			while (start != end)
			{
				Console.WriteLine(vs[start--]);
				if (start == -1) { start = 12; }
			}
		}

		public bool Empty()
		{
			if (start == end) { return true; }
			else return false;
		}
	}
}
