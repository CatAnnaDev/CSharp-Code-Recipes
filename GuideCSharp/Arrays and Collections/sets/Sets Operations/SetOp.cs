using System;
using System.Text.Json;

namespace GuideCSharp.ArraysandCollections.sets.SetsOperations
{
	public class SetOp
	{
		public SetOp()
		{
            var first = new HashSet<int> { 1, 2, 3 };
            var second = new HashSet<int> { 3, 4, 5 };

            first.UnionWith(second);
            //first is { 1, 2, 3, 4, 5 }
            Console.WriteLine(JsonSerializer.Serialize(first));

            first.ExceptWith(second);
            //first is { 1, 2 }
            Console.WriteLine(JsonSerializer.Serialize(first));

            first.IntersectWith(second);
            //first is { 3 }
            Console.WriteLine(JsonSerializer.Serialize(first));

            first.SymmetricExceptWith(second);
            //first is { 1, 2, 4, 5 }
            Console.WriteLine(JsonSerializer.Serialize(first));
        }
	}
}

