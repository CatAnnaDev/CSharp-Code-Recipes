using System;
namespace GuideCSharp.Classes.Events
{
	public class ClassEvent
	{
		public ClassEvent()
		{
            var statistic = new Statistic();
            var heroes = new Game { Name = "Heroes" };
            var doom = new Game { Name = "Doom" };

            //subscribe to events
            heroes.GameStarted += statistic.GameStarted;
            doom.GameStarted += statistic.GameStarted;

            doom.Start();
            heroes.Start();
            //statistic.LastGame is "Heroes"
            //statistic.StartsCount is 2

            Console.WriteLine("{0}", statistic.LastGame);
            Console.WriteLine("{0}", statistic.StartsCount);
        }
	}

    class Game
    {
        public string Name { get; init; }

        public delegate void GameHandler(string name);
        public event GameHandler GameStarted;

        public void Start()
        {
            GameStarted?.Invoke(Name);
        }
    }

    class Statistic
    {
        public int StartsCount { get; private set; }
        public string LastGame { get; private set; }

        public void GameStarted(string name)
        {
            StartsCount++;
            LastGame = name;
        }
    }
}

