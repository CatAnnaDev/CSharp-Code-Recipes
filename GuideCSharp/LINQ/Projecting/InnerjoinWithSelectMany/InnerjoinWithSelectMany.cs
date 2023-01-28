using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Projecting.InnerjoinWithSelectMany
{
    public class InnerjoinWithSelectMany
	{
        struct Team
        {
            public int Id;
            public string[] Names;
        }

        public InnerjoinWithSelectMany()
		{
            Team[] teams = {
                new Team {
                    Id = 1,
                    Names = new[] {"Tom", "Mark"} },
                new Team {
                    Id = 2,
                    Names = new[] {"Max", "Anna"}}
            };

            //first method
            var names1 = teams.SelectMany(team => team.Names,
                (team, name) =>
                new { team.Id, Name = name });
            //names1 is {{Id = 1, Name = "Tom"},
            //           {Id = 1, Name = "Mark"},
            //           {Id = 2, Name = "Max"},
            //           {Id = 2, Name = "Anna"}}

            //second method
            var names2 =
                from team in teams
                from name in team.Names
                select new
                {
                    team.Id,
                    Name = name
                };
            //names2 is {{Id = 1, Name = "Tom"},
            //           {Id = 1, Name = "Mark"},
            //           {Id = 2, Name = "Max"},
            //           {Id = 2, Name = "Anna"}} 

            Console.WriteLine(JsonSerializer.Serialize(names1));
            Console.WriteLine(JsonSerializer.Serialize(names2));
        }
	}
}

