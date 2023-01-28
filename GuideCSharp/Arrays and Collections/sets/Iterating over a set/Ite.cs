using System;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.sets.Iteratingoveraset
{
	public class Ite
	{
		public Ite()
		{
            var chars = new HashSet<Char> { 'A', 'B', 'C', 'D' };
            var str = "";
            foreach (var c in chars)
            {
                str += (str == "" ? "" : "; ") + c;
            }
            //str is "B; A; C; D"

            Console.WriteLine(str);
        }
	}
}

