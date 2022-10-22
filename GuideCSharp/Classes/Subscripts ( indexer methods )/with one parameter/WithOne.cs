using System;
namespace GuideCSharp.Classes.Properties.Subscriptsindexermethods.withoneparameter
{
	public class WithOne
	{
		public WithOne()
		{
            var power2 = new PowerOfTwo();
            var p2 = power2[2];
            //p2 is 4
            var p8 = power2[8];
            //p8 is 256
            var p16 = power2[16];
            //p16 is 65536

            Console.WriteLine("{0}, {1}, {2}", p2, p8, p16);
        }
	}

    class PowerOfTwo
    {
        public int this[int i] => (int)Math.Pow(2, i);
    }
}

