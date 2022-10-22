using System;
namespace GuideCSharp.Enumerations.BaseType
{
	public class BaseType
	{
        enum Season : byte
        {
            Summer, Fall, Winter, Spring
        }

        enum Align : int
        {
            Left, Right, Center
        }

        public BaseType()
		{
            var baseFall = (byte)Season.Fall;
            //baseFall is 1, type byte

            var baseCenter = (int)Align.Center;
            //baseCenter is 2, type int

            Console.WriteLine("{0}, {1}", baseFall, baseCenter);
        }
	}
}

