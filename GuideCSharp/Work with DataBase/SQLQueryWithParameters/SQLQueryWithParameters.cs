using System;
using System.Data;

namespace GuideCSharp.WorkwithDataBase.SQLQueryWithParameters
{
	public class SQLQueryWithParameters
	{
		public SQLQueryWithParameters()
		{
            var command = conn.CreateCommand();
            command.CommandText = @"
              SELECT
                Language, Percentage
              FROM countrylanguage
              WHERE 
                CountryCode = @Code AND
                Percentage > @Percent";
            command.Parameters.Add("@Code", MySqlDbType.VarChar).Value = "RUS";
            command.Parameters.Add("@Percent", MySqlDbType.Float).Value = 1;
            var reader = command.ExecuteReader();

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

