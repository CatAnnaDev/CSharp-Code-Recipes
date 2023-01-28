using System;
using System.Threading;

namespace GuideCSharp.MultiThreadedOperations.StartOfANewthread
{
	public class StartOfANewthread
	{
		public StartOfANewthread()
		{
            int Add(int a, int b)
            {
                Thread.Sleep(3000);
                return a + b;
            }

            var thread = new Thread(() => {
                var result = Add(3, 5);
                Console.WriteLine("result: " + result);
            })
            {
                Priority = ThreadPriority.BelowNormal
            };
            thread.Start();

            Console.WriteLine("main thread");
            //output:
            //main thread
            //result: 8
        }
    }
}

