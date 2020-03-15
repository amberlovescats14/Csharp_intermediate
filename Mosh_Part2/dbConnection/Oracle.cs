using System;
namespace Mosh_Part2.dbConnection
{
    public class Oracle : IDB
    {
        public string ConnectionString { get; set; }
        private TimeSpan timeSpan;

        public Oracle(string connectionString)
        {
            if(connectionString == null)
                throw new ArgumentException("Connection string cannot be null.");
            else this.ConnectionString = connectionString;
        }

        public void OpenConnection() =>
            Console.WriteLine("Open connection");

        public void CloseConnection() =>
            Console.WriteLine("Close connection.");

    }
}
