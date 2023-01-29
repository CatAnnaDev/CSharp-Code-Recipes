using System;
using System.Data.SqlClient;

namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToSQLServer
{
	public class ConnectToSQLServer
	{
		public ConnectToSQLServer()
		{
            var server = "Data Source=ServerName";
            var database = "Initial Catalog=DataBaseName";
            var user = "User id=UserName";
            var password = "Password=UserPassword";

            var conStr = string.Join(";", new[] {
    server, database, user, password });

            using (var conn = new SqlConnection(conStr))
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

                Console.WriteLine(reader.GetString(0) + ": " + reader.GetFloat(1));
            }
        }
	}
}

