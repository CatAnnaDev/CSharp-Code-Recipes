using System;
namespace GuideCSharp.ReflectionLateBinding.InstanceInitialization
{
	public class InstanceInitialization
	{
		public InstanceInitialization()
		{
            var carType = Type.GetType("Vehicles.Cars");
            var car = Activator.CreateInstance(carType);

            Console.WriteLine(car);
        }
	}
}

namespace Vehicles
{
    public class Cars { }
}

