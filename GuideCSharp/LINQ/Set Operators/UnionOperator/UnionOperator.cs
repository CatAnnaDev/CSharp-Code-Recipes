using System;
namespace GuideCSharp.LINQ.SetOperators.UnionOperator
{
	public class UnionOperator
	{
		public UnionOperator()
		{
            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = { 3, 5, 7 };
            var result = ar1.Union(ar2);
            //result is { 1, 2, 3, 5, 7 }

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }
        }
	}
}

