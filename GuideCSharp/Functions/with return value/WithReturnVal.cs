using System;
namespace GuideCSharp.Functions.withreturnvalue
{
	public class WithReturnVal
	{
		public WithReturnVal()
		{
            int GetSum(int n1, int n2)
            {
                return n1 + n2;
            }

            var sum = GetSum(5, 3);
            //sum is 8

            Console.WriteLine("sum = {0},", sum);
        }
	}
}

