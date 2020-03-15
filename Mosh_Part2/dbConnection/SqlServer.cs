using System;
namespace Mosh_Part2.dbConnection
{
    public class SqlServer : IDB
    {
        // ALL MEMEBERS OF THE INTERFACE MUST BE DECLARED PUBLIC
        public string ConnectionString { get; set; }
        private TimeSpan TimeOut { get; set; }

        public SqlServer(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        public void OpenConnection()
        {
            Console.WriteLine("Opening SQL connection.");
        }

        public void CloseConnection()
        {
            Console.WriteLine("SQL connection closed.");
        }
    }
}
