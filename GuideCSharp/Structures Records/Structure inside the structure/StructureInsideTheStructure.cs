using System;
namespace GuideCSharp.StructuresRecords.Structureinsidethestructure
{
	public class StructureInsideTheStructure
	{
		public StructureInsideTheStructure()
		{
            var rect1 = new Rect1
            {
                Point = new Point1 { X = 3, Y = 4 },
                Size = new Size1 { Width = 10, Height = 12 }
            };
            Console.WriteLine($"rect1 is {rect1}");

            //in version 9:
            Rect2 rect2 = new(new(3, 4), new(10, 12));
            Console.WriteLine($"rect2 is {rect2}");
        }
	}

    struct Point1
    {
        public int X, Y;
    }

    struct Size1
    {
        public int Width, Height;
    }

    struct Rect1
    {
        public Point1 Point;
        public Size1 Size;
    }

    //in version 9:
    record Point2(int X, int Y);

    record Size2(int Width, int Height);

    record Rect2(Point2 Point, Size2 Size);
}

