using System;
namespace GuideCSharp.Classes.Constructors.Replacementoftheparentconstructor
{
	public class ReplaceParent
	{
		public ReplaceParent()
		{
            var employee = new Employee("Max");
            //employee.position is "unknown"

            Console.WriteLine(employee.Position);
        }

        class Man
        {
            public string Name { get; }

            public Man(string name)
            {
                Name = name;
            }
        }

        class Employee : Man
        {
            public string Position { get; }

            public Employee(string name) : base(name)
            {
                Position = "unknown";
            }
        }
    }
}

