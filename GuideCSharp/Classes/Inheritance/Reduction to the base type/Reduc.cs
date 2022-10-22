using System;
namespace GuideCSharp.Classes.Inheritance.Reductiontothebasetype
{
	public class Reduc
	{
		public Reduc()
		{
            var square = new Square();

            //implicit method
            Shape shape = square;
            Console.WriteLine(shape.GetType());

            //explicit first method
            shape = square as Shape;
            Console.WriteLine(shape.GetType());

            //explicit second method
            shape = (Shape)square;
            Console.WriteLine(shape.GetType());

            var name = shape.Name;
            //name is "Square"
            Console.WriteLine(name);
        }
	}

    class Shape
    {
        public virtual string Name => "Shape";
    }

    class Square : Shape
    {
        public override string Name => "Square";
    }
}

