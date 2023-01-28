using System;
using System.Threading;
using System.Threading.Tasks;

namespace GuideCSharp.MultiThreadedOperations.UsingOftheParallelClass
{
	public class UsingOftheParallelClass
	{
		public UsingOftheParallelClass()
		{
            void ShowNumber(int number)
            {
                Thread.Sleep(500);
                Console.WriteLine(number);
            }

            var numbers = new[] { 2, 3, 5, 7, 11, 13, 17 };
            //run ShowNumber for each number in numbers
            //using parallel computing
            Parallel.ForEach(numbers, ShowNumber);
        }
	}
}

