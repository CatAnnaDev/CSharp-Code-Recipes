using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Generationmethods.RangeMethods
{
	public class RangeMethods
	{
		public RangeMethods()
		{
            int[] numbers = Enumerable.Range(2, 4).ToArray();
            //numbers is {2, 3, 4, 5}

            Console.WriteLine(JsonSerializer.Serialize(numbers));
        }
	}
}

