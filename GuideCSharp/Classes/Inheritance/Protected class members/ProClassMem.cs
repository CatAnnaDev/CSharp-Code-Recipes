using System;
namespace GuideCSharp.Classes.Inheritance.Protectedclassmembers
{
	public class ProClassMem
	{
		public ProClassMem()
		{
            var square = new Square();
            //var lineCount = square.LineCount; //<- Error
        }
    }

    class Shape
    {
        protected int LineCount { get; init; }
    }

    class Square : Shape
    {
        public Square()
        {
            LineCount = 4;
        }
    }
}

