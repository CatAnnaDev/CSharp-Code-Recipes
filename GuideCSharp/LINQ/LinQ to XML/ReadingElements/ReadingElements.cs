using System;
using System.Xml.Linq;
using System.Linq;

namespace GuideCSharp.LINQ.LinQtoXML.ReadingElements
{
	public class ReadingElements
	{
		public ReadingElements()
		{
            //XML:
            //<goods>
            //  <good>chair</good>
            //  <good>table</good>
            //  <service>haircut</service>
            //</goods>

            var goods = new XElement("goods",
                new XElement("good", "chair"),
                new XElement("good", "table"),
                new XElement("service", "haircut"));

            var count = goods.Elements().Count();
            //count is 3

            var goodsCount = goods.Elements("good").Count();
            //count is 2

            var servicesCount = goods.Elements().Count(e => e.Name == "service");
            //servicesCount is 1

            foreach (var e in goods.Elements())
            {
                Console.WriteLine(e.Name + ": " + e.Value);
            }
            //printed:
            //good: chair
            //good: table
            //service: haircut

            Console.WriteLine(count);
            Console.WriteLine(goodsCount);
            Console.WriteLine(servicesCount);
        }
	}
}

