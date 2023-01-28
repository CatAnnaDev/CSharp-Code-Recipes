using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Projecting.SelectManyOperator
{
	public class SelectManyOperator
	{
		public SelectManyOperator()
		{
            string[][] teams = {
                new[] {"Alex", "Mark"},
                new[] {"Max", "Tom", "Ania"}
            };

            //first method
            var names1 = teams
                .SelectMany(team => team)
                .Where(name => name.Contains("M"))
                .Select(name => new {
                    Name = name,
                    name.Length
                });
            //names1 is {{Name = "Mark", Length = 4},
            //          {Name = "Max", Length = 3}}

            Console.WriteLine(JsonSerializer.Serialize(names1));

            //second method
            var names2 =
            from team in teams
            from name in team
            where name.Contains("M")
            select new
            {
                Name = name,
                name.Length
            };
            //names2 is {{Name = Mark", Length = 4},
            //          {Name = "Max", Length = 3}}  

            Console.WriteLine(JsonSerializer.Serialize(names2));
        }
	}
}

