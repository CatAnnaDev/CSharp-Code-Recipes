using System;
namespace GuideCSharp.Controlflow.interruptionofacontrolflow.Continuestatement
{
	public class contStat
	{
		public contStat()
		{
            var numbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            var str = "";
            for (var i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 1)
                    continue;
                str += (str == "" ? "" : "-") + numbers[i];
            }
            //str is "2-5-11-17" 

            Console.WriteLine(str);
        }
	}
}

