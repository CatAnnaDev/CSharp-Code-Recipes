using System;
namespace GuideCSharp.LambdaExpressions.CaptureOfVariables
{
	public class CaptureOfVariables
	{
		public CaptureOfVariables()
		{
            Func<int, int> MakeWallet(int sum)
            {
                return pay => sum -= pay;
            }

            var payFromWallet1 = MakeWallet(1000);
            var payFromWallet2 = MakeWallet(500);
            var balance = payFromWallet1(50);
            //balans is 950
            Console.WriteLine(balance);

            balance = payFromWallet2(70);
            //balance is 430
            Console.WriteLine(balance);

            balance = payFromWallet1(150);
            //balans is 800
            Console.WriteLine(balance);
        }
	}
}

