using System;
namespace GuideCSharp.ArraysandCollections.sets.Sortingofelements
{
	public class sorting
	{
		public sorting()
		{
            var chars = new HashSet<Char> { 'B', 'A', 'C', 'D' };
            var str = "";
            foreach (var c in chars)
            {
                str += (str == "" ? "" : "; ") + c;
            }
            //str is "B; A; C; D"
            Console.WriteLine(str);

            str = "";
            foreach (var c in chars.OrderBy(c => c))
            {
                str += (str == "" ? "" : "; ") + c;
            }
            //str is "A; B; C; D"
            Console.WriteLine(str);
        }
	}
}

