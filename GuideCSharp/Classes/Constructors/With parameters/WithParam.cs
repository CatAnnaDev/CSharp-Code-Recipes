using System;
namespace GuideCSharp.Classes.Constructors.Withparameters
{
	public class WithParam
	{
		public WithParam()
		{
            var man = new Man("Alex");
            //man.Name is "Alex"

            Console.WriteLine(man.Name);
        }

        class Man
        {
            public string Name { get; }

            public Man(string name)
            {
                Name = name;
            }
        }

    }
}

