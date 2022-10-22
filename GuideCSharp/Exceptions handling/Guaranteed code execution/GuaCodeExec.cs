using System;
namespace GuideCSharp.Exceptionshandling.Guaranteedcodeexecution
{
	public class GuaCodeExec
	{
		public GuaCodeExec()
		{
            void ThrowIfTrue(bool param)
            {
                try
                {
                    if (param)
                    {
                        throw new Exception("test exception");
                    }
                }
                catch
                {
                    Console.WriteLine("catch");
                }
                finally
                {
                    Console.WriteLine("finally");
                }
            }

            ThrowIfTrue(true);
            //printed: "catch" and "finally"
            ThrowIfTrue(false);
            //printed only "finally"

            Console.ReadLine();
        }
	}
}

