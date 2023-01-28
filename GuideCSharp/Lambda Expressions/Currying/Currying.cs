using System;
namespace GuideCSharp.LambdaExpressions.Currying
{
	public class Currying
	{
		public Currying()
		{
            Func<A, Func<B, C>> Carry<A, B, C>(Func<A, B, C> f)
            {
                return a => b => f(a, b);
            }

            Func<int, int, int> avg = (a, b) => (a + b) / 2;
            var n1 = avg(1, 3);
            //n1 is 2

            //first universal method
            var avg1 = Carry(avg)(1);
            //avg1 is avg func with first param = 1
            var n2 = avg1(3);
            //n2 is 2 = (1 + 3)/2

            //second specialized method
            Func<int, Func<int, int>> curriedAvg = a => b => (a + b) / 2;
            var avg3 = curriedAvg(3);
            var n3 = avg3(3);
            //n3 is 3 = (3 + 3)/2

            Console.WriteLine($"n1 = {n1}");
            Console.WriteLine($"n2 = {n2}");
            Console.WriteLine($"n3 = {n3}");
        }
	}
}

