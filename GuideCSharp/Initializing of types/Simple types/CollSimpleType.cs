using System;
namespace GuideCSharp.Initializingoftypes.Simpletypes
{
	public class CollSimpleType
	{
		public CollSimpleType()
		{
            //"const" + type name for constants and
            //"var" or type name for variables

            //Int
            int number = 42, otherNumber = 37;
            const ulong maxInt64 = ulong.MaxValue;
            const int Mb = 1_048_576;

            //Double
            const double exp = 2.71828;
            double billion = 1E+9;

            //Float
            const float pi = 3.14f;

            //String
            const string greeting = "Hello";

            //Multiline String
            var text = @"this is some
            multiline text";

            //Bool
            const bool sunIsStar = true;
            var earthIsStar = false;

            //Character "A"
            const char charA = 'A'; //'\x0041'; (char)65; '\u0041'

            //Tuple (Int, String)
            var one = (1, "one");

            Console.WriteLine($"number = {number}");
            Console.WriteLine($"otherNumber = {otherNumber}");
            Console.WriteLine($"maxInt64 = {maxInt64}");
            Console.WriteLine($"Mb = {Mb}");
            Console.WriteLine($"exp = {exp}");
            Console.WriteLine($"billion = {billion}");
            Console.WriteLine($"pi = {pi}");
            Console.WriteLine($"greeting = {greeting}");
            Console.WriteLine($"text = {text}");
            Console.WriteLine($"sunIsStar = {sunIsStar}");
            Console.WriteLine($"earthIsStar = {earthIsStar}");
            Console.WriteLine($"charA = {charA}");
            Console.WriteLine($"one = {one}");
        }
	}
}

