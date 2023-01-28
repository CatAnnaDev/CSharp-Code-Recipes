using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.Generictypes.GenericCollection
{
	public class GenColle
	{
		public GenColle()
		{
            //List of integer
            var intList = new List<int> { 5 };

            //Dictionary
            var dic = new Dictionary<int, string> { [1] = "one" };

            //Set
            var set = new HashSet<double> { 3.14 };

            Console.WriteLine(intList[0]);
            Console.WriteLine(dic[1]);
            Console.WriteLine(set.First());
        }
	}
}

