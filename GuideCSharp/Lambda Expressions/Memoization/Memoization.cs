using System;
namespace GuideCSharp.LambdaExpressions.Memoization
{
	public class Memoization
	{
		public Memoization()
		{
            Func<I, U> Memoize<I, U>(Func<I, U> fun)
            {
                var memo = new Dictionary<I, U>();
                return x => {
                    if (memo.ContainsKey(x))
                    {
                        return memo[x];
                    }
                    var r = fun(x);
                    memo[x] = r;
                    return r;
                };
            }

            int Fibonacci(int x)
            {
                return x <= 1 ? x :
                Fibonacci(x - 1) + Fibonacci(x - 2);
            }

            Func<int, int> memFibonacci = Memoize<int, int>(
                Fibonacci);

            DateTime start;
            double milliseconds;
            for (int i = 1; i <= 2; i++)
            {
                start = DateTime.Now;
                var f37 = memFibonacci(37);
                milliseconds = (DateTime.Now - start).TotalMilliseconds;

                Console.WriteLine($"{i}: f37 is {f37}");
                Console.WriteLine($"{i}: milliseconds is {milliseconds}");
            }
            // prints:
            // 1: f37 is 24157817
            // 1: milliseconds is 397,0302
            // 2: f37 is 24157817
            // 2: milliseconds is 0,1594

            start = DateTime.Now;
            var f38 = memFibonacci(38);
            milliseconds = (DateTime.Now - start).TotalMilliseconds;

            Console.WriteLine($"f38 is {f38}");
            Console.WriteLine($"milliseconds is {milliseconds}");
            // f38 is 39088169
            // milliseconds is 707,5712
        }
    }
}

