using System;
using System.Text.Json;

namespace GuideCSharp.LINQ.Joining.JoinOperator
{
    record Dept(int Id, string Name);

    record Employee(int IdDept, string Name);

    public class JoinOperator
	{
        public JoinOperator()
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
            var data1 = depts.Join(employees,
                d => d.Id,
                e => e.IdDept,
                (d, e) => e.Name + " in " + d.Name);

            //second method
            var data2 =
                from d in depts
                join e in employees on
                    d.Id equals e.IdDept
                select e.Name + " in " + d.Name;
            //data1 and data2 is
            //  Max in Security
            //  Tom in IT
            //  Alex in IT

            Console.WriteLine(JsonSerializer.Serialize(data1));
            Console.WriteLine(JsonSerializer.Serialize(data2));
        }
	}
}

