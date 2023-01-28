using System;
namespace GuideCSharp.StructuresRecords.Fieldsandproperties
{
	public class FieldsAndProperties
	{
		public FieldsAndProperties()
		{
            var p1 = new ColorPoint1 { X = 1, Y = 2, Color = new Brush() };
            Console.WriteLine($"p1 is ({p1.X}, {p1.Y}, {p1.Color})");

            ColorPoint2 p2 = new(3, 7) { Color = new Brush() };
            Console.WriteLine($"p2 is ({p2.X}, {p2.Y}, {p2.Color})");

        }
    }

    class Brush { }

    struct ColorPoint1
    {
        //Fields
        public int X, Y;

        //Property
        public Brush Color { get; set; }
    }

    //in version 9:
    record ColorPoint2(int X, int Y)
    {
        //Property
        public Brush Color { get; init; }
    }
}

