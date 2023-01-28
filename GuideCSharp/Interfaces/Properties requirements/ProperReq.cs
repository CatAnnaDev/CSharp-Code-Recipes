using System;

namespace GuideCSharp.Interfaces.Propertiesrequirements
{
	public class ProperReq
	{
        public ProperReq()
		{
            var car = new Airwave();
            Console.WriteLine($"Name = {car.Name}");
            Console.WriteLine($"EngineVolume = {car.EngineVolume}");

        }
    }

    interface ICar
    {
        int EngineVolume { get; set; }
        string Name { get; }
    }

    class Airwave : ICar
    {
        public int EngineVolume { get; set; } = 1500;

        public string Name => "Honda Airwave";
    }
}

