using System;
using System.Threading;

namespace GuideCSharp.MultiThreadedOperations.SynchronizationWithBlocking
{
	public class SynchronizationWithBlocking
	{
        Random random = new();

        public SynchronizationWithBlocking()
		{
            void ShowNumber(object number)
            {
                //lock access for other threads
                lock (random)
                {
                    Thread.Sleep(random.Next(500));
                    Console.Write(number + ", ");
                }
            }

            //start ten threads
            for (int i = 1; i <= 10; i++)
            {
                var waitCall = new WaitCallback(ShowNumber);
                ThreadPool.QueueUserWorkItem(waitCall, i);
            }

            //result without lock: 8, 4, 9, 6, 1, 10, 7, 3, 2, 5
            //result with lock: 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        }
    }
}

