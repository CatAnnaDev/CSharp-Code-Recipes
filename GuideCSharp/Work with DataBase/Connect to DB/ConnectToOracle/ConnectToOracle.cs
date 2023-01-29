using System;
using System.Diagnostics;
using Oracle.DataAccess.Client;

namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToOracle
{
	public class ConnectToOracle
	{
		public ConnectToOracle()
        {


            var database = "Data Source=DataBaseName";
            var user = "User Id=UserName";
            var password = "Password=UserPassword";

            var conStr = string.Join(";", new[] {
    database, user, password });

            using (var conn = new OracleConnection(conStr))
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

