using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.TemplateMethod
{
    // https://dl.dropbox.com/s/kgdorjwj8gci7md/19310.png
    public class TemplateMethod
	{
		public TemplateMethod()
		{
            //Client
            var circle = new Circle();
            circle.Draw();
        }
	}

    abstract class Shape
    {
        //Template method
        public void Draw()
        {
            if (!canDraw())
                return;
            DoDraw();
            notifyListeners();
        }

        bool canDraw()
        {
            //If it possible to draw the shape
            return true;
        }

        //primitive operation
        protected abstract void DoDraw();

        void notifyListeners()
        {
            Console.WriteLine("shape is drawn");
        }
    }

    class Circle : Shape
    {
        protected override void DoDraw()
        {
            Console.WriteLine("draw a circle");
        }
    }
}

