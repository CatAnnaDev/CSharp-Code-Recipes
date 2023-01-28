using System;
namespace GuideCSharp.ReflectionLateBinding.UseDynamicType
{
	public class UseDynamicType
	{
		public UseDynamicType()
		{
            var carType = Type.GetType("Vehiclesss.Carsss");
            dynamic car = Activator.CreateInstance(carType);

            car.IncreaseSpeed(15);
            var speed = car.Speed;
            //speed is 15

            Console.WriteLine(speed);

        }
    }
}

namespace Vehiclesss
{
    public class Carsss
    {
        public int Speed { get; set; }

        public void IncreaseSpeed(int value)
        {
            Speed += value;
        }
    }
}

