using System;
using GuideCSharp.Classes.Properties.Typeproperties;

namespace GuideCSharp.Enumerations.getalistofvalue
{
	public class ListOfValue
    {
        enum Season
        {
            Summer, Fall, Winter, Spring
        }

        public ListOfValue()
		{
            var values = Enum.GetValues(typeof(Season));
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }
	}
}

