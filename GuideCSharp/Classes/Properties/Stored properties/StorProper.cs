using System;
namespace GuideCSharp.Classes.Properties.Storedproperties
{
	public class StorProper
	{
		public StorProper()
		{
            var point = new Point();
            //X and Y is 0 (before assigning)
            Console.WriteLine(point.X);

            point.X = 3;
            point.Y = 7;
            Console.WriteLine(point.X);
        }
	}

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}

