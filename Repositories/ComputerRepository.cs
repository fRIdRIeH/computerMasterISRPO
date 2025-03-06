using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerMaster.Repositories
{
    public class ComputerRepository
    {
        private readonly MySqlConnection _connection;

        public ComputerRepository(MySqlConnection connection)
        {
            _connection = connection;
        }
    }
}
