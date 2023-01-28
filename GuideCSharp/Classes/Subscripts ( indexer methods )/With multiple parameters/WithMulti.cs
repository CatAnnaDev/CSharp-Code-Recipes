using System;
using System.Collections.Generic;

namespace GuideCSharp.Classes.Properties.Subscriptsindexermethods.Withmultipleparameters
{
	public class WithMulti
	{
		public WithMulti()
		{
            var prices = new ToyotaPrices
            {
                ["Rush", 2012] = 16818,
                ["Land Cruiser", 2014] = 54988
            };

            var priceRav4 = prices["RAV4", 2015];
            //priceRav4 is 0
            var priceRush = prices["Rush", 2012];
            //priceRush is 16818

            Console.WriteLine("{0}, {1}", priceRav4, priceRush);
        }
	}

    class Car
    {
        public string Model { get; }
        public int Year { get; }
        public int Price { get; set; }

        public Car(string model, int year, int price)
        {
            Model = model;
            Year = year;
            Price = price;
        }
    }

    class ToyotaPrices
    {
        private readonly List<Car> _cars = new();

        public int this[string model, int year]
        {
            get
            {
                var car = FindCar(model, year);
                return car?.Price ?? 0;
            }
            init
            {
                var car = FindCar(model, year);
                if (car == null)
                {
                    car = new Car(model, year, value);
                    _cars.Add(car);
                }
                else
                    car.Price = value;
            }
        }

        private Car FindCar(string model, int year) => _cars.SingleOrDefault(c => c.Model == model && c.Year == year);
    }
}