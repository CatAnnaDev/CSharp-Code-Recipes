using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.ifelsestatements.ValidExample2
{
	public class VE2
	{
		public VE2()
		{
            int GetLatitude()
            {
                return 90;
            }

            var latitude = GetLatitude();
            string location;
            if (latitude == 0)
                location = "Equator";
            else if (latitude == 90)
                location = "north Pole";
            else if (latitude == -90)
                location = "south Pole";
            else
                location = "not at the Equator or Pole";

            Console.WriteLine(location);
        }
	}
}

