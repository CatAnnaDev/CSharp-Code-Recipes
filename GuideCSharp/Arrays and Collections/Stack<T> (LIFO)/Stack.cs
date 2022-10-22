using System;
namespace GuideCSharp.ArraysandCollections.StackTLIFO
{
	public class Stack
	{
		public Stack()
		{
            var intStack = new Stack<int>();
            intStack.Push(1);
            intStack.Push(3);
            intStack.Push(5);

            var top = intStack.Peek();
            //top is 5
            var first = intStack.Pop();
            //first is 5
            var second = intStack.Pop();
            //second is 3
            var third = intStack.Pop();
            //third is 1

            Console.WriteLine("{0}, {1}, {2}, {3}", top, first, second, third);
        }
	}
}

