using ComputerMaster.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace ComputerMaster.Repositories
{
    public class ClientRepository
    {
        private readonly MySqlConnection _connection;

        public ClientRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Client client) 
        {
            string insertString = "INSERT INTO Client " +
                "(Surname, Name, Patronimyc, Email, Telephone, Address) " +
                "VALUES " +
                "(@Surname, @Name, @Patronimyc, @Email, @Telephone, @Address)";

            using(MySqlCommand cmd = new MySqlCommand(insertString, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Patronimyc", client.Patronimyc);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Telephone", client.Telephone);
                cmd.Parameters.AddWithValue("@Address", client.Address);

                int rowInserted = cmd.ExecuteNonQuery();
                if (rowInserted > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id)
        {
            string deleteQuery = "DELETE Client WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int rowsInserted = cmd.ExecuteNonQuery();
                if(rowsInserted > 0) 
                    return true;
                return false;
            }
        }

        public bool Update(Client client)
        {
            string updateQuery = "UPDATE Client SET Surname = @Surname, Name = @Name, Patronimyc = @Patronimyc, Email = @Email, Telephone = @Telephone, Address = @Address WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(updateQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Surname", client.Surname);
                cmd.Parameters.AddWithValue("@Name", client.Name);
                cmd.Parameters.AddWithValue("@Patronimyc", client.Patronimyc);
                cmd.Parameters.AddWithValue("@Email", client.Email);
                cmd.Parameters.AddWithValue("@Telephone", client.Telephone);
                cmd.Parameters.AddWithValue("@Address", client.Address);
                cmd.Parameters.AddWithValue("@Id", client.Id);

                int rowsUpdated = cmd.ExecuteNonQuery();
                if( rowsUpdated > 0)
                    return true;
                return false;
            }
        }

        public Client? Get(int id)
        {
            string selectString = "SELECT * FROM Client WHERE Id = @Id";

            using(MySqlCommand cmd = new MySqlCommand(selectString, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Client client = new Client 
                        {
                            Id = reader.GetInt32("Id"),
                            Surname = reader.GetString("Surname"),
                            Name = reader.GetString("Name"),
                            Patronimyc = reader.GetString("Patronimyc"),
                            Email = reader.GetString("Email"),
                            Telephone = reader.GetString("Telephone"),
                            Address = reader.GetString("Address")
                        };
                        return client;
                    }
                }
            }
            return null;
        }

        public List<Client> GetAll() 
        {
            List<Client> clients = new List<Client>();
            string selectString = "SELECT * FROM Client";

            using( MySqlCommand cmd = new MySqlCommand( selectString, _connection)) 
            using(MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read()) 
                {
                    Client client = new Client
                    {
                        Id = reader.GetInt32("Id"),
                        Surname = reader.GetString("Surname"),
                        Name = reader.GetString("Name"),
                        Patronimyc = reader.GetString("Patronimyc"),
                        Email = reader.GetString("Email"),
                        Telephone = reader.GetString("Telephone"),
                        Address = reader.GetString("Address")
                    };
                    clients.Add(client);
                }
            }
            return clients;
        }
    }
}
