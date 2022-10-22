using System;
namespace GuideCSharp.Classes.Methods.Withoutanyreturnvalue
{
	public class WithoutanyReturnValue
	{
		public WithoutanyReturnValue()
		{
            var counter = new Counter();
            counter.IncBy(1);
            //counter.Count is 1

            counter.IncBy(2, 5);
            //counter.Count is 11

            Console.WriteLine(counter.Count);
        }
	}

    class Counter
    {
        public int Count { get; private set; }

        public void IncBy(int value)
        {
            Count += value;
        }

        public void IncBy(int value, int amount)
        {
            Count += value * amount;
        }
    }
}

