using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Structuralpatterns.AdapterInheritance
{
    // https://dl.dropbox.com/s/ob34ndfdfn88ivo/19201.png
    public class AdapterInheritance
	{
		public AdapterInheritance()
		{
            TextAdapter GetTextAdapter()
            {
                TextAdapter adapter = new TextAdapter();
                adapter.Add("line 1");
                adapter.Add("line 2");
                return adapter;
            }

            //Client
            var adapter = GetTextAdapter();
            var text = adapter.GetText();
            //text: line 1
            //      line 2

            Console.WriteLine(text);
        }
	}

    //Target
    interface IText
    {
        //Request()
        String GetText();
    }

    //Adaptee
    class StringList
    {
        readonly List<String> _rows =
        new List<String>();

        //SpecificRequest()
        public String GetString()
        {
            return string.Join("\n", _rows);
        }

        public void Add(String value)
        {
            _rows.Add(value);
        }
    }

    //Adapter
    class TextAdapter : StringList, IText
    {
        //Request()
        public String GetText()
        {
            return GetString();
        }
    }

}

