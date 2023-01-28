using System;
using System.Text.Json;
using System.Collections.Generic;

namespace GuideCSharp.ArraysandCollections.Dictionary.Addingandremovingofelements
{
	public class AddAndRemove
	{
		public AddAndRemove()
		{
            var dic = new Dictionary<int, string>
            {
                [1] = "one",
                [2] = "two",
                [3] = "tree",
            };
            //dic is {{1, "one"}, {2, "two"}, {3, "tree"}}
            Console.WriteLine(JsonSerializer.Serialize(dic));

            dic[3] = "three";
            //dic is {{1, "one"}, {2, "two"}, {3, "three"}}
            Console.WriteLine(JsonSerializer.Serialize(dic));

            dic.Remove(3);
            //dic is {{1, "one"}, {2, "two"}}
            Console.WriteLine(JsonSerializer.Serialize(dic));

            dic.Clear();
            //dic is empty

        }
    }
}

