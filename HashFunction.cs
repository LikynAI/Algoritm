using System;

namespace ConsoleApp6
{
	public class HashFunction
	{
		/// <summary>
		/// Функция хеширующая строку
		/// </summary>
		/// <param name="s"></param>
		/// <returns></returns>
		public static int Do(string s)
		{
			int Hash = 0;
			for (int i = 0; i < s.Length; i++)
			{
				Hash += s[i]*s[i]*(i+1)+17;
			}
			return Hash;
		}
	}
}
