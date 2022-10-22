using System;
namespace GuideCSharp.Controlflow.loops.foreachloop
{
	public class ForeachLoop
	{
		public ForeachLoop()
		{
            var numbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            //sum is 77

            Console.WriteLine(sum);
        }
	}
}

