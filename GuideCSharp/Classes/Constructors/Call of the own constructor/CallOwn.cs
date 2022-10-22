using System;
namespace GuideCSharp.Classes.Constructors.Calloftheownconstructor
{
	public class CallOwn
	{
		public CallOwn()
		{
            var man = new Man("Vladimir", "Russia");
            Console.WriteLine(man.Name);

        }

        class Man
        {
            public string Name { get; }
            public string Country { get; }

            public Man(string name)
            {
                Name = name;
            }

            public Man(string name, string country) :
            this(name)
            {
                Country = country;
            }
        }
    }
}

