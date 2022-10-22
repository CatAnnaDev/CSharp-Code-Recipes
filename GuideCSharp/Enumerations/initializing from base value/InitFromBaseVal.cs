using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.initializingfrombasevalue
{
	public class InitFromBaseVal
    {
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public InitFromBaseVal()
		{
            Season winter = (Season)2;
            //winter is Season.Winter

            Console.WriteLine(winter);
        }
	}
}

