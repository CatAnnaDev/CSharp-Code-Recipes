using System;
namespace GuideCSharp.Generictypes.Defaultvalue
{
	public class DefValue
	{
		public DefValue()
		{
            var sizeInt = new Size<int> { Width = 5, Height = 9 };
            sizeInt.Reset();
            //Width is 0 and Height is 0

            Console.WriteLine($"{sizeInt.Width}, {sizeInt.Height}");

        }
	}

    class Size<T>
    {
        public T Width { get; set; }
        public T Height { get; set; }

        public void Reset()
        {
            Width = default;
            Height = default;
        }
    }
}

