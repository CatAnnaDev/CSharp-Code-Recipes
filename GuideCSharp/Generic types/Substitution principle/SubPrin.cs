using System;
using System.Collections.Generic;

namespace GuideCSharp.Generictypes.Substitutionprinciple
{
	public class SubPrin
	{
		public SubPrin()
		{
            var list = new List<Vehicle>();
            var vehicle = new Vehicle();
            var car = new Car();
            var truck = new Truck();

            list.Add(vehicle);
            list.Add(car);
            list.Add(truck);

            foreach (var curVehicle in list)
            {
                curVehicle.Test();
            }
        }
	}

    class Vehicle
    {
        public void Test()
        {
            Console.WriteLine("Test " + GetType());
        }
    }

    class Car : Vehicle { }

    class Truck : Vehicle { }
}

