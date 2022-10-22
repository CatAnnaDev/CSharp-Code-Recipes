using System;
namespace GuideCSharp.Classes.Inheritance.Membershiding
{
	public class MemHid
	{
		public MemHid()
		{
            var square = new Square();
            square.Fill(Color.Red);
            //Use Square fill implementation

            ((Shape)square).Fill(Color.Red);
            //Use Shape fill implementation
        }
    }

    enum Color
    {
        Red
    }

    abstract class Shape
    {
        public void Fill(Color color)
        {
            Console.WriteLine("Fill implementation");
        }
    }

    class Square : Shape
    {
        public new void Fill(Color color)
        {
            Console.WriteLine("New fill implementation");
        }
    }
}

