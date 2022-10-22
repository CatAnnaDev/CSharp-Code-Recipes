using System;
namespace GuideCSharp.Classes.Methods.Withreturnvalues
{
	public class WithReturnValue
	{
		public WithReturnValue()
		{
            var sum = Calc.GetSum(5, 3);
            //sum is 8

            Console.WriteLine("{0},", sum);
        }
	}

    class Calc
    {
        public static int GetSum(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}

