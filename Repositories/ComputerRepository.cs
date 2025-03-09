using ComputerMaster.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public bool Add(Computer computer) 
        {
            string insertQuery = "INSERT INTO Computer " +
                "(Model, Processor, Ram, Hdd, Price, Amount, Description) " +
                "VALUES " +
                "(@Model, @Processor, @Ram, @Hdd, @Price, @Amount, @Description)";

            using(MySqlCommand cmd = new MySqlCommand(insertQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Model", computer.Model);
                cmd.Parameters.AddWithValue("@Processor", computer.Processor);
                cmd.Parameters.AddWithValue("@Ram", computer.Ram);
                cmd.Parameters.AddWithValue("@Hdd", computer.Hdd);
                cmd.Parameters.AddWithValue("@Price", computer.Price);
                cmd.Parameters.AddWithValue("@Amount", computer.Amount);
                cmd.Parameters.AddWithValue("@Description", computer.Description);

                int rowsInserted = cmd.ExecuteNonQuery();
                if (rowsInserted > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id) 
        {
            string deleteQuery = "DELETE FROM Computer WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsDeleted = cmd.ExecuteNonQuery();
                if(rowsDeleted > 0) 
                    return true;
                return false;
            }
        }

        public bool Update(Computer computer)
        {
            string updateQuery = "UPDATE Computer SET" +
                "Model = @Model, " +
                "Processor = @Processor, " +
                "Ram = @Ram, " +
                "Hdd = @Hdd, " +
                "Price = @Price, " +
                "Amount = @Amount, " +
                "Description = @Description " +
                "WHERE @Id = Id";


        }
    }
}
