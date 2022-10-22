using System;
namespace GuideCSharp.ArraysandCollections.QueuTFIFO
{
	public class Queu
	{
		public Queu()
		{
            var intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(3);
            intQueue.Enqueue(5);

            var top = intQueue.Peek();
            //top is 1
            var first = intQueue.Dequeue();
            //first is 1
            var second = intQueue.Dequeue();
            //second is 3
            var third = intQueue.Dequeue();
            //third is 5

            Console.WriteLine("{0}, {1}, {2}, {3}", top, first, second, third);
        }
	}
}

