using System;
namespace GuideCSharp.Functions.outparameters
{
	public class OutParam
	{
		public OutParam()
		{
            void GetSum(out int sum, int n1, int n2)
            {
                sum = n1 + n2;
            }

            GetSum(out var sum, 5, 3);
            //sum is 8

            Console.WriteLine(sum);
        }
	}
}

