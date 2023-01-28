using System;
namespace GuideCSharp.Universialdynamictypes.Returnvalue
{
	public class ReturnValue
	{
		public ReturnValue()
		{
            var pi = DynamicReturn(1);
            //pi is 3.14
            var s = DynamicReturn(2);
            //s is "any"
            var b = DynamicReturn(3);
            //b is True

            Console.WriteLine("{0}; {1}; {2}", pi, s, b);
        }

        dynamic DynamicReturn(int i)
        {
            switch (i)
            {
                case 1:
                    return 3.14;
                case 2:
                    return "any";
                case 3:
                    return true;
                default:
                    return null;
            }
        }
    }
}

