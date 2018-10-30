using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Converter
	{
		static int a = 0;
		public static int to01(int v)
		{
			if (v != 0)
			{
				a += to01(v / 2) * 10 + v % 2;
			}
			return a;
		}
	}
}
