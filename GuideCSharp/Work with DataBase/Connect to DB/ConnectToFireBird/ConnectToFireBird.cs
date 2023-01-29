using System;
using System.Data.Common;
using FirebirdSql.Data.FirebirdClient;

namespace GuideCSharp.WorkwithDataBase.ConnecttoDB.ConnectToFireBird
{
	public class ConnectToFireBird
	{
		public ConnectToFireBird()
		{

            var conStr = new FbConnectionStringBuilder();
            conStr.Charset = "WIN1251";
            conStr.UserID = "SYSDBA";
            conStr.Password = "masterkey";
            conStr.Database = @"C:\Users\User\Desktop\TESTS.FDB";
            conStr.ServerType = 0;

            using (var conn = new FbConnection(conStr.ToString()))
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

