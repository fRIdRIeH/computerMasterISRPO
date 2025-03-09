using ComputerMaster.Models;
using Microsoft.VisualBasic.Devices;
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

        public bool Add(Models.Computer computer) 
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

        public bool Update(Models.Computer computer)
        {
            string updateQuery = "UPDATE Computer SET Model = @Model, Processor = @Processor, Ram = @Ram, Hdd = @Hdd, Price = @Price, Amount = @Amount, " +
                "Description = @Description WHERE Id = @Id;";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Model", computer.Model);
                cmd.Parameters.AddWithValue("@Processor", computer.Processor);
                cmd.Parameters.AddWithValue("@Ram", computer.Ram);
                cmd.Parameters.AddWithValue("@Hdd", computer.Hdd);
                cmd.Parameters.AddWithValue("@Price", computer.Price);
                cmd.Parameters.AddWithValue("@Amount", computer.Amount);
                cmd.Parameters.AddWithValue("@Description", computer.Description);
                cmd.Parameters.AddWithValue("@Id", computer.Id);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if(rowsUpdated > 0) return true;
                return false;
            }
        }

        public Models.Computer? Get(int id)
        {
            string selectQuery = "SELECT * FROM Computer WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Models.Computer computer = new Models.Computer() 
                        {
                            Id = reader.GetInt32("Id"),
                            Model = reader.GetString("Model"),
                            Processor = reader.GetString("Processor"),
                            Ram = reader.GetString("Ram"),
                            Hdd = reader.GetString("Hdd"),
                            Price = reader.GetDecimal("Price"),
                            Amount = reader.GetInt32("Amount"),
                            Description = reader.GetString("Description"),
                        };
                        return computer;
                    }
                }
            }
            return null;
        }

        public List<Models.Computer> GetAll() 
        {
            string selectQuery = "SELECT * FROM Computer";
            List<Models.Computer> computers = new List<Models.Computer>();

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Models.Computer computer = new Models.Computer()
                        {
                            Id = reader.GetInt32("Id"),
                            Model = reader.GetString("Model"),
                            Processor = reader.GetString("Processor"),
                            Ram = reader.GetString("Ram"),
                            Hdd = reader.GetString("Hdd"),
                            Price = reader.GetDecimal("Price"),
                            Amount = reader.GetInt32("Amount"),
                            Description = reader.GetString("Description"),
                        };
                        computers.Add(computer);
                    }
                }
                return computers;
            }
        }
    }
}
