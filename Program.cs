using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp7
{
	class Program
	{
		static void Main(string[] args)
		{
			Graf g = new Graf("g.txt",4);

			g.Show();
			Console.WriteLine();

			int[] i = g.FindMinPathFrom(0);

			foreach (int j in i)
			{
				Console.WriteLine(j);
			}

			Console.ReadLine();
		}
	}
}
