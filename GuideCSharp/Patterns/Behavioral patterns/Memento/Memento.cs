using System;
using System.Collections.Generic;
using System.Linq;

namespace GuideCSharp.Patterns.Behavioralpatterns.Memento
{
    // https://dl.dropbox.com/s/qygxalojqf28e3p/19306.png
    public class Mementos
	{
		public Mementos()
		{
            //Client
            var shape = new Shape();
            var helper = new ShapeHelper(shape);

            helper.Move(2, 3);
            //shape.position is (2, 3)
            shape.Position.Print();

            helper.Move(-5, 4);
            //shape.position is (-3, 7)
            shape.Position.Print();

            helper.Undo();
            //shape.position is (2, 3)
            shape.Position.Print();

            helper.Undo();
            //shape.position is (0, 0)
            shape.Position.Print();
        }
	}

    //State
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"{X}, {Y}");
        }
    }

    class Memento
    {
        readonly Point _state;

        public Memento(Point state)
        {
            _state = state;
        }

        public Point GetState()
        {
            return _state;
        }
    }

    //Originator
    class Shape
    {
        public Point Position = new(0, 0);

        public void Move(int left, int top)
        {
            Position.X += left;
            Position.Y += top;
        }

        public Memento GetMemento()
        {
            Point state = new Point(
                Position.X, Position.Y);
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            Position = memento.GetState();
        }
    }

    //Caretaker
    class ShapeHelper
    {
        readonly Stack<Memento> _stack = new();
        readonly Shape _shape;

        public ShapeHelper(Shape shape)
        {
            _shape = shape;
        }

        public void Move(int left, int top)
        {
            _stack.Push(_shape.GetMemento());
            _shape.Move(left, top);
        }

        public void Undo()
        {
            if (_stack.Any())
            {
                _shape.SetMemento(_stack.Pop());
            }
        }
    }
}

