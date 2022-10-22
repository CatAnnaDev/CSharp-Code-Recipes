using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.Basemembervalue
{
    public class BaseMemVal
    {
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public BaseMemVal()
		{
            var winter = Season.Winter;
            var baseValue = (int)winter;
            //baseValue is 2

            Console.WriteLine("{0}, {1}", baseValue, winter);
        }
    }
}

