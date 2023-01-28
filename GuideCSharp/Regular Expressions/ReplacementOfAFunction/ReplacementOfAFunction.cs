using System;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.ReplacementOfAFunction
{
	public class ReplacementOfAFunction
	{
		public ReplacementOfAFunction()
		{
            var data = "Pi = 3.14, exponent = 2.718";
            var pattern = @"\d+\.\d+";
            data = Regex.Replace(data, pattern, "<f>$0</f>");
            //data is "Pi = <f>3.14</f>, exponent = <f>2.718</f>"

            Console.WriteLine(data);

        }
    }
}

