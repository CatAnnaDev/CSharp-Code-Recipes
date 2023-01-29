using System;
using Npgsql;

namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToPostgreSQL
{
	public class ConnectToPostgreSQL
	{
		public ConnectToPostgreSQL()
		{
            var server = "Server=ServerName";
            var port = "Port=Port";
            var user = "User Id=UserName";
            var password = "Password=UserPassword";
            var database = "Database=DataBaseName";

            var conStr = string.Join(";", new[] {server, port, user, password, database });

            using (var conn = new NpgsqlConnection(conStr))
            {
                conn.Open();

                var command = conn.CreateCommand();
                command.CommandText = @"
                  SELECT
                    Language, Percentage
                  FROM countrylanguage
                  WHERE CountryCode = 'FR'
                  ORDER BY Percentage DESC";
                var reader = command.ExecuteReader();
                // Get the data
                if (!reader.Read())
                    return;

                Console.WriteLine(reader.GetString(0) + ": " +
                    reader.GetFloat(1));
            }
        }
	}
}

