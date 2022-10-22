using System;
namespace GuideCSharp.Classes.Properties.TypeMembers
{
	public class TypeMem
	{
		public TypeMem()
		{
            Config.Port = 52;
            var connection = Config.GetConnection();
            //connection is "10.0.0.1:52"
            Console.WriteLine(connection);

            Config.Host = "10.0.0.3";
            connection = Config.GetConnection();
            //connection is "10.0.0.3:52"
            Console.WriteLine(connection);

            Console.WriteLine(Config.MaxConnections);
        }
	}

    class Config
    {
        //type constant
        public static readonly int MaxConnections = 3;

        //type fields
        public static string Host;
        public static int Port;

        //type method
        public static string GetConnection()
        {
            return $"{Host}:{Port}";
        }

        //type constructor
        static Config()
        {
            Host = "10.0.0.1";
        }
    }

}

