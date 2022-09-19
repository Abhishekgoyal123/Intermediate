using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5_2
{
    public class DbCommand
    {
        public DbConnection _dbConnection;
        public string _instruction;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            this._dbConnection = dbConnection;
            this._instruction = instruction;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine($"instruction = {_instruction}");
            _dbConnection.StopConnection();
        }

    }
}
