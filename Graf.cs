using System;
using System.IO;
using System.Text;


namespace ConsoleApp7
{
	public class Graf
	{
		public int[,] matrix { get; private set; }

		public Graf() { }

		public Graf(int v)
		{
			matrix = new int[v, v];

			for (int i = 0; i < v; i++)
			{
				matrix[i, i] = 0;
			}
		}

		public void Add(int p1, int p2, int weight)
		{
			matrix[p1, p2] = weight;
			matrix[p2, p1] = weight;
		}

		public void ObhodVGlubinu()
		{

		}

		public void Show()
		{

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					Console.Write(matrix[i,j]+" ");
				}
				Console.WriteLine();
			}
		}

		public Graf(string path)
		{
			StreamReader sr = new StreamReader(path);
			string line = sr.ReadLine();

			matrix = new int[line.Length, line.Length];
			for (int i = 0; sr.EndOfStream; i++)
			{
				line = sr.ReadLine();
				for (int j = 0; j < line.Length; i++)
				{
					matrix[i, j] = line[j];
				}
			}
			
		}

		public void Save(string path)
		{
			StringBuilder s = new StringBuilder();
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					if (matrix[i,j] == 1) { s.Append("1"); }
					else { s.Append("0"); }
					
				}
				s.AppendLine();
			}
			StreamWriter sw = new StreamWriter(path);
			sw.Write(s);
			sw.Close();
		}
	}
}
