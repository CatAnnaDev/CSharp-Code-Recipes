using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Filterringofelements.TaskAndSkipOperator
{
	public class TaskAndSkipOperator
    {
		public TaskAndSkipOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };
            numbers = numbers.Skip(1).Take(3).ToArray();
            //numbers is {2, 3, 4}

            Console.WriteLine(JsonSerializer.Serialize(numbers));
        }
	}
}

