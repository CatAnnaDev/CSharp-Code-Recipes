using System;
namespace GuideCSharp.Classes.Methods.VarParameters
{
	public class VarParam
	{
		public VarParam()
		{
            var log = new Log();
            log.Print5("1234567");
            //printed "12345"

            Console.WriteLine("LastData = " + log.LastData);
        }
	}

    class Log
    {
        public string LastData { get; set; }

        public void Print5(string data)
        {
            LastData = data;
            if (data.Length > 5)
            {
                data = data.Substring(0, 5);
            }
            Console.WriteLine(data);
        }
    }
}

