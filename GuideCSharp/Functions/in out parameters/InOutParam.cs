using System;
namespace GuideCSharp.Functions.inoutparameters
{
	public class InOutParam
	{
		public InOutParam()
		{
            void SwapStrings(ref string s1, ref string s2)
            {
                var tmp = s1;
                s1 = s2;
                s2 = tmp;
            }

            var s1 = "A";
            var s2 = "B";
            SwapStrings(ref s1, ref s2);
            //s1 is "B", s2 is "A"

            Console.WriteLine($"s1: {s1}, s2: {s2}");
        }
	}
}

