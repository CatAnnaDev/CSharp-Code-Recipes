using System;
using System.Data.OleDb;
namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToAccess
{
	public class ConnectToAccess
	{
		public ConnectToAccess()
		{
            
            var conStr = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=databaseName.mdb";

            var conn = new OleDbConnection(conStr);
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

            conn.Close();
        }
	}
}

