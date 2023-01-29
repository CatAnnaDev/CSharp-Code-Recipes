using System;
using System.Data.SQLite;
namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToSQLite
{
	public class ConnectToSQLite
	{
		public ConnectToSQLite()
		{
            var conStr = "Data Source=/DatabasePath/DatabaseName.db;Version=3;";

            using (var conn = new SQLiteConnection(conStr))
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

