using System;
namespace GuideCSharp.Classes.Inheritance.BaseClass
{
	public class BaseClass
	{
		public BaseClass()
		{
            var square = new Square(5);
            //square.LineCount is 4

            Console.WriteLine($"LineCount = {square.LineCount}");
            Console.WriteLine($"SideLength = {square.SideLength}");
        }
	}

    class Shape
    {
        public int LineCount { get; }

        public Shape(int lineCount)
        {
            LineCount = lineCount;
        }
    }

    class Square : Shape
    {
        public int SideLength { get; }

        public Square(int sideLength) : base(4)
        {
            SideLength = sideLength;
        }
    }
}

