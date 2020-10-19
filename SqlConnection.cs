using System;
namespace DbConnectionPractice
{
	public class SqlConnection : DbConnection
	{
		public SqlConnection(string connection) : base(connection)
		{

		}

		public override void CloseConnection()
		{
			Console.WriteLine("sql Connection Closed");
		}

		public override void OpenConnection()
		{
			Console.WriteLine("sqlConnection Opened");
		}
	}
}
