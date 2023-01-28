using System;
namespace GuideCSharp.Patterns.Creationalpatterns.Singleton
{
    // https://dl.dropboxusercontent.com/s/qazwm8ensalahqw/19105.png
    public class Singleton
	{
		public Singleton()
		{
            //Client
            Settings settings = Settings.GetInstance();
            //Settings settings = new Settings(); //<- Error

            settings.Host = "192.168.100.1";
            settings.Port = 33;

            Settings settings1 = Settings.GetInstance();
            //settings1.Port is 33

            Console.WriteLine(settings1.Port);
        }
	}

    //Singleton
    class Settings
    {
        static Settings _instance;

        public static Settings GetInstance()
        {
            return _instance ?? (_instance = new Settings());
        }

        private Settings() { }

        public int Port { get; set; }
        public string Host { get; set; }
    }
}

