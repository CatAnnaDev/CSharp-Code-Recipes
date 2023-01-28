using System;
namespace GuideCSharp.Patterns.Behavioralpatterns.Iterator
{
    // https://dl.dropbox.com/s/2hi1q8nwkpv7t3t/19304.png
    public class Iterator
	{
		public Iterator()
		{
            //Client
            var numbers = new PrimeNumbers();
            var iterator = numbers.GetIterator();
            int sum = 0;
            for (iterator.First(); !iterator.IsDone(); iterator.Next())
            {
                sum += iterator.CurrentItem();
            }
            //sum is 28

            Console.WriteLine(sum);
        }
	}

    //Iterator
    interface IIntIterator
    {
        void First();
        void Next();
        bool IsDone();
        int CurrentItem();
    }

    //Aggregate
    interface IIntAggregate
    {
        IIntIterator GetIterator();
    }

    //ConcreteAggregate
    class PrimeNumbers : IIntAggregate
    {
        readonly int[] _numbers = { 2, 3, 5, 7, 11 };

        public IIntIterator GetIterator()
        {
            return new Iterator(this);
        }

        //ConcreteIterator
        class Iterator : IIntIterator
        {
            int _index;
            readonly PrimeNumbers _parrent;

            public Iterator(PrimeNumbers parrent)
            {
                _parrent = parrent;
            }

            public void First()
            {
                _index = 0;
            }

            public void Next()
            {
                _index++;
            }

            public bool IsDone()
            {
                return _index >= _parrent._numbers.Length;
            }

            public int CurrentItem()
            {
                return _parrent._numbers[_index];
            }
        }
    }
}

