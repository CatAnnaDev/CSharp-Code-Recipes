using System;
using System.Linq;

namespace GuideCSharp.Functions.multiplereturnvalaues
{
	public class MultRetValue
	{
		public MultRetValue()
		{
            (int, int) GetFirstLast(int[] ar)
            {
                var first = -1;
                var last = -1;
                if (ar.Any())
                {
                    first = ar[0];
                    last = ar[^1];
                }
                return (first, last);
            }

            var ar = new[] { 2, 3, 5 };
            var result = GetFirstLast(ar);
            //result.Item1 is 2
            //result.Item2 is 5

            Console.WriteLine("{0}, {1}", result.Item1, result.Item2);
        }
	}
}

