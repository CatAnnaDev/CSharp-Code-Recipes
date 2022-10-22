using System;
namespace GuideCSharp.Classes.Properties.ReadOnlyProperties.Computedproperties
{
	public class CompProper
	{
		public CompProper()
		{
            var circle = new Circle { Radius = 2 };
            //circle.Area is 12.56

            Console.WriteLine(circle.Area);
        }
	}

    class Circle
    {
        public double Radius;
        public double Area => Math.PI * Math.Pow(Radius, 2);
    }
}

