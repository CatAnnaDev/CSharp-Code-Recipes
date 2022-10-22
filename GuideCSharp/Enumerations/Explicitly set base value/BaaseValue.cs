using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.Explicitlysetbasevalue
{
    public class BaaseValue
    {
        enum Season
        {
            Summer = 1, Fall, Winter, Spring
        }

        public BaaseValue()
		{
            var baseWinter = (int)Season.Winter;
            //baseWinter is 3

            Console.WriteLine(baseWinter);
        }
	}
}

