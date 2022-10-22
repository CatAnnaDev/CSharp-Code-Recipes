using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.Convertingtostring
{
    public class convString
    {
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public convString()
		{
            var summer = Season.Summer;
            var strValue = summer.ToString();
            //strValue is "Summer"

            Console.WriteLine(strValue);
        }
	}
}

