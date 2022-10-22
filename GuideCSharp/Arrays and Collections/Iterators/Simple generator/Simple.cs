using System;
namespace GuideCSharp.ArraysandCollections.Iterators.Simplegenerator
{
	public class Simple
	{
		public Simple()
		{
            IEnumerable<int> Counter(int low, int high, int step)
            {
                var current = low;
                while (current <= high)
                {
                    yield return current;
                    current += step;
                }
            }

            foreach (var i in Counter(3, 9, 2))
            {
                Console.WriteLine(i);
            }
        }
	}
}

