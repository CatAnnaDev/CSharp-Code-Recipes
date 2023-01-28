using System;
namespace GuideCSharp.StructuresRecords.Constants
{
    struct BoldLine
    {
        public const int LineWidth = 10;
    }

    public class Constants
	{
		public Constants()
		{
        var width = BoldLine.LineWidth;
        //width is 10

        Console.WriteLine(width);
		}
	}
}

