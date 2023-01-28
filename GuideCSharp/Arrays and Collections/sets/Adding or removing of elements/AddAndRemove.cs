using System;
using System.Text.Json;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.sets.Addingorremovingofelements
{
	public class AddAndRemove
	{
		public AddAndRemove()
		{
            var set = new HashSet<Char> { 'A', 'B', 'C' };
            set.Add('D');
            //set is { 'A', 'B', 'C', 'D' }
            Console.WriteLine(JsonSerializer.Serialize(set));

            set.Remove('A');
            //set is { 'B', 'C', 'D' }
            Console.WriteLine(JsonSerializer.Serialize(set));

            set.Clear();
            //set is { }
        }
    }
}

