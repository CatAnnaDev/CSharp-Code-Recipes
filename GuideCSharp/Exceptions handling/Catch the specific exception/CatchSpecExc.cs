using System;
using GuideCSharp.Exceptionshandling.Catchallexceptions;

namespace GuideCSharp.Exceptionshandling.Catchthespecificexception
{
	public class CatchSpecExc
	{
		public CatchSpecExc()
		{
            void ThrowWhenNullOrEmpty(List<int> list)
            {
                if (list == null)
                {
                    throw new IsNullException();
                }
                if (list.Count == 0)
                {
                    throw new IsEmptyException();
                }
            }

            try
            {
                var list = new List<int>();
                ThrowWhenNullOrEmpty(list);
            }
            catch (IsNullException)
            {
                Console.WriteLine("list is not specified");
            }
            catch (IsEmptyException e)
            {
                Console.WriteLine(e.GetType() + ": list is empty");
            }
        }
	}

    class IsNullException : Exception { }
    class IsEmptyException : Exception { }
}

