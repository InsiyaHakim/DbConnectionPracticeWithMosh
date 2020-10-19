using System;
namespace DbConnectionPractice
{
	public class OracleConnection : DbConnection
	{
		public OracleConnection(string connection) : base(connection)
		{

		}

		public override void CloseConnection()
		{
			Console.WriteLine();		
		}

		public override void OpenConnection()
		{
			Console.WriteLine();
		}
	}
}
