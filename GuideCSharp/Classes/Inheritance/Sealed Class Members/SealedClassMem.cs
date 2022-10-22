using System;
namespace GuideCSharp.Classes.Inheritance.SealedClassMembers
{
	public class SealedClassMem
	{
		public SealedClassMem()
		{
            var square = new Square { SideLength = 4 };
            var area = square.GetArea();
            //area is 16

            Console.WriteLine(area);
        }
	}

    class Shape
    {
        public virtual int GetArea()
        {
            return 0;
        }
    }

    class Square : Shape
    {
        public int SideLength { get; set; }

        public override sealed int GetArea()
        {
            return SideLength * SideLength;
        }
    }

    class RedSquare : Square
    {
        // public override int GetArea() { //<- Error
        // }
    }
}

