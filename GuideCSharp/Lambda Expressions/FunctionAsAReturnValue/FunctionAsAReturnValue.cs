using System;
namespace GuideCSharp.LambdaExpressions.FunctionAsAReturnValue
{
	public class FunctionAsAReturnValue
	{
		public FunctionAsAReturnValue()
		{
            Func<int, int, int> MakeSum()
            {
                return (a, b) => a + b;
            }

            var sumFunc = MakeSum();
            var sum = sumFunc(5, 8);
            //sum is 13

            Console.WriteLine("{0}", sum);
        }
	}
}

