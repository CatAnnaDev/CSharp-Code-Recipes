using System;
namespace GuideCSharp.Classes.Properties.Typeproperties
{
	public class TypeProp
	{
		public TypeProp()
		{
            var lesson1 = new Lesson();
            //Lesson.LessonsCount is 1
            Console.WriteLine(Lesson.LessonsCount);

            var lesson2 = new Lesson();
            //Lesson.LessonsCount is 2
            Console.WriteLine(Lesson.LessonsCount);

        }
    }

    class Lesson
    {
        //type property
        public static int LessonsCount { get; set; }

        public Lesson()
        {
            LessonsCount++;
        }
    }
}

