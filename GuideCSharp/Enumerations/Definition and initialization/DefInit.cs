using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.Definitionandinitialization
{
    public class DefInit
    {
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public DefInit()
		{
            var summer = Season.Summer;
            Season winter = Season.Winter;

            Console.WriteLine("{0}, {1}", summer, winter);
        }
	}
}

