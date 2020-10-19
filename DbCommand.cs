using System;

namespace DbConnectionPractice
{
	public class DbCommand
	{
		private readonly DbConnection connection;

		private readonly string _instruction;
		public DbCommand(DbConnection dbConnection, string instruction)
		{
			if(dbConnection == null)
				throw new ArgumentException("DbConnection cannot be null.");
			
			if(string.IsNullOrEmpty(instruction))
				throw new ArgumentException("Instruction cannot be null.");

			connection = dbConnection;
			_instruction = instruction;
		}

		public void Execute()
		{
			connection.OpenConnection();
			Console.WriteLine($"Instruction in {_instruction}");
			connection.CloseConnection();
		}
	}
}
