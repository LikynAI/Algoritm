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
			Graf g = new Graf(3);

			g.Save("g.txt");

			g.Show();
			Console.ReadLine();
		}
	}
}
