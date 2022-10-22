using System;
namespace GuideCSharp.Classes.Createandcopyoftheobject
{
	public class Createcopy
	{
		public Createcopy()
		{
            var square = new Shape
            {
                Name = "Square"
            };

            //not deep copy
            var squareCopy = (Shape)square.Clone();

            Console.WriteLine(squareCopy.Name);
        }

        class Shape : ICloneable
        {
            public string Name { get; init; }

            public object Clone()
            {
                return MemberwiseClone();
            }
        }
    }
}

