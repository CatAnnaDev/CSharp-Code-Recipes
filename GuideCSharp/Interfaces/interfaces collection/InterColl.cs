using System;
namespace GuideCSharp.Interfaces.interfacescollection
{
	public class InterColl
	{
        interface INamed
        {
            string Name { get; }
        }

        record Flower(string Name) : INamed;

        record City(string Name) : INamed;

        record Star(string Name) : INamed;

        public InterColl()
		{
            var rows = new INamed[] {
            new Flower( "Rose"),
            new City("Rome"),
            new Star("Sirius") };

            var list = string.Join(", ", rows.Select(r => r.Name));
            //list is Rose, Rome, Sirius
            Console.WriteLine(list);
        }
	}
}

