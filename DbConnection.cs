using System;
using System.Reflection;

namespace DbConnectionPractice
{
	public abstract class DbConnection
	{
		private readonly string ConnectionString;

		private readonly TimeSpan Timespan;

		protected DbConnection(string connection)
		{
			if (string.IsNullOrEmpty(connection))
				new InvalidOperationException("Connection String is empty");

			ConnectionString = connection;
		}

		public abstract void OpenConnection();
		public abstract void CloseConnection();
	}

}
