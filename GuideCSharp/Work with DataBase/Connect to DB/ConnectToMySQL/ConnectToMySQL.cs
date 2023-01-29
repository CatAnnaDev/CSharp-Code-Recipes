using System;
namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToMySQL
{
	public class ConnectToMySQL
	{
		public ConnectToMySQL()
		{
            var host = "HostName";
            var port = 3306;
            var dataBase = "DatabaseName";
            var userName = "UserName";
            var password = "Password";

            var connString =
                $"Server={host};Database={dataBase};port={port}" +
                $";User Id={userName};password={password}";

            var conn = new MySqlConnection(connString);
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

            Console.WriteLine(reader.GetString(0) + ": " + reader.GetFloat("Percentage"));
        }
	}
}

