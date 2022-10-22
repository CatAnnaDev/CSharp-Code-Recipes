using System;
namespace GuideCSharp.ArraysandCollections.sets.Setsinitialization
{
	public class SetInit
	{
		public SetInit()
		{
            var intSet = new HashSet<int> { 1, 2, 3 };
            var strSet = new HashSet<string> { "one", "two", "three" };

            Console.WriteLine(string.Join(", ", intSet));
            Console.WriteLine(string.Join(", ", strSet));
        }
	}
}

