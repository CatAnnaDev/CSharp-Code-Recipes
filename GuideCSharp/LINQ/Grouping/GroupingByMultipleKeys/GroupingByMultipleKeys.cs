using System;
using System.Linq;

namespace GuideCSharp.LINQ.Grouping.GroupingByMultipleKeys
{
	public class GroupingByMultipleKeys
	{
		public GroupingByMultipleKeys()
		{
            var names = new[] {
                "Andrei", "Boris", "Alexey"
            };

            var query =from n in names group n by new
                {
                    StartWith = n[0],
                    n.Length
                };

            foreach (var row in query)
            {
                Console.WriteLine("StartWith: " +row.Key.StartWith);
                Console.WriteLine("Length: " +row.Key.Length);
                foreach (var name in row)
                {
                    Console.WriteLine("  - " + name);
                }
            }
            //output is:
            //StartWith: A
            //Length: 6
            //  - Andrei
            //  - Alexey
            //StartWith: B
            //Length: 5
            //  - Boris
        }
    }
}

