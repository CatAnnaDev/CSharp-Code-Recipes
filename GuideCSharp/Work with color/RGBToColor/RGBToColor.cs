using System;
using System.Drawing;

namespace GuideCSharp.Workwithcolor.RGBToColor
{
	public class RGBToColor
	{
		public RGBToColor()
		{
            var red = 51;
            var green = 255;
            var blue = 51;
            var alpha = 128;

            var colorGreen = Color.FromArgb(red, green, blue);
            Console.WriteLine(colorGreen);

            //with transparency
            colorGreen = Color.FromArgb(alpha, red, green, blue);
            Console.WriteLine(colorGreen);
        }
	}
}

