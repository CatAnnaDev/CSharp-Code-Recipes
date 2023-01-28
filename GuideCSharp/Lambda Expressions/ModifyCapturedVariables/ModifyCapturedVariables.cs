using System;
namespace GuideCSharp.LambdaExpressions.ModifyCapturedVariables
{
	public class ModifyCapturedVariables
	{
		public ModifyCapturedVariables()
		{
            var x = 5;

            Action<int> addYtoX = y => x += y;
            addYtoX(3);
            //x is 8

            Console.WriteLine(x);
        }
	}
}

