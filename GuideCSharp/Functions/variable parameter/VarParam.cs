using System;
namespace GuideCSharp.Functions.variableparameter
{
	public class VarParam
	{
		public VarParam()
		{
            void Print5(string data)
            {
                if (data.Length > 5)
                {
                    data = data.Substring(0, 5);
                }
                Console.WriteLine(data);
            }

            Print5("1234567");
            //printed "12345"
        }
    }
}

