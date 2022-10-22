using System;
namespace GuideCSharp.Classes.Inheritance.Interfaceinheritance
{
	public class IntIneheri
	{
		public IntIneheri()
		{
            var square = new Square(5);
            var area = square.GetArea();
            //area is 25

            Console.WriteLine(area);
        }
	}

    interface IShape
    {
        int LineCount { get; set; }
        int GetArea();
    }

    class Square : IShape
    {
        public int LineCount { get; set; }
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
            LineCount = 4;
        }

        public int GetArea()
        {
            return SideLength * SideLength;
        }
    }

}

