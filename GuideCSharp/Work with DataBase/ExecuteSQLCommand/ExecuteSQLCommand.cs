using System;
using System.Data;

namespace GuideCSharp.WorkwithDataBase.ExecuteSQLCommand
{
	public class ExecuteSQLCommand
	{
		public ExecuteSQLCommand()
		{
            // Connect to the database
            // ...

            var command = conn.CreateCommand();
            command.CommandText = @"DELETE FROM city WHERE CountryCode = @Id";
            command.Parameters.Add("@Id", MySqlDbType.VarChar).Value = "-1";
            var reader = command.ExecuteNonQuery();

            // Close the connection
            conn.Close();
        }
	}
}

