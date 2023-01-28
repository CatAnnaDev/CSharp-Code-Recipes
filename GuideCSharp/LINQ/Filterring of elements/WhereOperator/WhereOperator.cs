using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Filterringofelements.WhereOperator
{
	public class WhereOperator
	{
		public WhereOperator()
		{
            //first method
            string[] names = { "Anna", "Pavel", "Ivan" };
            var shortNames = names.Where(s => s.Length < 5);
            //shortNames is {"Anna", "Ivan"}

            //second method
            var vNames = from name in names where name.Contains("v") select name;
            //vNames is {"Pavel", "Ivan"}

            Console.WriteLine(JsonSerializer.Serialize(shortNames));
            Console.WriteLine(JsonSerializer.Serialize(vNames));
        }
	}
}

