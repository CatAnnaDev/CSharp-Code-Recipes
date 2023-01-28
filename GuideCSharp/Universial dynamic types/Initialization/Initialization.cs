using System;
using System.Globalization;

namespace GuideCSharp.Universialdynamictypes.Initialization
{
	public class Initialization
	{
		public Initialization()
		{
            //Initialized by any type
            dynamic d = "some string";
            Console.WriteLine(d + ", type: " + d.GetType());

            d = 3.14;
            Console.WriteLine(d + ", type: " + d.GetType());

            d = new[] { 2, 3, 5 };
            Console.WriteLine(d + ", type: " + d.GetType());

            d = new CultureInfo("ru");
            Console.WriteLine(d + ", type: " + d.GetType());
        }
	}
}

