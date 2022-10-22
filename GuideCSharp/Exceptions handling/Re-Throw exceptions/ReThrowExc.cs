using System;
namespace GuideCSharp.Exceptionshandling.ReThrowexceptions
{
	public class ReThrowExc
	{
		public ReThrowExc()
		{
            void MethodWithException()
            {
                try
                {
                    throw new Exception("test exception");
                }
                catch (Exception e)
                {
                    //implementation of any partial processing
                    //and send error to the calling code
                    throw;
                }
            }

            try
            {
                MethodWithException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
	}
}

