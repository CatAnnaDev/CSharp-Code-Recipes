using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Generationmethods.EmptyMethods
{
	public class EmptyMethods
	{
		public EmptyMethods()
		{
            var empty = Enumerable.Empty<int>();
            var count = empty.Count();
            //count is 0

            int[][] arNumbers = {
                new [] {1, 2},
                new [] {3, 4},
                null
            };

            var numbers = arNumbers
                //.SelectMany(ar => ar) //<-Error
                .SelectMany(ar => ar ?? empty)
                .ToArray();
            //numbers2 is {1, 2, 3, 4}

            Console.WriteLine(count);
            Console.WriteLine(JsonSerializer.Serialize(numbers));

        }
    }
}

