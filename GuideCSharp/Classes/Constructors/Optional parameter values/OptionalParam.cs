using System;
namespace GuideCSharp.Classes.Constructors.Optionalparametervalues
{
	public class OptionalParam
	{
		public OptionalParam()
		{
            var man1 = new Man();
            //man1.Name is "unknown"
            //man1.Country is "unknown"

            var man2 = new Man("Vladimir");
            //man2.Name is "Vladimir"
            //man2.Country is "unknown"

            var man3 = new Man(country: "Brazil");
            //man3.Name is "unknown"
            //man3.Country is "Brazil"

            var man4 = new Man("Vladimir", "Brazil");
            //man4.Name is "Vladimir"
            //man4.Country is "Brazil"

            Console.WriteLine($"{man1.Name}, {man1.Country}");
            Console.WriteLine($"{man2.Name}, {man2.Country}");
            Console.WriteLine($"{man3.Name}, {man3.Country}");
            Console.WriteLine($"{man4.Name}, {man4.Country}");
        }

        class Man
        {
            public string Name { get; set; }
            public string Country { get; set; }

            public Man(string name = "unknown", string country = "unknown")
            {
                Name = name;
                Country = country;
            }
        }
    }
}

