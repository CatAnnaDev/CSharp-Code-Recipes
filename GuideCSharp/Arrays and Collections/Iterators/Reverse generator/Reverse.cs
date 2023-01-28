using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.ArraysandCollections.Iterators.Reversegenerator
{
	public class Reverse
	{
		public Reverse()
		{
            IEnumerable<T> Reverse<T>(ICollection<T> data)
            {
                var current = data.Count;
                while (current >= 1)
                {
                    current -= 1;
                    yield return data.ElementAt(current);
                }
            }

            foreach (var i in Reverse("string".ToList()))
            {
                Console.WriteLine(i);
            }
            //printed g, n, i, r, t, s

            foreach (var i in Reverse(new[] { 1, 2, 3 }))
            {
                Console.WriteLine(i);
            }
            //printed 3, 2, 1
        }
    }
}

