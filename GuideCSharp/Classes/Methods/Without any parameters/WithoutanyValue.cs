using System;
namespace GuideCSharp.Classes.Methods.Withoutanyparameters
{
	public class WithoutanyValue
	{
		public WithoutanyValue()
		{
            var greeting = new Greeting();
            greeting.SayGoodby();
        }
	}

    class Greeting
    {
        public void SayGoodby()
        {
            Console.WriteLine("Goodby!");
        }
    }
}

