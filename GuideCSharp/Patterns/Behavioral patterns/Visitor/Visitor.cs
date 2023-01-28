using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.Visitor
{
    // https://dl.dropbox.com/s/z25y374x3bjlt5j/19311.png
    public class Visitor
	{
		public Visitor()
		{
            //Client
            var car = new Car();
            var v1 = new TestCarVisitor();
            var v2 = new RepairCarVisitor();

            car.Accept(v1);
            car.Accept(v2);
        }
	}

    interface IElement
    {
        void Accept(ICarVisitor v);
    }

    //ConcreteElement
    class Engine : IElement
    {
        public void Accept(ICarVisitor v)
        {
            v.Visit(this);
        }
    }

    //ConcreteElement
    class Wheel : IElement
    {
        readonly int _number;

        public Wheel(int number)
        {
            _number = number;
        }

        public int GetNumber()
        {
            return _number;
        }

        public void Accept(ICarVisitor v)
        {
            v.Visit(this);
        }
    }

    //ConcreteElement
    class Car : IElement
    {
        readonly IElement[] _items = {
        new Engine(),
        new Wheel(1), new Wheel(2),
        new Wheel(3), new Wheel(4)};

        public void Accept(ICarVisitor v)
        {
            foreach (var e in _items)
            {
                e.Accept(v);
            }
            v.Visit(this);
        }
    }

    //Visitor
    interface ICarVisitor
    {
        void Visit(Engine engine);
        void Visit(Wheel wheel);
        void Visit(Car car);
    }

    //ConcreteVisitor
    class TestCarVisitor : ICarVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("test engine");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("test wheel #" +
                wheel.GetNumber());
        }

        public void Visit(Car car)
        {
            Console.WriteLine("test car");
        }
    }

    //ConcreteVisitor
    class RepairCarVisitor : ICarVisitor
    {
        public void Visit(Engine engine)
        {
            Console.WriteLine("repair engine");
        }

        public void Visit(Wheel wheel)
        {
            Console.WriteLine("repair wheel #" +
                wheel.GetNumber());
        }

        public void Visit(Car car)
        {
            Console.WriteLine("repair car");
        }
    }
}

