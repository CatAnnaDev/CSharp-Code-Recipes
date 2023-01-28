using System;
using System.Threading;

namespace GuideCSharp.Classes.Properties.LazyFields
{
	public class LazyFields
	{
		public LazyFields()
		{
            var player = new MediaPlayer();
            //Films field not yet been created
            //It will be created after call Films.Value property
            var filmList = player.Films.Value;

            Console.WriteLine(filmList);
        }
	}

    class FilmsList
    {
        public FilmsList()
        {
            //some long operation
            Thread.Sleep(1000);
        }
    }

    class MediaPlayer
    {
        public readonly Lazy<FilmsList> Films = new();
    }
}

