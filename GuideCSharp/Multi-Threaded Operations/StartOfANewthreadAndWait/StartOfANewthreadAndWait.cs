using System;
namespace GuideCSharp.MultiThreadedOperations.StartOfANewthreadAndWait
{
	public class StartOfANewthreadAndWait
	{
		public StartOfANewthreadAndWait()
		{
            int Add(int a, int b)
            {
                Thread.Sleep(3000);
                return a + b;
            }

            var thread = new Thread(() => {
                var result = Add(3, 5);
                Console.WriteLine("result: " + result);
            });
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Start();
            //wait until thread is terminated
            thread.Join();

            Console.WriteLine("main thread");
            //output:
            //result: 8
            //main thread  
        }
    }
}

