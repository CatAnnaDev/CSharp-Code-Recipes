using System;
namespace GuideCSharp.Classes.Properties.Computedproperties
{
	public class CompProper
	{
		public CompProper()
		{
            var square = new Square { Side = 2 };
            //square.Area is 4
            Console.WriteLine(square.Area);

            square.Area = 9;
            //square.side is 3
            Console.WriteLine(square.Side);

        }
    }

    class Square
    {
        public double Side { get; set; }
        public double Area
        {
            get => Side * Side;
            set => Side = Math.Sqrt(value);
        }
    }
}

