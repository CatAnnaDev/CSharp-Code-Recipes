using System;
namespace GuideCSharp.StructuresRecords.Constructors
{
    struct Point
    {
        public int X, Y;

        //public Point() { } //<- Error
        //has such constructor by default

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    public class Constructors
	{
		public Constructors()
		{
            //in version 9:
            record Size(int Width, int Height);

            var p1 = new Point(1, 2);
            //p1.x is 1 and p1.y is 2
            Console.WriteLine($"p1 is ({p1.X}, {p1.Y})");

            var p2 = new Point();
            //p2.x is 0 and p2.y is 0
            Console.WriteLine($"p2 is ({p2.X}, {p2.Y})");

            Size size = new Size(4, 5);
            Console.WriteLine(size);

        }
    }
}

