using System;
namespace GuideCSharp.Exceptionshandling.Methodthrowinganexception
{
	public class MethThrowExc
	{
		public MethThrowExc()
		{
            //any method can throw an error
            void MethodWithException()
            {
                throw new Exception("test exception");
            }
        }
	}
}

