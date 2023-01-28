using System;
namespace GuideCSharp.MultiThreadedOperations.AsyncDelegatCall
{
	public class AsyncDelegateCall
    {
		public AsyncDelegateCall()
		{
            Action<int> action = i => {
                Thread.Sleep(3000);
                Console.WriteLine(i * 10);
            };

            //Run lambda at new thread
            Task.Run(() => action(5));

            Console.WriteLine("Main thread");
        }
	}
}

