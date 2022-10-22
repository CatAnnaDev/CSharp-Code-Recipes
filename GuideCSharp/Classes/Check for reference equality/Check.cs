using System;
namespace GuideCSharp.Classes.Checkforreferenceequality
{
	public class Check
	{
        public Check()
        {
            var car1 = new Car();
            var car2 = new Car();
            var car3 = car1;

            var equal1 = car1 == car2;
            //equal1 is False

            var equal2 = car1 == car3;
            //equal2 is True

            Console.WriteLine(equal1);
            Console.WriteLine(equal2);
        }

            class Car { }

	}
}

