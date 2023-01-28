using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.SetOperators.IntersectOperator
{
	public class IntersectOperator
	{
		public IntersectOperator()
		{
            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = { 3, 5, 7 };
            var result1 = ar1.Intersect(ar2);
            //result1 is { 3 }

            var result2 = ar2.Intersect(ar1);
            //result2 is { 3 }

            Console.WriteLine(JsonSerializer.Serialize(result1));
            Console.WriteLine(JsonSerializer.Serialize(result2));
        }
	}
}

