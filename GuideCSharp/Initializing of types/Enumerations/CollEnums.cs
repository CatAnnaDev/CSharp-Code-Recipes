using System;
namespace GuideCSharp.Initializingoftypes.Enumerations
{
	public class CollEnums
	{
        enum PreciousMetal
        {
            Platinum, Gold, Silver
        }

        enum Planet : byte
        {
            Mercury = 1, Venus, Earth
        }

        public CollEnums()
		{
            var gold = PreciousMetal.Gold;
            Planet earth = Planet.Earth;

            Console.WriteLine(gold);
            Console.WriteLine(earth);
        }
	}
}

