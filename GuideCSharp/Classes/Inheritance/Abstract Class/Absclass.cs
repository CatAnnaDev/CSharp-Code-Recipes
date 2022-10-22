using System;
namespace GuideCSharp.Classes.Inheritance.AbstractClass
{
	public class Absclass
	{
		public Absclass()
		{
            //var shape = new Shape(); // <-error

            var square = new Square();
            square.Fill(Color.Red);
            square.Draw();

        }
    }

    enum Color
    {
        Red
    }

    abstract class Shape
    {
        public abstract void Fill(Color color);

        public void Draw()
        {
            Console.WriteLine("Draw implementation");
        }
    }

    class Square : Shape
    {
        public override void Fill(Color color)
        {
            Console.WriteLine("Fill implementation");
        }
    }
}

