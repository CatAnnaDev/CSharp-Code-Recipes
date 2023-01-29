using System;
namespace GuideCSharp.Workwithcolor.HTMLColorToRGB
{
	public class HTMLColorToRGB
	{
		public HTMLColorToRGB()
		{
            string orange = "#FFC80080";
            int x = Convert.ToInt32(orange.Substring(1), 16);

            int red = (x >> 24) & 0xFF;
            int green = (x >> 16) & 0xFF;
            int blue = (x >> 8) & 0xFF;
            int alpha = x & 0xFF;

            Console.WriteLine($"red is {red}");
            Console.WriteLine($"green is {green}");
            Console.WriteLine($"blue is {blue}");
            Console.WriteLine($"alpha is {alpha}");

        }
    }
}

