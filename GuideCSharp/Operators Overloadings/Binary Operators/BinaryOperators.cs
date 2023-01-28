using System;
namespace GuideCSharp.OperatorsOverloadings.BinaryOperators
{
	public class BinaryOperators
	{
		public BinaryOperators()
		{
            var p1 = new Point(1, 1);
            var p2 = new Point(2, 2);
            var p3 = p1 + p2;
            //p3.x is 3 and p3.y is 3
            p3 += new Point(3, 5);
            //p3.x is 6 and p3.y is 8

            Console.WriteLine($"x = {p3.X}, y = {p3.Y}");
        }
	}

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public static Point operator +(Point left, Point right)
        {
            return new(left.X + right.X, left.Y + right.Y);
        }
    }
}

