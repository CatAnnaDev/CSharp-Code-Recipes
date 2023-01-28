using System;
namespace GuideCSharp.LambdaExpressions.FunctionAsAParameter
{
	public class FunctionAsAParameter
	{
		public FunctionAsAParameter()
		{
            var numbers = new[] { 1, 3, 2 };
            Array.Sort(numbers, (a, b) => b - a);
            //numbers is {3, 2, 1}

            Console.WriteLine(string.Join(", ", numbers));
        }
	}
}

