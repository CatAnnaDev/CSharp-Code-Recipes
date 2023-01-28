using System;
namespace GuideCSharp.StructuresRecords.Inheritance
{
	public class Inheritance
	{
		public Inheritance()
		{
            var p1 = new Point1 { X = 1, Y = 2 };
            Console.WriteLine(p1.ToText());

            RedPoint p2 = new(3, 7);
            Console.WriteLine(p2.ToText());
        }
	}

    interface IText
    {
        string ToText();
    }

    struct Point1 : IText
    {
        public int X, Y;

        public string ToText()
        {
            return $"x = {X}; y = {Y}";
        }
    }

    //struct RedPoint: Point1 { } //<- Error


    //in version 9:
    record Point2(int X, int Y)
    {
        public string ToText() => $"x = {X}; y = {Y}";
    }

    record RedPoint(int X, int Y) : Point2(X, Y) { }

}

