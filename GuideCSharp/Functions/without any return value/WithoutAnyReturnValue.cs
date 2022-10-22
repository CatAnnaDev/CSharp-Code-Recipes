using System;
namespace GuideCSharp.Functions.withoutanyreturnvalue
{
	public class WithoutAnyReturnValue
	{
		public WithoutAnyReturnValue()
		{
            void add3AndPrint(int value)
            {
                Console.WriteLine(value + 3);
            }

            add3AndPrint(5);
        }
    }
}

