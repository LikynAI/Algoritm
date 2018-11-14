using System;
using System.Collections;
using System.Collections.Generic;
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

		public bool ObhodVGlubinu(int start,int end)
		{
			int[] vs = new int[matrix.GetLength(0)];
			vs[start] = 1;
			Stack<int> tempo = new Stack<int>();

			while (true)
			{
				for (int i = 0; i < matrix.Length; i++)
				{
					if (matrix[start, i] > -1)
					{
						if (vs[i] == 0)
						{
							tempo.Push(i);
						}
						vs[i] = 1;
					}
				}
				if (tempo.Count == 0) { break; }
				start = tempo.Pop();
			}

			if (vs[end] == 1) { return true; }
			else return false;
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
				string tempo = string.Empty;
				for (int j = 0; j < line.Length; i++)
				{
					while (line[j] != ';')
					{
						tempo += line[j];
					}
					matrix[i, j] = int.Parse(tempo);
				}
			}
			sr.Close();
			
		}

		public void Save(string path)
		{
			StringBuilder s = new StringBuilder();
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(0); j++)
				{
					if ( matrix[i, j] > -1 ) { s.Append(matrix[i,j] + ";"); }
					else { s.Append(";"); }
					
				}
				s.AppendLine();
			}
			StreamWriter sw = new StreamWriter(path);
			sw.Write(s);
			sw.Close();
		}
	}
}
