using System;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.CheckMatchWholeString
{
	public class CheckMatchWholeString
	{
		public CheckMatchWholeString()
		{
            var data1 = "aaab";
            var data2 = "aaaba";
            var pattern = @"\Aa+b\Z";
            var regex = new Regex(pattern);
            var b1 = regex.IsMatch(data1);
            //b1 is True

            var b2 = regex.IsMatch(data2);
            //b2 is False

            Console.WriteLine("{0} - {1}", b1, b2);
        }
	}
}

