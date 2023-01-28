using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Joining.GroupJoinOperator
{
    record Dept(int Id, string Name);

    record Employee(int IdDept, string Name);

    public class GroupJoinOperator
	{
        public GroupJoinOperator()
		{
            var depts = new[] {
                new Dept(1, "Security"),
                new Dept(2, "IT")
            };

            var employees = new[] {
                new Employee(1, "Max"),
                new Employee(2, "Tom"),
                new Employee(2, "Alex")
            };

            //first method
            var data1 = depts.GroupJoin(employees,
                d => d.Id,
                e => e.IdDept,
                (d, e) => new { d.Name, Employees = e });

            //second method
            var data2 =
                from d in depts
                join e in employees on
                    d.Id equals e.IdDept
                into deptEmployees
                select new { d.Name, Employees = deptEmployees };

            Console.WriteLine(JsonSerializer.Serialize(data1));
            Console.WriteLine(JsonSerializer.Serialize(data2));

            //printed:
            //Security:
            //  Max
            //IT:
            //  Tom
            //  Alex
        }
    }
}

