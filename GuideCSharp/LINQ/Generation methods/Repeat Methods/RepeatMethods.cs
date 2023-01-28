using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Generationmethods.RepeatMethods
{
	public class RepeatMethods
	{
		public RepeatMethods()
		{
            var numbers = Enumerable.Repeat(7, 3);
            //numbers is {7, 7, 7}

            Console.WriteLine(JsonSerializer.Serialize(numbers));
        }
	}
}

