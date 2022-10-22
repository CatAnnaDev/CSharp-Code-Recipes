using System;
namespace GuideCSharp.Classes.Definitionandinitialization
{
	public class DefInit
	{
		public DefInit()
		{
            //Initialization
            var someClass1 = new SomeClass();

            //in version 9:
            SomeClass someClass2 = new();

            Console.WriteLine(someClass1);
            Console.WriteLine(someClass2);
        }

        class SomeClass { }
    }
}

