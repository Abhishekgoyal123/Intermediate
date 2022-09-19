using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    public abstract class DbConnection
    {
        public string ConnectionString;
        public TimeSpan Timeout;

        public DbConnection(string connectionString)
        {
            this.ConnectionString = connectionString;
            
        }

        public abstract void OpenConnection();

        public abstract void StopConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base( connectionString)
        {
            //this.ConnectionString = connectionString;
        }
        public override void OpenConnection()
        {
            Console.WriteLine("SQL Connection Started");
        }

        public override void StopConnection()
        {
            Console.WriteLine("SQL Connection Stopped");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            //this.ConnectionString = connectionString;
        }
        public override void OpenConnection()
        {
            Console.WriteLine("Oracle Connection Started");
        }

        public override void StopConnection()
        {
            Console.WriteLine("Oracle Connection Stopped");
        }
    }

}
