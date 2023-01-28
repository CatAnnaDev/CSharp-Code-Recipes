using System;
using System.Collections.Generic;

namespace GuideCSharp.Patterns.Structuralpatterns.AdapterComposition
{
    // https://dl.dropbox.com/s/lmilkf2955r81px/19202.png
    public class AdapterComposition
	{
		public AdapterComposition()
		{
            TextAdapter GetTextAdapter()
            {
                TextAdapter adapter = new TextAdapter();
                StringList rowList = new StringList();
                rowList.Add("line 1");
                rowList.Add("line 2");
                adapter.RowList = rowList;
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
    class TextAdapter : IText
    {

        public StringList RowList { get; set; }

        //Request()
        public String GetText()
        {
            if (RowList == null)
            {
                return "";
            }
            return RowList.GetString();
        }
    }

}

