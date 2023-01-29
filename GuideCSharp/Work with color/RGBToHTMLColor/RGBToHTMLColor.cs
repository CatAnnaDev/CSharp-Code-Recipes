using System;
namespace GuideCSharp.Workwithcolor.RGBToHTMLColor
{
	public class RGBToHTMLColor
	{
		public RGBToHTMLColor()
		{
            var red = 51;
            var green = 255;
            var blue = 51;
            var alpha = 128;

            var htmlColor = $"#{red:X2}{green:X2}{blue:X2}";
            //htmlColor is #33FF33
            Console.WriteLine($"style=\"color: {htmlColor}\"");

            //with transparency
            htmlColor = $"#{red:X2}{green:X2}{blue:X2}{alpha:X2}";
            //htmlColor is #33FF3380
            Console.WriteLine($"htmlColor is {htmlColor}");
        }
	}
}

