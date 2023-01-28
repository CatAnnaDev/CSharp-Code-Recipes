using System;
using System.Xml.Linq;
using System.Linq;

namespace GuideCSharp.LINQ.LinQtoXML.ReadingOneElement
{
	public class ReadingOneElement
	{
		public ReadingOneElement()
		{
            //XML:
            //<goods>
            //  <good id="1">chair</good>
            //  <good id="2">table</good>
            //</goods>

            var goods = new XElement("goods",
                new XElement("good", "chair",
                    new XAttribute("id", 1)),
                new XElement("good", "table",
                    new XAttribute("id", 2)));

            var value = goods.Element("good")?.Value;
            //value is "chair"

            Console.WriteLine(value);
        }
	}
}

