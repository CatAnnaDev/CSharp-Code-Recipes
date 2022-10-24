using System;
namespace GuideCSharp.Generictypes.GenericMethods
{
	public class GenMeth
	{
		public GenMeth()
		{
            void Swap<T>(ref T a, ref T b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            var n1 = 5;
            var n2 = 7;
            Swap(ref n1, ref n2);
            //n1 is 7 and n2 is 5
            Console.WriteLine("{0}, {1}", n1, n2);

            var s1 = "cat";
            var s2 = "dog";
            Swap(ref s1, ref s2);
            //s1 is "dog" and s2 is "cat"
            Console.WriteLine("{0}, {1}", s1, s2);

        }
    }
}

