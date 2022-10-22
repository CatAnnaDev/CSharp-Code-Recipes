using System;
namespace GuideCSharp.Classes.Inheritance.Downcastingas
{
	public class Downcasting
	{
		public Downcasting()
		{
            var square = new Square();

            var shape = square as Shape;
            //type of shape is still Square
            Console.WriteLine("shape type is " + shape.GetType());
            //but you can access the 
            //members of the Shape class
            Console.WriteLine("shape.Name is " + shape.Name);

            var redSquare = square as RedSquare;
            //redSquare is null
            Console.WriteLine(redSquare is null);
        }
	}

    class Shape
    {
        public string Name = "Shape";
    }

    class Square : Shape
    {
        new public string Name = "Square";
    }

    class RedSquare : Square { }
}

