using System;
using System.Text.Json;
using System.Linq;
using System.Collections.Generic;

namespace GuideCSharp.LINQ.ConversionMethods.ToDictionaryOperator
{
	public class ToDictionaryOperator
	{
        record Product(int Id, string Name);

        public ToDictionaryOperator()
		{
            var products = new List<Product> {
                new(1, "Car"),
                new(2, "Jet")
            };

            var dic1 = products.ToDictionary(p => p.Id);
            //dic1 is Dictionary<int, Product> 

            Console.WriteLine(JsonSerializer.Serialize(dic1));

            var dic2 = products.ToDictionary(p => p.Id, p => p.Name);
            //dic2 is Dictionary<int, string> 

            Console.WriteLine(JsonSerializer.Serialize(dic2));
        }
	}
}

