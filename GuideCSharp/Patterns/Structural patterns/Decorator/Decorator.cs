using System;
namespace GuideCSharp.Patterns.Structuralpatterns.Decorator
{
    // https://dl.dropbox.com/s/wwto42fcqs7tpmi/19205.png
    public class Decorator
	{
		public Decorator()
		{
            //Client
            var square = new Square();
            square.ShowInfo();
            //printed: square
            Console.WriteLine();

            var colorShape = new ColorShape(square, "red");
            colorShape.ShowInfo();
            //printed: red square
            Console.WriteLine();

            var shadowShape = new ShadowShape(colorShape);
            shadowShape.ShowInfo();
            //printed: red square with shadow
        }
    }

    //Component
    interface IShape
    {
        //Operation()
        void ShowInfo();
    }

    //ConcreteComponent
    class Square : IShape
    {
        public void ShowInfo()
        {
            Console.Write("square");
        }
    }

    //Decorator
    abstract class ShapeDecorator : IShape
    {
        protected readonly IShape Shape;

        protected ShapeDecorator(IShape shape)
        {
            Shape = shape;
        }

        //Operation()
        public virtual void ShowInfo()
        {
            Shape.ShowInfo();
        }
    }

    //ConcreteDecorator
    class ColorShape : ShapeDecorator
    {
        private readonly string _color;

        public ColorShape(IShape shape, string color) :
        base(shape)
        {
            _color = color;
        }

        public override void ShowInfo()
        {
            Console.Write(_color + " ");
            Shape.ShowInfo();
        }
    }

    //ConcreteDecorator
    class ShadowShape : ShapeDecorator
    {
        public ShadowShape(IShape shape) :
        base(shape)
        {
        }

        public override void ShowInfo()
        {
            Shape.ShowInfo();
            Console.Write(" with shadow");
        }
    }

}

