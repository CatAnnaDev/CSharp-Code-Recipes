using System;
namespace GuideCSharp.LambdaExpressions.WithMultipleParameters
{
	public class WithMultipleParameters
	{
		public WithMultipleParameters()
		{
            Func<int, int, int> avgFunc = (a, b) => (a + b) / 2;
            var avg = avgFunc(3, 5);
            //avg is 4

            Console.WriteLine("{0}", avg);
        }
	}
}

