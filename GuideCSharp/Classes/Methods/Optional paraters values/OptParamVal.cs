using System;
namespace GuideCSharp.Classes.Methods.Optionalparatersvalues
{
	public class OptParamVal
	{
		public OptParamVal()
		{
            Greeting.SayGoodby();
            //prints "Goodby!"

            Greeting.SayHello("Hi");
            //prints "Hi"
        }
    }
    class Greeting
    {
        public static void SayGoodby(string message = "Goodby!")
        {
            Console.WriteLine(message);
        }

        public static void SayHello(string message = "Hello!")
        {
            Console.WriteLine(message);
        }
    }
}

