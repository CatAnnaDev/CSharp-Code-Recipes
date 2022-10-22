using System;
namespace GuideCSharp.Controlflow.interruptionofacontrolflow.breakstatement
{
	public class BreakStat
	{
		public BreakStat()
		{
            var numbers = new[] { 2, 3, 5, 7, 11, 13, 17, 19 };
            var str = "";
            foreach (var number in numbers)
            {
                if (number > 10)
                    break;
                str += (str == "" ? "" : "-") + number;
            }
            //str is "2-3-5-7"

            Console.WriteLine(str);
        }
	}
}

