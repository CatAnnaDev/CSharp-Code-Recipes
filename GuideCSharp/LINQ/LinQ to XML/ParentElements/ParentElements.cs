using System;
using System.Xml.Linq;
using System.Linq;

namespace GuideCSharp.LINQ.LinQtoXML.ParentElements
{
	public class ParentElements
	{
		public ParentElements()
		{
            //XML:
            //<h1><p><span>text</span></p></h1>

            var h1 =
            new XElement("h1",
                new XElement("p",
                    new XElement("span", "text")));

            var span = h1.Descendants("span").Single();
            //span.Value is "text"
            var parent = span.Parent;
            //parent.Name is "p"
            var root = span.Ancestors().Last();
            //root.Name is "h1"

            Console.WriteLine(span.Value);
            Console.WriteLine(parent?.Name);
            Console.WriteLine(root.Name);
        }
	}
}

