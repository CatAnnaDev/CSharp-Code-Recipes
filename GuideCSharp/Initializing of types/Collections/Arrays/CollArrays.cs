using System;
namespace GuideCSharp.Initializingoftypes.Collections.Arrays
{
	public class CollArrays
	{
        record Employee(string FirstName, string LastName);

        public CollArrays()
		{
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19 };

            //Array of string
            var gameList = new[] { "soccer", "hockey", "basketball" };

            //Array of Employee class (another way)
            var employees = new[] {
                new Employee("Anton", "Pavlov"),
                new Employee("Elena", "Kirienko")
            };

            Console.WriteLine(string.Join("; ", primeNumbers));
            Console.WriteLine(string.Join("; ", gameList));
            Console.WriteLine(employees);

            
        }
	}
}

