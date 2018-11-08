using System;

namespace ConsoleApp5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(Skobki("{s+3*(2-7)}/[14 - 4 * 4]")); 

			Console.ReadLine();
		}

		private static bool Skobki(string v)
		{
			Stack _1 = new Stack();

			for (int i = 0; i < v.Length; i++)
			{
				char temp = v[i];
				if (temp == '{' || temp == '[' || temp == '(')
				{
					_1.Push(temp);
				}
				else if (temp == '}' || temp == ']' || temp == ')')
				{
					if (temp == ')') { char lastopened = Convert.ToChar(_1.Pop()); if (lastopened != '(') { return false; } }
					if (temp == ']') { char lastopened = Convert.ToChar(_1.Pop()); if (lastopened != '[') { return false; } }
					if (temp == '}') { char lastopened = Convert.ToChar(_1.Pop()); if (lastopened != '{') { return false; } }
				}
			}
			if (!_1.Empty()) { return false; }
			else return true;
		}

		private static void To01(int v)
		{
			Stack s = new Stack();
			for (int i = 0; v != 0; i++)
			{
				s.Push(v % 2);
				v /= 2;
			}

			s.Show();
		}
	}
}
