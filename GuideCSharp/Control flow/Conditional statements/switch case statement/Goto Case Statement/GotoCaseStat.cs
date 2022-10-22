using System;
namespace GuideCSharp.Controlflow.Conditionalstatements.switchcasestatement.GotoCaseStatement
{
	public class GotoCaseStat
	{
		public GotoCaseStat()
		{
            var firstNumber = "1";
            var numberList = "";
            switch (firstNumber)
            {
                case "1":
                    numberList = "1";
                    goto case "2";
                case "2":
                    numberList += "-2";
                    goto case "3";
                case "3":
                    numberList += "-3";
                    break;
            }
            //numbersList = "1-2-3"

            Console.WriteLine(numberList);
        }
	}
}

