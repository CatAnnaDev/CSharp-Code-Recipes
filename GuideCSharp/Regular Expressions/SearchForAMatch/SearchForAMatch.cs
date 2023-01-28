using System;
using System.Text.RegularExpressions;

namespace GuideCSharp.RegularExpressions.SearchForAMatch
{
	public class SearchForAMatch
	{
		public SearchForAMatch()
		{
            var data = "Pi is equal to 3.14";
            var pattern = @"\d+\.\d+";
            var match = Regex.Match(data, pattern);
            if (match.Success)
            {
                var pi = Double.Parse(match.Value);
                //pi is 3.14

                Console.WriteLine(pi);
            }
        }
	}
}

