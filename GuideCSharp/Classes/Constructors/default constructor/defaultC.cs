using System;
namespace GuideCSharp.Classes.Constructors.defaultconstructor
{
	public class defaultC
	{
		public defaultC()
		{
            var man = new Man { Name = "Alex" };

            Console.WriteLine(man.Name);
        }

        class Man
        {
            public string Name { get; set; }
        }
    }
}

