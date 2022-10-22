using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.ifelsestatements.Ternaryoperator
{
	public class TernOpe
	{
		public TernOpe()
		{
            int GetNumber()
            {
                return -42;
            }

            var n = GetNumber();
            string classify = (n > 0) ? "positive" : "negative";
            //classify is "negative"

            Console.WriteLine(classify);
        }
	}
}

