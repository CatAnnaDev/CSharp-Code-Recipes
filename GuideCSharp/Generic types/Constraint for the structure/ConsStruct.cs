using System;
namespace GuideCSharp.Generictypes.Constraintforthestructure
{
	public class ConsStruct
	{
		public ConsStruct()
		{
            void Swap<T>(ref T a, ref T b) where T : struct
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            var c1 = new Car { Name = "Cami" };
            var c2 = new Car { Name = "Rush" };
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
        public string Name { get; init; }
    }

    struct Truck
    {
        public string Name { get; init; }
    }

}

