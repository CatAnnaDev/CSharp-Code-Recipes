using System;
namespace GuideCSharp.Classes.Inheritance.Propertyoverride
{
	public class ProOverr
	{
		public ProOverr()
		{
            var square = new Square();
            //square.LineCount is 4

            Console.WriteLine(square.LineCount);

        }
    }

    class Shape
    {
        public virtual int LineCount => 0;
    }

    class Square : Shape
    {
        public override int LineCount => 4;
    }
}

