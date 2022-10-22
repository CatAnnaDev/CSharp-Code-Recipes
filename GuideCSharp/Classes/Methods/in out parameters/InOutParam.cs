using System;
namespace GuideCSharp.Classes.Methods.inoutparameters
{
	public class InOutParam
	{
		public InOutParam()
		{
            var s1 = "A";
            var s2 = "B";
            var swap = new Swap();
            swap.Strings(ref s1, ref s2);
            //s1 is "B", s2 is "A"

            Console.WriteLine($"s1: {s1}, s2: {s2}");
        }
	}

    class Swap
    {
        public void Strings(ref string s1, ref string s2)
        {
            var tmp = s1;
            s1 = s2;
            s2 = tmp;
        }
    }
}

