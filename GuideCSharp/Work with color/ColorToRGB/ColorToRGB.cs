using System;
using System.Drawing;

namespace GuideCSharp.Workwithcolor.ColorToRGB
{
	public class ColorToRGB
	{
		public ColorToRGB()
		{
            var orange = Color.Orange;
            var red = orange.R;
            var green = orange.G;
            var blue = orange.B;

            Console.WriteLine($"red is {red}");
            Console.WriteLine($"green is {green}");
            Console.WriteLine($"blue is {blue}");

        }
    }
}

