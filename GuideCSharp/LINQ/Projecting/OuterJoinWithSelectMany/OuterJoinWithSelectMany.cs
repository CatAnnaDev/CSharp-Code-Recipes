using System;
using GuideCSharp.LINQ.Projecting.InnerjoinWithSelectMany;
using System.Text.Json;

namespace GuideCSharp.LINQ.Projecting.OuterJoinWithSelectMany
{
	public class OuterJoinWithSelectMany
	{
        struct Team
        {
            public int Id;
            public string[] Names;
        }

        public OuterJoinWithSelectMany()
		{
            Team[] teams = {
                new() {
                    Id = 1,
                    Names = new[] {"Tom", "Mark"} },
                new() {
                    Id = 2,
                    Names = new string[] {} }
            };

            var names =
            from team in teams
            from name in team.Names.DefaultIfEmpty()
            select new
            {
                team.Id,
                Name = name ?? "no one"
            };
            //names is {{Id = 1, Name = "Tom"},
            //          {Id = 1, Name = "Mark"},
            //          {Id = 2, Name = "no one"}}

            Console.WriteLine(JsonSerializer.Serialize(names));
        }
	}
}

