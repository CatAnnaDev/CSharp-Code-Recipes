using System;
namespace GuideCSharp.Classes.Inheritance.Compatibilitycheckis
{
	public class CompCheck
	{
		public CompCheck()
		{
            var square = new Square();

            var isShape = square is Shape;
            //isShape is True

            var isRedSquare = square is RedSquare;
            //isRedSquare is False

            Console.WriteLine("{0}; {1}", isShape, isRedSquare);
        }
	}

    class Shape { }

    class Square : Shape { }

    class RedSquare : Square { }
}

