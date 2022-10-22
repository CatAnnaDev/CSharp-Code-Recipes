using System;
namespace GuideCSharp.Classes.Properties.ReadOnlyProperties.Storedproperties
{
	public class StoredProp
	{
		public StoredProp()
		{
            var filmList = new FilmList();
            var count = filmList.Count;
            //count is 10

            Console.WriteLine(count);
        }
	}

    class FilmList
    {
        public int Count { get; }

        public FilmList()
        {
            Count = 10;
        }
    }
}

