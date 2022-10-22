using System;
namespace GuideCSharp.Classes.Methods.OutParameters
{
	public class OutParam
	{
		public OutParam()
		{
            var calc = new Calc();
            calc.GetSum(out var sum, 5, 3);
            //sum is 8

            Console.WriteLine(sum);
        }
	}

    class Calc
    {
        public void GetSum(out int sum, int n1, int n2)
        {
            sum = n1 + n2;
        }
    }
}

