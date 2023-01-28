using System;
namespace GuideCSharp.LambdaExpressions.VoidFunctionWithParameter
{
	public class VoidFunctionWithParameter
	{
		public VoidFunctionWithParameter()
		{
            void CheckAndProcess(int number, Action<int> process)
            {
                if (number < 10)
                {
                    process(number);
                }
            }

            Action<int> process = number => {
                Console.WriteLine(number * 10);
            };

            CheckAndProcess(5, process);
            //printed: 50
        }
    }
}

