using System;
namespace GuideCSharp.Generictypes.Interfaceconformity
{
    interface IVehicle
    {
        void Test();
    }

    public class IConformity
	{
		public IConformity()
		{
            var service = new Service<IVehicle>();
            service.Add(new Car());
            service.Test();

            //service.Add(new Truck());//<- Error
        }
    }

    class Car : IVehicle
    {
        public void Test()
        {
            Console.WriteLine("Test car");
        }
    }

    class Truck { }

    class Service<T> where T : IVehicle
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

