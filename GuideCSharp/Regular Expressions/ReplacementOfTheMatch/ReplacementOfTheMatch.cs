using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.ReplacementOfTheMatch
{
	public class ReplacementOfTheMatch
	{
		public ReplacementOfTheMatch()
		{
            //"world" in hexadecimal format
            var data = "x77x6Fx72x6Cx64";
            var regex = new Regex("x([0-9A-F]{2})");

            MatchEvaluator charConverter = match => {
                var b = byte.Parse(match.Groups[1].Value, NumberStyles.AllowHexSpecifier);
                return ((char)b).ToString();
            };

            data = regex.Replace(data, charConverter);
            //data is "world"

            Console.WriteLine(data);

        }
    }
}

