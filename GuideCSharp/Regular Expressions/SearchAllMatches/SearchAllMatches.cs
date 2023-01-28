using System;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.SearchAllMatches
{
	public class SearchAllMatches
	{
		public SearchAllMatches()
		{
            var data = "Pi = 3.14, exponent = 2.718";
            var pattern = @"\d+\.\d+";
            var matchs = Regex.Matches(data, pattern);
            //matchs[0].Value is 3.14
            //matchs[1].Value is 2.718

            Console.WriteLine(matchs.Count);
            Console.WriteLine(matchs[0].Value);
            Console.WriteLine(matchs[1].Value);
        }
	}
}

