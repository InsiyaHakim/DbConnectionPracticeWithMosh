using System;

namespace DbConnectionPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			var dbCommand = new DbCommand(new SqlConnection("connecting"), "This is sql");
			dbCommand.Execute();
		}
	}
}
