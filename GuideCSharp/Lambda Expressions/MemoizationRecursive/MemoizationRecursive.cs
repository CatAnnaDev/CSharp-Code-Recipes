using System;
using System.Collections.Generic;

namespace GuideCSharp.LambdaExpressions.MemoizationRecursive
{
	public class MemoizationRecursive
	{
		public MemoizationRecursive()
		{
            Func<I, U> Memoize<I, U>(Func<Func<I, U>, I, U> fun)
            {
                var memo = new Dictionary<I, U>();
                Func<I, U> memoFun = null;
                memoFun = x => {
                    if (memo.ContainsKey(x))
                    {
                        return memo[x];
                    }
                    var r = fun(memoFun, x);
                    memo[x] = r;
                    return r;
                };
                return memoFun;
            }

            Func<Func<int, int>, int, int> fib = (f, x) =>
            x > 1 ? f(x - 1) + f(x - 2) : x;
            Func<int, int> memFibonacci = Memoize(fib);

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
            // 1: milliseconds is 6,9103
            // 2: f37 is 24157817
            // 2: milliseconds is 0,0034

            start = DateTime.Now;
            var f38 = memFibonacci(38);
            milliseconds = (DateTime.Now - start).TotalMilliseconds;

            Console.WriteLine($"f38 is {f38}");
            Console.WriteLine($"milliseconds is {milliseconds}");
            // f38 is 39088169
            // milliseconds is 0,0013
        }
    }
}

