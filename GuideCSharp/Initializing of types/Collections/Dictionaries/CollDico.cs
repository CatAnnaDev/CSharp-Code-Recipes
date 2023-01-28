using System;
using System.Collections.Generic;

namespace GuideCSharp.Initializingoftypes.Collections.Dictionaries
{
	public class CollDico
	{
        record Employee(string FirstName, string LastName);

        public CollDico()
		{
            //Dictionary<String, String>
            var languages = new Dictionary<string, string> {
                {"ru", "russian"},
                {"en", "english"}
            };

            //Dictionary<Int, String>
            var numbers = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = "three"
            };

            //Dictionary<Int, Employee>
            var employees = new Dictionary<int, Employee> {
                {1, new Employee("Anton", "Pavlov")},
                {2, new Employee("Elena", "Kirienko")}
            };

            Console.WriteLine(languages);
            Console.WriteLine(numbers);
            Console.WriteLine(employees);
        }
	}
}

