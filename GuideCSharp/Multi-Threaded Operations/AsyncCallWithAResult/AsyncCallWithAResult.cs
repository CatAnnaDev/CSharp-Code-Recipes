using System;
using System.Data.SqlTypes;

namespace GuideCSharp.MultiThreadedOperations.AsyncCallWithAResult
{
	public class AsyncCallWithAResult
	{
        delegate int DelBinary(int a, int b);

        public AsyncCallWithAResult()
		{
            int Add(int a, int b)
            {
                Thread.Sleep(3000);
                return a + b;
            }

            //Invoked at the end of the delegate
            void DelComplete(IAsyncResult result)
            {
                var delBinary = (DelBinary)result.AsyncState;
                var addResult = delBinary.EndInvoke(result);
                //addResult is 8

                Console.WriteLine(addResult);
            }

            var delBinary = new DelBinary(Add);
            //Asynchronous method call Add()
            //not supported on C# 9
            delBinary.BeginInvoke(5, 3, DelComplete, null);

            
        }
	}
}

