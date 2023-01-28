using System;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.RegularExpressionOptions
{
	public class RegularExpressionOptions
	{
		public RegularExpressionOptions()
		{
            var data = "AaaA\r\naaaA";
            var pattern = "^(a+)$";
            var regex = new Regex(pattern, RegexOptions.IgnoreCase | RegexOptions.Multiline);
            var value = regex.Match(data).Value;
            //value is "aaaA"

            Console.WriteLine(value);

        }
    }
}

