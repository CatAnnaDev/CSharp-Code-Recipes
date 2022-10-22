using System;
namespace GuideCSharp.ArraysandCollections.Arraywithdefaultvalue
{
    public class DefaultValue
    {
        public DefaultValue()
        {
            var value = 5;
            var count = 3;
            var array = new bool[count]
                .Select(_ => value).ToArray();
            //array is { 5, 5, 5 }

            foreach (var number in array)
            {
                Console.Write("{0}, ", number);
            }
        }
    }
}

