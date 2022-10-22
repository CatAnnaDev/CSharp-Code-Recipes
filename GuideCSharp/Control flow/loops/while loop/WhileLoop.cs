using System;
namespace GuideCSharp.Controlflow.loops.whileloop
{
	public class WhileLoop
	{
		public WhileLoop()
		{
            var i = 5;
            var f5 = 1;

            while (i > 1)
            {
                f5 *= i;
                i--;
            }
            //f5 is 120
            Console.WriteLine(f5);
        }
	}
}

