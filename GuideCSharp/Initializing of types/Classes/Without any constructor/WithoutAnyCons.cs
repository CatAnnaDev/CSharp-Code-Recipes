using System;
namespace GuideCSharp.Initializingoftypes.Classes.Withoutanyconstructor
{
	public class WithoutAnyCons
	{
		public WithoutAnyCons()
		{
            var nokiaPhone = new Phone { Model = "Nokia 6610" };

            var kim = new Employee
            {
                FirstName = "Victorya",
                LastName = "Kim",
                PersonalPhone = new() { Model = "iPhone 5" }
            };

            Console.WriteLine(nokiaPhone.Model);
            Console.WriteLine(kim.PersonalPhone.Model);
        }
	}

    class Phone
    {
        public string Model { get; set; }
    }

    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Phone PersonalPhone { get; set; }
    }
}

