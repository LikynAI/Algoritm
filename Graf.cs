using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

/// <summary>
/// на вход программа получает матрицу в которой -1 означает отсутствие дорогииз пункта в пункт
/// </summary>
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
				for (int i = 0; i < matrix.GetLength(0); i++)
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

		public Graf(string path, int R)
		{
			StreamReader sr = new StreamReader(path);
			string line;

			matrix = new int[R,R];
			for (int i = 0; i < R; i++)
			{
				line = sr.ReadLine();
				string tempo = string.Empty;
				int lineruner = 0;
				for (int j = 0; j < R; j++)
				{
					while (line[lineruner] != ';')
					{
						tempo += line[lineruner];
						lineruner++;
					}
					if (tempo != string.Empty)
					{
						matrix[i, j] = int.Parse(tempo);
					}
					tempo = string.Empty;
					lineruner++;
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
					s.Append(matrix[i, j] + ";");
				}
				s.AppendLine();
			}
			StreamWriter sw = new StreamWriter(path);
			sw.Write(s);
			sw.Close();
		}

		public int[] FindMinPathFrom(int start)
		{
			int rememb = start;
			int[] puti = new int[matrix.GetLength(0)];
			Stack<int> next = new Stack<int>();

			while (true)
			{
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					if (matrix[start, i] != -1 && matrix[start, i] != 0)
					{
						if ((matrix[start, i]+puti[start] < puti[i] || puti[i] == 0) )
						{
							puti[i] = matrix[start, i] + puti[start];							
							next.Push(i);						
						}
					}
				}
				if (next.Count == 0) { break; }
				start = next.Pop();
			}
			puti[rememb] = 0;
			return puti;
		}
	}
}
