using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Structuralpatterns.Flyweight
{
    // https://dl.dropbox.com/s/plfxbs68oaing9l/19207.png
    public class Flyweight
	{
		public Flyweight()
		{
            //Client
            CharFactory factory = new CharFactory();
            ISpan charA = factory.GetChar('A');
            charA.PrintSpan("font-size: 12");

            ISpan charB = factory.GetChar('B');
            charB.PrintSpan("font-size: 12");

            ISpan charA1 = factory.GetChar('A');
            charA1.PrintSpan("font-size: 12");

            bool equal = charA == charA1;
            //equal is true

            Console.WriteLine(equal);
        }
	}

    //Flyweight
    interface ISpan
    {
        void PrintSpan(string style);
    }

    //ConcreteFlyweight
    class Char : ISpan
    {
        private readonly char _c;

        public Char(char c)
        {
            _c = c;
        }

        //Operation(extrinsicState)
        public void PrintSpan(string style)
        {
            Console.WriteLine("<span style=\"" +
                style + "\">" + _c + "</span>");
        }
    }

    //FlyweightFactory
    class CharFactory
    {
        readonly Dictionary<char, Char> _chars = new();

        //GetFlyweight(key)
        public ISpan GetChar(char c)
        {
            Char character;
            if (_chars.ContainsKey(c))
            {
                character = _chars[c];
            }
            else
            {
                character = new Char(c);
                _chars.Add(c, character);
            }
            return character;
        }
    }
}

