using System;
namespace GuideCSharp.StructuresRecords.Methods
{
	public class Methods
	{
		public Methods()
		{
            var p1 = new Point1 { X = 1, Y = 2 };
            var str1 = p1.ToText();
            //str1 is "x = 1; y = 2"
            Console.WriteLine(str1);

            p1.Move(5, -1);
            var str2 = p1.ToText();
            //str2 is "x = 6; y = 1"
            Console.WriteLine(str2);

            Point2 p2 = new(5, 7);
            Console.WriteLine($"p2 = {p2}");
        }
	}

    struct Point1
    {
        public int X, Y;

        public string ToText()
        {
            return $"x = {X}; y = {Y}";
        }

        public void Move(int right, int down)
        {
            X += right;
            Y += down;
        }
    }

    //in version 9:
    record Point2(int X, int Y)
    {
        public string ToText() => $"x = {X}; y = {Y}";

        //Error: Init-only property
        //public void Move(int right, int down) => (X, Y) = (X + right, Y + down);
    }
}

