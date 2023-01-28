using System;
using System.Text.Json;
using System.Linq;

namespace GuideCSharp.LINQ.Joining.OuterJoinWithGroupJoin
{
    record Dept(int Id, string Name);

    record Employee(int IdDept, string Name);

    public class OuterJoinWithGroupJoin
	{
		public OuterJoinWithGroupJoin()
		{
            var depts = new[] {
                new Dept(1, "Security"),
                new Dept(2, "IT")
            };

            var employees = new[] {
                new Employee(2, "Tom"),
                new Employee(2, "Alex")
            };

            var data =
                from d in depts
                join e in employees on
                    d.Id equals e.IdDept
                into deptEmployees
                from de in deptEmployees.DefaultIfEmpty()
                select (de != null ? de.Name : "no one") +
                    " in " + d.Name;
            //data is
            //  no one in Security
            //  Tom in IT
            //  Alex in IT

            Console.WriteLine(JsonSerializer.Serialize(data));
        }
	}
}

