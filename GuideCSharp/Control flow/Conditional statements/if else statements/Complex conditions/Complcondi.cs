using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.ifelsestatements.Complexconditions
{
	public class Complcondi
	{
		public Complcondi()
		{
            var A = 3;
            var B = 5;
            var C = 7;
            if (C >= A && C >= B)
            {
                Console.WriteLine("nothing is larger than C.");
            }
            if (!(A >= B || A >= C))
            {
                Console.WriteLine("A is the smallest.");
            }
        }
	}
}

