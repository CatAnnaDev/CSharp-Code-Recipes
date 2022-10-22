using System;
namespace GuideCSharp.Enumerations.Conversionfromstring
{
	public class convString
	{
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public convString()
		{
            Enum.TryParse("Summer", out Season summer);
            //summer is Season.Summer

            Console.WriteLine(summer);
        }
	}
}

