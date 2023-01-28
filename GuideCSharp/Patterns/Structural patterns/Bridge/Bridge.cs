using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Structuralpatterns.Bridge
{
    // https://dl.dropbox.com/s/8dya1s8a8afdesa/19203.png
    public class Bridge
	{
		public Bridge()
		{
            TextMaker FillTextBuilder(TextImp textImp)
            {
                TextMaker textMaker = new TextMaker(textImp);
                textMaker.AddLine("line 1");
                textMaker.AddLine("line 2");
                return textMaker;
            }

            //Client
            TextMaker textMaker = FillTextBuilder(new TextBuilder());
            string text = textMaker.GetText();
            //test: line 1
            //      line 2

            TextMaker htmlMaker = FillTextBuilder(new HtmlBuilder());
            string html = htmlMaker.GetText();
            //html: <span>line 1</span><br/>
            //      <span>line 2</span><br/>

            Console.WriteLine(text);
            Console.WriteLine(html);
        }
	}

    //Abstraction
    abstract class AText
    {
        protected TextImp TextImp;

        //Operations
        public abstract string GetText();
        public abstract void AddLine(string value);
    }

    //RefinedAbstraction
    class TextMaker : AText
    {

        public TextMaker(TextImp textImp)
        {
            TextImp = textImp;
        }

        public override string GetText()
        {
            return TextImp.GetString();
        }

        public override void AddLine(string value)
        {
            TextImp.AppendLine(value);
        }
    }

    //Implementator
    abstract class TextImp
    {
        protected readonly List<string> Rows = new();

        public string GetString()
        {
            return string.Join("\n", Rows);
        }

        public abstract void AppendLine(string value);
    }

    //ConcreteImplementator1
    class TextBuilder : TextImp
    {

        public override void AppendLine(string value)
        {
            Rows.Add(value);
        }
    }

    //ConcreteImplementator1
    class HtmlBuilder : TextImp
    {

        public override void AppendLine(string value)
        {
            Rows.Add("<span>" + value + "</span><br/>");
        }
    }

}

