using System;
namespace GuideCSharp.Exceptionshandling.ThrowExpressions
{
	public class ThrowExpr
	{
		public ThrowExpr()
		{
            var numbers = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = null
            };

            var three = numbers[3] ?? throw new Exception("no such element");

            Console.WriteLine(three);
        }
	}
}

