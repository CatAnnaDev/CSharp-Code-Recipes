using System;
namespace GuideCSharp.Controlflow.interruptionofacontrolflow.returnstatement.withreturnvalue
{
	public class withValue
	{
		public withValue()
		{
            bool ContainNumber(int[] numbers, int number)
            {
                foreach (var currentNumber in numbers)
                {
                    if (currentNumber == number)
                    {
                        return true;
                    }
                }
                return false;
            }

            int[] numbers = { 1, 2, 3 };
            var isContain2 = ContainNumber(numbers, 2);
            //isContain2 is true

            var isContain4 = ContainNumber(numbers, 4);
            //isContain4 is false

            Console.WriteLine("{0}, {1}", isContain2, isContain4);
        }
	}
}

