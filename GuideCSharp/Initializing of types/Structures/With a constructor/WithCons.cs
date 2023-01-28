using System;

namespace GuideCSharp.Initializingoftypes.Structures.Withaconstructor
{
	public class WithCons
	{
        //C# 9 feature
        record Point(int top, int left);

        record Rectangle(Size size, Point point);

        struct Size
        {
            public int width, height;

            public Size(int width, int height)
            {
                this.width = width;
                this.height = height;
            }
        }

        public WithCons()
		{
            var size = new Size(10, 10);
            var point = new Point(5, 5);
            var rect = new Rectangle(size, point);

            Console.WriteLine(rect);
        }
	}
}

