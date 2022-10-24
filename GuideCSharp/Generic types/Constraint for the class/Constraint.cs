using System;
namespace GuideCSharp.Generictypes.Constraintfortheclass
{
	public class Constraint
	{
		public Constraint()
		{
            void Swap<T>(ref T a, ref T b) where T : class
            {
                var tmp = a;
                a = b;
                b = tmp;
            }

            var c1 = new Car { Name = "Cami" };
            var c2 = new Car { Name = "Rush" };
            Swap(ref c1, ref c2);
            Console.WriteLine($"{c1.Name}, {c2.Name}");

            var t1 = new Truck { Name = "Kamaz" };
            var t2 = new Truck { Name = "Ural" };
            //Swap(ref t1, ref t2);//<- Error
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

