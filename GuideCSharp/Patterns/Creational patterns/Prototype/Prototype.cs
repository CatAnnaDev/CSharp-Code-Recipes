using System;
namespace GuideCSharp.Patterns.Creationalpatterns.Prototype
{
    // https://dl.dropboxusercontent.com/s/a6ec034gsonla61/19104.png
    public class Prototype
	{
		public Prototype()
		{
            var square = new Square("Red");
            var maker = new ShapeMaker(square);

            var square1 = maker.MakeShape();
            var square2 = (Square)maker.MakeShape();

            Console.WriteLine(square1.Color);
            Console.WriteLine(square2.Color);
        }
	}

    //Prototype
    interface IShape
    {
        string Color { get; set; }

        IShape Clone();
    }

    //ConcretePrototype
    class Square : IShape
    {
        public string Color { get; set; }

        public Square(string color)
        {
            Color = color;
        }

        public IShape Clone()
        {
            return new Square(Color);
        }
    }

    //Client
    class ShapeMaker
    {
        private readonly IShape _shape;

        public ShapeMaker(IShape shape)
        {
            _shape = shape;
        }

        public IShape MakeShape()
        {
            return _shape.Clone();
        }
    }

}

