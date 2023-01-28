using System;
using System.Collections.Generic;

namespace GuideCSharp.Initializingoftypes.Collections.Othertypesofcollections
{
	public class CollOther
	{
        record Employee(string FirstName, string LastName);

        public CollOther()
		{
            //List of Double
            var doubleList = new List<Double> { 41.13, 2, 37.5 };

            //Stack of string
            var stringStack = new Stack<string>();
            stringStack.Push("one");
            stringStack.Push("two");

            //Queue of Employee
            var employeeQueue = new Queue<Employee>();
            employeeQueue.Enqueue(new Employee("Anton", "Pavlov"));

            Console.WriteLine(doubleList);
            Console.WriteLine(stringStack);
            Console.WriteLine(employeeQueue);
        }
	}
}

