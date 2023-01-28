using System;
using System.Linq;

namespace GuideCSharp.Classes.Methods.Multiplereturnvalues
{
	public class MultiReturnValues
	{
		public MultiReturnValues()
		{
            var ar = new[] { 2, 3, 5 };
            var assistant = new ArrayAssistant(ar);
            var result = assistant.GetFirstLast();
            //result.Item1 is 2
            //result.Item2 is 5

            Console.WriteLine("first = {0}, last = {1}",result.Item1, result.Item2);
        }
	}

    class ArrayAssistant
    {
        private readonly int[] data;

        public ArrayAssistant(int[] ar)
        {
            data = ar;
        }
        public (int, int) GetFirstLast()
        {
            var first = -1;
            var last = -1;
            if (data.Any())
            {
                first = data[0];
                last = data[^1];
            }
            return (first, last);
        }
    }
}

