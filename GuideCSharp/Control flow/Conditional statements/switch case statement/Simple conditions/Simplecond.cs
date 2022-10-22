using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.switchcasestatement.Simpleconditions
{
	public class Simplecond
	{
		public Simplecond()
		{
            int GetSize()
            {
                return 24;
            }

            int monitorInchSize = GetSize();
            string str = monitorInchSize switch
            {
                15 => "too small",
                16 or 17 or 18 => "good for the past decade",
                19 or 20 or 21 or 22 or 23 => "for office work",
                24 or 25 or 26 or 27 => "great choice",
                _ => ""
            };
            //str is "great choice"

            Console.WriteLine(str);
        }
	}
}

