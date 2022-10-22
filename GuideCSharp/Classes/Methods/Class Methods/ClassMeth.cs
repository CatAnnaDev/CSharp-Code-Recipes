using System;
namespace GuideCSharp.Classes.Methods.ClassMethods
{
	public class ClassMeth
	{
		public ClassMeth()
		{
            var min = Calc.GetMin(3, 2, 5, 1, 4);
            //min is 1

            Console.WriteLine(min);
        }
	}

    class Calc
    {
        public static int GetMin(params int[] values)
        {
            if (values.Length == 0)
                return 0;
            var min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }
            return min;
        }
    }
}

