using System;
namespace GuideCSharp.LambdaExpressions.Recursion
{
	public class Recursion
	{
		public Recursion()
		{
            Func<int, int> fibonacci = null;
            fibonacci = (int x) => x <= 1 ? x : fibonacci(x - 1) + fibonacci(x - 2);

            int f10 = fibonacci(10);
            //f10 is 55
            Console.WriteLine($"f10 is {f10}");
        }
	}
}

