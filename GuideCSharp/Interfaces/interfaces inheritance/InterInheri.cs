using System;
namespace GuideCSharp.Interfaces.interfacesinheritance
{
	public class InterInheri
	{
        interface IVehicle
        {
            int MaxSpeed { get; }
        }

        interface ITruck : IVehicle
        {
            int Capacity { get; }
        }

        class Kamaz5320 : ITruck
        {

            public int MaxSpeed => 85;

            public int Capacity => 8000;
        }

        public InterInheri()
		{
            var kamaz = new Kamaz5320();
            var vehicle = (IVehicle)kamaz;
            var maxSpeed = vehicle.MaxSpeed;
            //maxSpeed is 85

            Console.WriteLine("{0}", maxSpeed);

        }
    }
}

