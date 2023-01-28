using System;
namespace GuideCSharp.StructuresRecords.Subscriptindexermethods
{
    struct Alphabet
    {
        //without range check
        public char this[int i] => Convert.ToChar(64 + i);
    }

    public class SubscriptIndexerMethods
	{
		public SubscriptIndexerMethods()
		{
            Alphabet alphabet;
            var charA = alphabet[1];
            //charA is "A"

            var charE = alphabet[5];
            //charE is "E"

            Console.WriteLine("{0}, {1}", charA, charE);
        }
	}
}

