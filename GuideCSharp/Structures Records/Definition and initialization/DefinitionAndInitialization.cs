using System;
namespace GuideCSharp.StructuresRecords.Definitionandinitialization
{
    struct Point
    {
        public int X, Y;
    }
    public class DefinitionAndInitialization
	{
		public DefinitionAndInitialization()
		{
            //in version 9:
            record Coords(int X, int Y);

            var p1 = new Point { X = 1, Y = 2 };
            //p1.x is 1 and p1.y is 2
            Console.WriteLine($"p1 is ({p1.X}, {p1.Y})");

            var p2 = new Point();
            Console.WriteLine($"p2.X = {p2.X}");

            Point p3;
            //var x3 = p3.x; //<- Error
            Console.WriteLine("p1 is " + p1);

            var c1 = new Coords(1, 2);
            //c1 is Coords { x = 1, y = 2 }
            Console.WriteLine("c1 is " + c1);
        }
	}
}

