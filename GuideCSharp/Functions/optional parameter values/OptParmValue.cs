using System;
namespace GuideCSharp.Functions.optionalparametervalues
{
	public class OptParmValue
	{
		public OptParmValue()
		{
            void SayGoodby(string message = "Goodby!")
            {
                Console.WriteLine(message);
            }

            SayGoodby();
            //printed "Goodby!"

            SayGoodby("see you");
            //printed "see you"
        }
    }
}

