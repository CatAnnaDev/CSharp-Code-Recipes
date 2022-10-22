using System;
namespace GuideCSharp.Classes.Constructors.Withoutanyparameters
{
	public class withoutParam
	{
		public withoutParam()
		{
            var man = new Man();
            //man.Name is "unknown"

            Console.WriteLine(man.Name);
        }

        class Man
        {
            public string Name { get; }

            public Man()
            {
                Name = "unknown";
            }
        }
    }
}

