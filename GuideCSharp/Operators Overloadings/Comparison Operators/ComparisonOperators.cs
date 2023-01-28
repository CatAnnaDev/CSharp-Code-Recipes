using System;
namespace GuideCSharp.OperatorsOverloadings.ComparisonOperators
{
	public class ComparisonOperators
	{
		public ComparisonOperators()
		{
            var p1 = new Point(1, 2);
            var p2 = new Point(2, 3);

            var b1 = p1 > p2;
            //b1 is False
            var b2 = p1 < p2;
            //b2 is True

            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
	}

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public static bool operator >(Point left, Point right)
        {
            return left.X > right.X && left.Y > right.Y;
        }

        public static bool operator <(Point left, Point right)
        {
            return left.X < right.X && left.Y < right.Y;
        }
    }
}

