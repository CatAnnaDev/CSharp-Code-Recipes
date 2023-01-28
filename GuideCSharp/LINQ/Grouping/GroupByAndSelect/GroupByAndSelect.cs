using System;
using System.Linq;

namespace GuideCSharp.LINQ.Grouping.GroupByAndSelect
{
	public class GroupByAndSelect
	{
		public GroupByAndSelect()
		{
            var chars = new[] {
                'A', 'B', 'C', 'B', 'A', 'B'
            };

            //first method
            var winner1 =
            chars.GroupBy(c => c).OrderByDescending(g => g.Count()).Select(g => g.Key).First();
            //winner1 is "B"

            //second method
            var winner2 = (from c in chars group c by c into g orderby g.Count() descending select g.Key).First();
            //winner2 is "B"

            Console.WriteLine(winner1);
            Console.WriteLine(winner2);

        }
    }
}

