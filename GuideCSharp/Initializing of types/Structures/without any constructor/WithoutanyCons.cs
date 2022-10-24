using System;
namespace GuideCSharp.Initializingoftypes.Structures.withoutanyconstructor
{
	public class WithoutanyCons
	{
        struct Size
        {
            public int width, height;
        }

        struct Point
        {
            public int top, left;
        }

        struct Rectangle
        {
            public Size size;
            public Point point;
        }

        public WithoutanyCons()
		{
            var rect = new Rectangle
            {
                size = new() { width = 10, height = 10 },
                point = new() { top = 5, left = 5 }
            };
            Console.WriteLine(rect.size.width);
        }
	}
}

