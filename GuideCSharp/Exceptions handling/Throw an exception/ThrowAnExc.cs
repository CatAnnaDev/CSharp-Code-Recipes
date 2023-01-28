using System;
using System.Collections.Generic;

namespace GuideCSharp.Exceptionshandling.Throwanexception
{
	public class ThrowAnExc
	{
		public ThrowAnExc()
		{
            var seller = new Seller();
            try
            {
                seller.Sell(); //<-Error 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                //e.Message is "No cars for sale"
            }
        }
	}

    class Car { }

    class Seller
    {
        List<Car> cars = new();

        public void Sell()
        {
            if (cars.Count == 0)
            {
                throw new Exception("No cars for sale");
            }
            //some implementation...
        }
    }
}

