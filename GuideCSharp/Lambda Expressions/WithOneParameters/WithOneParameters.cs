using System;
namespace GuideCSharp.LambdaExpressions.WithOneParameters
{
	public class WithOneParameters
	{
		public WithOneParameters()
		{
            //explicitly specify return type
            var powOfTwo = new Func<int, int>(
                (int power) => (int)Math.Pow(2, power)
            );
            var pow8 = powOfTwo(8);
            //pow8 is 256

            //implicitly specify return type
            Func<double, double> powOfThree = power => Math.Pow(3, power);
            var pow3 = powOfThree(3);
            //pow3 is 27.0

            Console.WriteLine($"pow8 = {pow8}");
            Console.WriteLine($"pow3 = {pow3}");
        }
	}
}

