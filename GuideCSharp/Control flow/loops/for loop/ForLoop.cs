using System;
namespace GuideCSharp.Controlflow.loops.forloop
{
	public class ForLoop
	{
		public ForLoop()
		{
            var sum10 = 0;
            for (var i = 1; i <= 10; i++)
            {
                sum10 += i;
            }
            //sum10 is 55 

            Console.WriteLine(sum10);
        }
	}
}

