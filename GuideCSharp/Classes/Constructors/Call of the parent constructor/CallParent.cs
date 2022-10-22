using System;
namespace GuideCSharp.Classes.Constructors.Calloftheparentconstructor
{
	public class CallParent
	{
		public CallParent()
		{
            var employee = new Employee("Max", "booker");

            Console.WriteLine("{0}, {1}",employee.Name, employee.Position);
        }

        class Man
        {
            public string Name { get; }

            protected Man(string name)
            {
                Name = name;
            }
        }

        class Employee : Man
        {
            public string Position { get; }

            public Employee(string name, string position) :
            base(name)
            {
                Position = position;
            }
        }
    }
}

