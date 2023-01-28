using System;
namespace GuideCSharp.LambdaExpressions.WithMultipleOperators
{
	public class WithMultipleOperators
	{
        record Point(double x, double y);

        public WithMultipleOperators()
		{
            Func<Point, Point, double> getDistance = (p1, p2) =>
            {
                var d1 = Math.Pow(p1.x - p2.x, 2);
                var d2 = Math.Pow(p1.y - p2.y, 2);
                return Math.Sqrt(d1 + d2);
            };

            var point1 = new Point(0, 0);
            var point2 = new Point(5, 5);
            var distance = getDistance(point1, point2);
            //distance is 7.071

            Console.WriteLine("{0}", distance);



        }
	}
}

