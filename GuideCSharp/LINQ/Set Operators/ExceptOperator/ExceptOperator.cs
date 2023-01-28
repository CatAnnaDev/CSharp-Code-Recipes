using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.SetOperators.ExceptOperator
{
	public class ExceptOperator
	{
		public ExceptOperator()
		{
            int[] ar1 = { 1, 2, 3 };
            int[] ar2 = { 3, 5, 7 };
            var result1 = ar1.Except(ar2);
            //result1 is { 1, 2 }

            var result2 = ar2.Except(ar1);
            //result2 is { 5, 7 }

            Console.WriteLine(JsonSerializer.Serialize(result1));
            Console.WriteLine(JsonSerializer.Serialize(result2));

        }
    }
}

