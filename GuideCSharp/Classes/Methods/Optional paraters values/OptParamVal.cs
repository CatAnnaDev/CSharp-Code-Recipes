using System;
namespace GuideCSharp.Classes.Methods.Optionalparatersvalues
{
	public class OptParamVal
	{
		public OptParamVal()
		{
            Greeting.SayGoodbye();
            //prints "Goodbye!"

            Greeting.SayHello("Hi");
            //prints "Hi"
        }
    }
    class Greeting
    {
        public static void SayGoodbye(string message = "Goodbye!")
        {
            Console.WriteLine(message);
        }

        public static void SayHello(string message = "Hello!")
        {
            Console.WriteLine(message);
        }
    }
}

