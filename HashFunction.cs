using System;

namespace ConsoleApp6
{
	public class HashFunction
	{
		public static int Do(string s)
		{
			int[] tempo = new int[s.Length];
			for (int i = 0; i < s.Length; i++)
			{
				tempo[i] = s[i]*s[i]*(i+1)/3+17;
			}

			int Hash = 0;

			foreach (int i in tempo)
			{
				Hash += i;
			}

			return Hash;
		}
	}
}
