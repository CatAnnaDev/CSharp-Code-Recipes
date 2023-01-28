using System;
using System.Linq;

namespace GuideCSharp.LINQ.ElementOperators.LastOperator
{
	public class LastOperator
	{
		public LastOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            int last = numbers.Last();
            //first is 5

            int lastEven = numbers.Last(n => n % 2 == 0);
            //firstEven is 4

            //int lastError = numbers.Last(n => n > 10);//<-Error

            int lastDefault = numbers.LastOrDefault(n => n > 10);
            //lastDefault is 0

            Console.WriteLine(last);
            Console.WriteLine(lastEven);
            Console.WriteLine(lastDefault);
        }
	}
}

