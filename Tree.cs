using System;
using System.Collections.Generic;

/// <summary>
/// 2. Переписать программу, реализующее двоичное дерево поиска.
///а) Добавить в него обход дерева различными способами;
///б) Реализовать поиск в двоичном дереве поиска;
///в) * Добавить в программу обработку командной строки с помощью которой можно указывать
///'/*из какого файла считывать данные, каким образом обходить дерево.
/// </summary>

namespace ConsoleApp6
{
	class Tree
	{
		public int[] tree ;

		public Tree(string s, int v)
		{
			tree = new int[v];
			tree[0] = v;

			int treenum = 1;
			Stack<int> t = new Stack<int>();
			string tempo = string.Empty;
			int sw = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (s[i] != '(' && s[i] != ')' && s[i] != ',')
				{
					tempo += s[i];
				}
				else
				{				
					if (tempo != string.Empty)
					{
						tree[treenum] = int.Parse(tempo);
						tempo = string.Empty;
					}
					if (s[i] == '(')
					{
						t.Push(treenum);
						treenum *= 2;
					}
					else if (s[i] == ')')
					{
						treenum = t.Pop();
					}
					else if (s[i] == ',')
					{
						treenum += 1;
					}
				}
			}
		}

		public int Find(int n)
		{
			int i = 1;
			while (i < tree.Length)
			{
				if (n < tree[i]) { i = i * 2; }
				else if (n > tree[i]) { i = i * 2 + 1; }
				else return i;
			}
			return -1;
		}

		public void rLR(int i)
		{
			Console.WriteLine(tree[i]);
			if (i * 2 < tree.Length) { rLR(i * 2); }
			if (i * 2 + 1 < tree.Length) { rLR(i * 2 + 1); }
		}

		public void LrR(int i)
		{
			Console.WriteLine(tree[i]);
			if (i * 2 < tree.Length) { rLR(i * 2); }
			if (i * 2 + 1 < tree.Length) { rLR(i * 2 + 1); }
		}
	}
}
