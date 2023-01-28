using System;
namespace GuideCSharp.LINQ.ConversionMethods.CastOperator
{
    class Car { }

    class Truck : Car { }

    public class CastOperator
	{
		public CastOperator()
		{
            Car[] cars1 = { new Truck(), new Truck() };
            var trucks1 = cars1.Cast<Truck>();
            //trucks1.Count() is 2
            Car[] cars2 = {new Truck(), new Car()};

            var trucks2 = cars2.Cast<Truck>();
            //trucks2.Count() is 2

            foreach (var item in trucks1)
            {
                Console.WriteLine(item);
            }

            foreach (var item in trucks2)//<-Cast error
            { 
                Console.WriteLine(item);
            }
        }
	}
}

