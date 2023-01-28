using System;
namespace GuideCSharp.LambdaExpressions.WithOneReturnValue
{
	public class WithOneReturnValue
	{
		public WithOneReturnValue()
		{
            Action<int> add2AndPrint = a => Console.WriteLine(a + 2);
            add2AndPrint(5);
            //printed 7
        }
    }
}

