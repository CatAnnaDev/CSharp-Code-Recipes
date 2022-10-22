using System;
namespace GuideCSharp.Controlflow.interruptionofacontrolflow.returnstatement.withanyreturnvalue
{
	public class WithAnyValue
	{
		public WithAnyValue()
		{
            void PrintSomeData(bool printAll)
            {
                PrintMainData();
                if (!printAll)
                    return;
                PrintOtherData();
            }

            void PrintMainData()
            {
                Console.WriteLine("print main data");
            }

            void PrintOtherData()
            {
                Console.WriteLine("print other data");
            }

            PrintSomeData(false);
        }
	}
}

