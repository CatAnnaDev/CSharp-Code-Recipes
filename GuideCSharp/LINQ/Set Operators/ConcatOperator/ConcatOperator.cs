using System;
using System.Linq;

namespace GuideCSharp.LINQ.SetOperators.ConcatOperator
{
	public class ConcatOperator
	{
		public ConcatOperator()
		{
            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = { 3, 5, 7 };
            var result = ar1.Concat(ar2);
            //result is { 1, 2, 3, 3, 5, 7 }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
	}
}

