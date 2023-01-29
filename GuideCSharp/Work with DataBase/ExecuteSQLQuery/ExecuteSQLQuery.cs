using System;
namespace GuideCSharp.WorkwithDataBase.ExecuteSQLQuery
{
	public class ExecuteSQLQuery
	{
		public ExecuteSQLQuery()
		{
            // Connect to the database
            // ... 

            var command = conn.CreateCommand();
            command.CommandText = @"
              SELECT
                Language, Percentage
              FROM countrylanguage
              WHERE CountryCode = 'RUS'
              ORDER BY Percentage DESC";
            var reader = command.ExecuteReader();

            // Get the data
            if (!reader.Read())
                return;

            Console.WriteLine(reader.GetString(0) + ": " + reader.GetFloat("Percentage"));

            // Get all rows
            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + ": " + reader.GetFloat("Percentage"));
            }

            // Close the connection
            conn.Close();
        }
	}
}

