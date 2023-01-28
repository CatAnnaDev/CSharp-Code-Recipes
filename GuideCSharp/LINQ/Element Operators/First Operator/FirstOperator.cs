using System;
namespace GuideCSharp.LINQ.ElementOperators.FirstOperator
{
	public class FirstOperator
	{
		public FirstOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };

            int first = numbers.First();
            //first is 1

            int firstEven = numbers.First(n => n % 2 == 0);
            //firstEven is 2

            //int firstError = numbers.First(n => n > 10);//<-Error

            int firstDefault = numbers.FirstOrDefault(n => n > 10);
            //lastDefault is 0

            Console.WriteLine(first);
            Console.WriteLine(firstEven);
            Console.WriteLine(firstDefault);
        }
	}
}

