using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.ConversionMethods.OfTypeOperator
{
	public class OfTypeOperator
	{
        class Car { }

        class Truck : Car { }

        public OfTypeOperator()
		{
            Car[] cars1 = {new Truck(), new Truck()};
            var trucks1 = cars1.OfType<Truck>();
            //trucks1.Count() is 2

            Car[] cars2 = {new Truck(), new Car()};
            var trucks2 = cars2.OfType<Truck>();
            //trucks2.Count() is 1

            Console.WriteLine(JsonSerializer.Serialize(trucks1));
            Console.WriteLine(JsonSerializer.Serialize(trucks2));
        }
	}
}

