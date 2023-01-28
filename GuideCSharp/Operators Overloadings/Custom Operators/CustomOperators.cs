using System;
namespace GuideCSharp.OperatorsOverloadings.CustomOperators
{
	public class CustomOperators
	{
		public CustomOperators()
		{
            var p1 = new Point(2, 3);
            p1 = p1 ^ 3;
            //p1.x is 8 and p1.y is 27
            Console.WriteLine("x = {0}, y = {1}", p1.X, p1.Y);
        }
    }

    class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y) => (X, Y) = (x, y);

        public static Point operator ^(Point p, int power)
        {
            var x = Math.Pow(p.X, power);
            var y = Math.Pow(p.Y, power);
            return new Point((int)x, (int)y);
        }
    }
}

