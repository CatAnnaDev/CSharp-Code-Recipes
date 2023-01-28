using System;
using System.Text.Json;
using System.Linq;
using System.IO;

namespace GuideCSharp.LINQ.Grouping.GroupbyOperator
{
	public class GroupbyOperator
	{
		public GroupbyOperator()
		{
            //get the list of file paths
            var files = Directory.GetFiles(@"C:\tmp\");

            //group by extension and get file names
            //first method
            var query1 = files.GroupBy(Path.GetExtension, Path.GetFileName);

            //second method
            var query2 = files.GroupBy(file => Path.GetExtension(file), file => Path.GetFileName(file));

            //third method
            var query3 =from file in files group Path.GetFileName(file) by Path.GetExtension(file);

            Console.WriteLine(JsonSerializer.Serialize(query1));
            Console.WriteLine(JsonSerializer.Serialize(query2));

            //output to console
            foreach (var group in query3)
            {
                Console.WriteLine("Extension: " + group.Key);
                foreach (var file in group)
                {
                    Console.WriteLine("  - " + file);
                }
            }

            //output is:
            //Extension: .xml
            //  - data.xml
            //  - file.xml
            //Extension: .txt
            //  - samples.txt
        }
    }
}

