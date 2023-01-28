using System;
using System.Xml.Linq;

namespace GuideCSharp.LINQ.LinQtoXML.RecursiveFunction
{
	public class RecursiveFunction
	{
		public RecursiveFunction()
		{
            //XML:
            //<p>
            //  <span">1;</span>
            //  <span">2;
            //    <span">2-1;</span>
            //    <span">2-2;</span>
            //  </span>
            //</p>

            var p = new XElement("p",
                new XElement("span", "1;"),
                new XElement("span", "2;",
                    new XElement("span", "2-1;"),
                    new XElement("span", "2-2;")));

            var spanCount = p.Descendants("span").Count();
            //spanCount is 4

            var values = (
                from span in p.DescendantNodes().OfType<XElement>()
                where span.Value.Contains("2")
                select span.Value
            ).ToArray();
            //values is {"2;2-1;2-2;", "2-1;", "2-2;"}

            Console.WriteLine(values);
            Console.WriteLine(spanCount);
        }
	}
}

