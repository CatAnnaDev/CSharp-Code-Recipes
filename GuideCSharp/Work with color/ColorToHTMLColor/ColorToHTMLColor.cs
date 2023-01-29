using System;
using System.Drawing;

namespace GuideCSharp.Workwithcolor.ColorToHTMLColor
{
	public class ColorToHTMLColor
	{
		public ColorToHTMLColor()
		{
            var color = Color.Blue;

            var htmlColor = $"#{color.R:X2}{color.G:X2}{color.B:X2}";
            //htmlColor is #00AFCA
            Console.WriteLine($"style=\"color: {htmlColor}\"");

            //Add transparency
            var alpha = 128;
            htmlColor += $"{alpha:X2}";
            //htmlColor is #00AFCA80
            Console.WriteLine($"htmlColor is {htmlColor}");
        }
	}
}

