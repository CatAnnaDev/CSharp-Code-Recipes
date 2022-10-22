using System;
namespace GuideCSharp.Classes.Inheritance.Methodsoverride
{
	public class MethOver
	{
		public MethOver()
		{
            var square = new Square(5);
            var area = square.GetArea();
            //area is 25

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
        public int SideLength { get; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public override int GetArea()
        {
            if (SideLength > 0)
            {
                return SideLength * SideLength;
            }
            //call base class method
            return base.GetArea();
        }
    }

}

