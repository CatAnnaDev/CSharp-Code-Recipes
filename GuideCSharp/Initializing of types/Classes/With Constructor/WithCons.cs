using System;
namespace GuideCSharp.Initializingoftypes.Classes.WithConstructor
{
	public class WithCons
	{
		public WithCons()
		{
            var nokiaPhone = new Phone("Nokia 6610");
            var kim = new Employee("Victorya", "Kim", new("iPhone 5"));

            Console.WriteLine(nokiaPhone.Model);
            Console.WriteLine(kim.PersonalPhone.Model);
        }
	}

    class Phone
    {
        public string Model { get; set; }

        public Phone(string model) => Model = model;
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone PersonalPhone { get; set; }

        public Employee(string firstName, string lastName, Phone personalPhone) =>
        (FirstName, LastName, PersonalPhone) = (firstName, lastName, personalPhone);
    }
}

