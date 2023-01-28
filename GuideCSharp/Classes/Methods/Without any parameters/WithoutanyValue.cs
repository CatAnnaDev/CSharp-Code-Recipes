using System;
namespace GuideCSharp.Classes.Methods.Withoutanyparameters
{
	public class WithoutanyValue
	{
		public WithoutanyValue()
		{
            var greeting = new Greeting();
            greeting.SayGoodbye();
        }
	}

    class Greeting
    {
        public void SayGoodbye()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}

