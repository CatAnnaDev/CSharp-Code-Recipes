using System;
namespace GuideCSharp.Interfaces.defaultmethods
{
	public class DefMeth
	{
        //C# 8 feature
        interface IText
        {
            public string AsText()
            {
                return "text";
            }
        }

        interface IHtml
        {
            public string AsHtml()
            {
                return "<span>html</span>";
            }
        }

        class TextHtml : IText, IHtml { }

        public DefMeth()
		{
            var tHtml = new TextHtml();
            var text = ((IText)tHtml).AsText();
            //text is "text"

            var html = (tHtml as IHtml).AsHtml();
            //html is "<span>html</span>"

            Console.WriteLine(text);
            Console.WriteLine(html);
        }
	}
}

