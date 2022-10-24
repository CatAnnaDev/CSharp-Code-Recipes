using System;
namespace GuideCSharp.Generictypes.Parameterlessconstructor
{
	public class ParamLessConstru
	{
		public ParamLessConstru()
		{
            static void Swap<T>(ref T a, ref T b) where T : new()
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            var c1 = new Car("Cami");
            var c2 = new Car("Rush");
            //Swap(ref c1, ref c2);//<- Error
            Console.WriteLine($"{c1.Name}, {c2.Name}");

            var t1 = new Truck { Name = "Kamaz" };
            var t2 = new Truck { Name = "Ural" };
            Swap(ref t1, ref t2);
            Console.WriteLine($"{t1.Name}, {t2.Name}");
        }
	}

    class Car
    {
        public string Name { get; }

        public Car(string name)
        {
            Name = name;
        }
    }

    class Truck
    {
        public string Name { get; init; }
    }
}

