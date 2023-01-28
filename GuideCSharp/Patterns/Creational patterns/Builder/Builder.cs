using System;
namespace GuideCSharp.Patterns.Creationalpatterns.Builder
{
    // https://dl.dropboxusercontent.com/s/z2i6wg6m2s68o0r/19102.png
    public class Builder
	{
		public Builder()
		{
            //Client
            TextMaker textMaker = new TextMaker();

            TextBuilder textBuilder = new TextBuilder();
            textMaker.MakeText(textBuilder);
            String text = textBuilder.GetText();
            //text: line 1
            //      line 2

            HtmlBuilder htmlBuilder = new HtmlBuilder();
            textMaker.MakeText(htmlBuilder);
            String html = htmlBuilder.GetHtml();
            //html: <span>line 1</span><br/>
            //      <span>line 2</span>

            Console.WriteLine(text);
            Console.WriteLine(html);
        }
	}

    //AbstractBuilder
    interface ITextBuilder
    {
        void AddText(String text);
        void AddNewLine(String text);
    }

    //ConcreteBuilder 1
    class TextBuilder : ITextBuilder
    {
        String _text = "";

        public void AddText(String value)
        {
            _text += value;
        }

        public void AddNewLine(String value)
        {
            _text += "\n" + value;
        }

        public String GetText()
        {
            return _text;
        }
    }

    //ConcreteBuilder 2
    class HtmlBuilder : ITextBuilder
    {
        String _html = "";

        public void AddText(String value)
        {
            _html += "<span>" + value + "</span>";
        }

        public void AddNewLine(String value)
        {
            _html += "<br/>\n";
            AddText(value);
        }

        public String GetHtml()
        {
            return _html;
        }
    }

    //Director
    class TextMaker
    {
        public void MakeText(ITextBuilder textBuilder)
        {
            textBuilder.AddText("line 1");
            textBuilder.AddNewLine("line 2");
        }
    }
}

