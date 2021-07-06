using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
	class Length
	{

		public static int Fin(int[] vs1, int[] vs2, int j = 0, int i = 0)
		{
			try
			{
				if (vs1.Length == 0 || vs2.Length == 0) { return 0; }
				else if (vs1[i] == vs2[j]) { return 1 + Fin(vs1, vs2, i+1, j+1); }
				else { return Math.Max(Fin(vs1, vs2, i, j+1), Fin(vs1, vs2, i+1, j)); }
			}
			catch { return 0; }
			}

			public static int Find(int[] vs1, int[] vs2)
		{
			int[,] mat = new int[vs1.Length+2, vs2.Length+2];

			for (int i = 2; i < mat.GetLength(0); i++)
			{
				mat[i, 0] = vs1[i - 2];
				mat[i, 1] = 0;
			}

			for (int i = 2; i < mat.GetLength(1); i++)
			{
				mat[0, i] = vs2[i - 2];
				mat[1, i] = 0;
			}
			int jtemp = 2;
			int count = 0;
			for (int i = 2; i < mat.GetLength(0); i++)
			{
				for (int j = jtemp; j < mat.GetLength(1); j++)
				{
					if (mat[i, 0] == mat[0, j])
					{
						mat[i, j] = ++count;
						i++;
						jtemp = ++j;
					}
					else { jtemp = ++j; break; }
				}
			}

			int invCount = 0;
			int itemp = 2;
			for (int j = 2; j < mat.GetLength(1); j++)
			{
				for (int i = itemp; i < mat.GetLength(0); i++)
				{
					if (mat[i, 0] == mat[0, j])
					{
						mat[i, j] = ++invCount;
						j++;
						itemp = ++i;
					}
				}
			}

			if (count > invCount) { return count; }
			else return invCount;
			
		}
	}
}
