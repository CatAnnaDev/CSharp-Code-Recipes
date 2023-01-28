using System;
using System.Threading.Tasks;
using System.Threading;

namespace GuideCSharp.MultiThreadedOperations.KeywordsAsyncAndAwait
{
	public class KeywordsAsyncAndAwait
	{
		public KeywordsAsyncAndAwait()
		{
            Task<int> Add(int a, int b)
            {
                return Task.Run(() => {
                    Thread.Sleep(3000);
                    return a + b;
                });
            }

            //Start new thread and wait for Add() result
            async void Test()
            {
                var result = await Add(5, 3);
                //result is 8

                Console.WriteLine($"result = {result}");
            }

            Test();
        }
	}
}

