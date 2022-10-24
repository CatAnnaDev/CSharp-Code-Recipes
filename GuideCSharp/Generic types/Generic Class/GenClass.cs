using System;
namespace GuideCSharp.Generictypes.GenericClass
{
	public class GenClass
	{
		public GenClass()
		{
            var sizeInt = new Size<int>(5, 8);
            var textInt = sizeInt.AsText();
            //textInt is "[5; 8]"

            var sizeFloat = new Size<float>(3.7f, 1.58f);
            var textFloat = sizeFloat.AsText();
            //textFloat is "[3.7; 1.58]"

            Console.WriteLine(textInt);
            Console.WriteLine(textFloat);
        }
	}

    class Size<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }

        public Size(T width, T height)
        {
            Width = width;
            Height = height;
        }

        public string AsText()
        {
            return $"[{Width}; {Height}]";
        }
    }
}

