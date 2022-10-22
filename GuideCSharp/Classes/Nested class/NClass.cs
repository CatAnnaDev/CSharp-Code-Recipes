using System;
namespace GuideCSharp.Classes.Nestedclass
{
	public class NClass
	{
		public NClass()
		{
            var someClass = new SomeClass();
            var nested1 = someClass.Create();
            var nested2 = new SomeClass.NestedClass();

            Console.WriteLine(nested1);
            Console.WriteLine(nested2);
        }
	}

    class SomeClass
    {

        public NestedClass Create()
        {
            return new NestedClass();
        }

        public class NestedClass { }
    }
}

