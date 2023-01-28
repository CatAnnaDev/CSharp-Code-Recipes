using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Structuralpatterns.Composite
{
    // https://dl.dropbox.com/s/hl6qc5tgb5x624k/19204.png
    public class Composite
	{
		public Composite()
		{
            //Client
            var image = new Image();
            image.Add(new Circle());
            image.Add(new Square());
            var picture = new Image();
            picture.Add(image);
            picture.Add(new Image());
            picture.Draw();
        }
	}

    //Component
    interface IGraphic
    {
        void Draw();
    }

    //Leaf
    class Circle : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Draw circle");
        }
    }

    //Leaf
    class Square : IGraphic
    {
        public void Draw()
        {
            Console.WriteLine("Draw square");
        }
    }

    //Composite
    class Image : IGraphic
    {
        readonly List<IGraphic> _graphics = new();

        public void Add(IGraphic graphic)
        {
            _graphics.Add(graphic);
        }

        public void Draw()
        {
            Console.WriteLine("Draw image");
            foreach (var graphic in _graphics)
            {
                graphic.Draw();
            }
        }
    }

}

