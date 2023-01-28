using System;
namespace GuideCSharp.Functions.optionalparametervalues
{
	public class OptParmValue
	{
		public OptParmValue()
		{
            void SayGoodbye(string message = "Goodbye!")
            {
                Console.WriteLine(message);
            }

            SayGoodbye();
            //printed "Goodbye!"

            SayGoodbye("see you");
            //printed "see you"
        }
    }
}

