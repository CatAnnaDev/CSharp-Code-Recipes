using System;
namespace GuideCSharp.OperatorsOverloadings.UnaryOperators
{
	public class UnaryOperators
	{
		public UnaryOperators()
		{
            var p = new Point(1, 1);
            p++;
            //p3.x is 2 and p3.y is 2
            ++p;
            //p3.x is 3 and p3.y is 3
            p = -p;
            //p3.x is -3 and p3.y is -3

            Console.WriteLine("x = {0}, y = {1}", p.X, p.Y);
            Console.ReadLine();
        }
	}

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public static Point operator ++(Point p)
        {
            return new Point(p.X + 1, p.Y + 1);
        }

        public static Point operator -(Point p)
        {
            return new Point(-p.X, -p.Y);
        }
    }
}

