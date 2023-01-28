using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.LINQ.ConversionMethods.ToListOperator
{
	public class ToListOperator
	{
		public ToListOperator()
		{
            int[] numbers = { 1, 2, 3, 4, 5 };
            List<int> odd = numbers.Where(i => i % 2 == 1).ToList();
            //even is {1, 3, 5}

            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
        }
	}
}

