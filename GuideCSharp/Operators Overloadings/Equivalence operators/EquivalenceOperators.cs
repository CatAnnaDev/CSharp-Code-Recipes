using System;
namespace GuideCSharp.OperatorsOverloadings.Equivalenceoperators
{
	public class EquivalenceOperators
	{
		public EquivalenceOperators()
		{
            var p1 = new Point(1, 1);
            var p2 = new Point(2, 2);
            var p3 = new Point(1, 1);
            var equal1 = p1 == p2;
            //equal1 is False
            var equal2 = p1 == p3;
            //equal2 is True
            var equal3 = p1 != p3;
            //equal3 is False

            Console.WriteLine(equal1);
            Console.WriteLine(equal2);
            Console.WriteLine(equal3);
        }
	}

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public static bool operator ==(Point left, Point right)
        {
            return (left.X == right.X) && (left.Y == right.Y);
        }

        public static bool operator !=(Point left, Point right)
        {
            return (left.X != right.X) || (left.Y != right.Y);
        }
    }
}

