using System;
namespace GuideCSharp.Interfaces.explicitimplementation
{
	public class ExplicitImplem
	{
        interface IText
        {
            string AsText();
        }

        interface IHtml
        {
            string AsText();
        }

        class Uid : IText, IHtml
        {
            public int Id { get; init; }

            string IText.AsText()
            {
                return Id.ToString();
            }

            string IHtml.AsText()
            {
                return $"<span>{Id}</span>";
            }
        }

        public ExplicitImplem()
		{
            var uid = new Uid { Id = 314 };
            var text = ((IText)uid).AsText();
            //text is "314"
            Console.WriteLine(text);

            var html = ((IHtml)uid).AsText();
            //html is "<span>314</span>"
            Console.WriteLine(html);
        }
	}
}

