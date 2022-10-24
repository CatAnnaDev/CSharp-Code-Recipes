using System;
namespace GuideCSharp.Generictypes.Classconformity
{
	public class ClassConfo
	{
		public ClassConfo()
		{
            var vehicle = new Vehicle();
            var car = new Car();
            var truck = new Truck();

            var service = new Service<Vehicle>();
            service.Add(vehicle);
            service.Add(car);
            service.Test();

            //service.Add(truck);//<- Error
        }
    }

    class Vehicle
    {
        public void Test()
        {
            Console.WriteLine("Test vehicle");
        }
    }

    class Car : Vehicle { }

    class Truck { }

    class Service<T> where T : Vehicle
    {
        readonly List<T> _list = new();

        public void Add(T item)
        {
            _list.Add(item);
        }

        public void Test()
        {
            foreach (var item in _list)
            {
                item.Test();
            }
        }
    }
}

