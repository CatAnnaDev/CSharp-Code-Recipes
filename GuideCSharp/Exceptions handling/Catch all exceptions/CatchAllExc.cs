using System;
using System.Collections.Generic;

namespace GuideCSharp.Exceptionshandling.Catchallexceptions
{
	public class CatchAllExc
	{
		public CatchAllExc()
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
                ThrowWhenNullOrEmpty(null);
            }
            catch
            {
                Console.WriteLine("Error happened");
            }
        }
	}

    class IsNullException : Exception { }
    class IsEmptyException : Exception { }
}

