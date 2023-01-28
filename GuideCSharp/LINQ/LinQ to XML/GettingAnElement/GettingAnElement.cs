using System;
using System.Xml.Linq;
using System.Linq;

namespace GuideCSharp.LINQ.LinQtoXML.GettingAnElement
{
	public class GettingAnElement
	{
		public GettingAnElement()
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

            //getting an element with the id = 1 attribute
            //first method
            var value1 = goods.Elements().Single(e => {
                    var attr = e.Attribute("id");
                    return attr != null && attr.Value == "1";
                }).Value;
            //value1 is "chair"

            //second method
            var value2 =
            (from e in goods.Elements()
             let attr = e.Attribute("id")
             where attr != null && attr.Value == "1"
             select e).Single().Value;
            //value2 is "chair"

            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }
	}
}

