using System;
namespace GuideCSharp.Classes.Constants
{
	public class Constants
	{
		public Constants()
		{

            var months = Calendar.Months;
            //months is 12

            Console.WriteLine(months);
        }

        class Calendar
        {
            public const int Months = 12;
        }

	}
}

