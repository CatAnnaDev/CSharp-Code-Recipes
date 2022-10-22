using System;
namespace GuideCSharp.Extensions.Addingobjectmethods
{
	public class AddObjMeth
	{
		public AddObjMeth()
		{
            var p1 = new Point(1, 2);
            var p2 = new Point(2, 3);
            var distance = p1.DistanceTo(p2);
            //distance is 1.4142

            Console.WriteLine(distance);
        }
	}

    class Point
    {
        public double x;
        public double y;

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }

    static class PointExt
    {
        public static double DistanceTo(this Point p1, Point p2)
        {
            var d1 = Math.Pow(p1.x - p2.x, 2);
            var d2 = Math.Pow(p1.y - p2.y, 2);
            return Math.Sqrt(d1 + d2);
        }
    }
}

