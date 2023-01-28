using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.ConversionMethods.ToLookupOperator
{
	public class ToLookupOperator
	{
        record Product(int Id, string Name);

        public ToLookupOperator()
		{
            var products = new List<Product> {
                new(1, "Car"),
                new(1, "Jet"),
                new(2, "Train")
            };

            var dic1 = products.ToLookup(p => p.Id);
            //dic1 is ILookup<int, Product> 

            Console.WriteLine(JsonSerializer.Serialize(dic1));

            var dic2 = products.ToLookup(p => p.Id, p => p.Name);
            //dic2 is ILookup<int, string> 

            Console.WriteLine(JsonSerializer.Serialize(dic2));
        }
	}
}

