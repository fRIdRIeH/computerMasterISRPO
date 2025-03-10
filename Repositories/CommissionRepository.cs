using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerMaster.Models;

namespace ComputerMaster.Repositories
{
    public class CommissionRepository
    {
        private readonly MySqlConnection _connection;

        public CommissionRepository(MySqlConnection connection)
        {
            _connection = connection;
        }

        public bool Add(Commission commission)
        {
            string insertString = "INSERT INTO Commission " +
                "(Computer_Id, Commission_Date, Commission_Price, Client_Id, Status, Note) " +
                "VALUES " +
                "(@Computer_Id, @Commission_Date, @Commission_Price, @Client_Id, @Status, @Note)";

            using (MySqlCommand cmd = new MySqlCommand(insertString, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Computer_Id", commission.ComputerId);
                cmd.Parameters.AddWithValue("@Commission_Date", commission.CommissionDate);
                cmd.Parameters.AddWithValue("@Commission_Price", commission.CommissionPrice);
                cmd.Parameters.AddWithValue("@Client_Id", commission.ClientId);
                cmd.Parameters.AddWithValue("@Status", commission.Status);
                cmd.Parameters.AddWithValue("@Note", commission.Note);

                int insertedRow = cmd.ExecuteNonQuery();
                if (insertedRow > 0)
                    return true;
                return false;
            }
        }

        public bool Delete(int id) 
        {
            string deleteQuery = "DELETE FROM Commission WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(deleteQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Id", id);

                int deletedRow = cmd.ExecuteNonQuery();
                if(deletedRow > 0) 
                    return true;
                return false;
            }
        }

        public bool Update(Commission commission)
        {
            string updateQuery = "UPDATE Commission SET Commission_Date = @Commission_Date, " +
                "Commission_Price = @Commission_Price, Status = @Status, Note = @Note WHERE Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(updateQuery, _connection))
            {
                cmd.Parameters.AddWithValue("@Id", commission.Id);
                cmd.Parameters.AddWithValue("@Commission_Date", commission.CommissionDate);
                cmd.Parameters.AddWithValue("@Commission_Price", commission.CommissionPrice);
                cmd.Parameters.AddWithValue("@Status", commission.Status);
                cmd.Parameters.AddWithValue("@Note", commission.Note);

                int updateRow = cmd.ExecuteNonQuery();
                if(updateRow > 0) 
                    return true;
                return false;
            }
        }

        public Commission? Get(int id) 
        {
            string selectQuery = "SELECT " +
                "cm.Id AS Идентификатор_Заказа, " +
                "c.Id AS Идентификатор_Компьютера, " +
                "c.Model AS Модель_Компьютера, " +
                "cm.Commission_Date AS Дата_Заказа, " +
                "cm.Commission_Price AS Цена_Заказа, " +
                "cl.Id AS Идентификатор_Клиента, " +
                "cl.Name AS Имя_Клиента, " +
                "cl.Address AS Адрес_Клиента, " +
                "cl.Telephone AS Телефон_Клиента, " +
                "cm.Status AS Статус, " +
                "cm.Note AS Примечание " +
                "FROM Commission cm " +
                "JOIN Computer c ON cm.Computer_Id = c.Id " +
                "JOIN Client cl ON cm.Client_Id = cl.Id " +
                "WHERE cm.Id = @Id";

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection)) 
            {
                cmd.Parameters.AddWithValue("@Id", id);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Commission commission = new Commission
                        {
                            Id = reader.GetInt32("Идентификатор_Заказа"),
                            ComputerId = reader.GetInt32("Идентификатор_Компьютера"),
                            ComputerModel = reader.GetString("Модель_Компьютера"),
                            CommissionDate = reader.GetDateTime("Дата_Заказа"),
                            CommissionPrice = reader.GetDecimal("Цена_Заказа"),
                            ClientId = reader.GetInt32("Идентификатор_Клиента"),
                            ClientName = reader.GetString("Имя_Клиента"),
                            ClientAddress = reader.GetString("Адрес_Клиента"),
                            ClientTelephone = reader.GetString("Телефон_Клиента"),
                            Status = reader.GetString("Статус"),
                            Note = reader.GetString("Примечание"),
                        };
                        return commission;
                    }
                }
            }
            return null;
        }

        public List<Commission> GetAll() 
        {
            string selectQuery = "SELECT " +
                "cm.Id AS Идентификатор_Заказа, " +
                "c.Id AS Идентификатор_Компьютера, " +
                "c.Model AS Модель_Компьютера, " +
                "cm.Commission_Date AS Дата_Заказа, " +
                "cm.Commission_Price AS Цена_Заказа, " +
                "cl.Id AS Идентификатор_Клиента, " +
                "cl.Name AS Имя_Клиента, " +
                "cl.Address AS Адрес_Клиента, " +
                "cl.Telephone AS Телефон_Клиента, " +
                "cm.Status AS Статус, " +
                "cm.Note AS Примечание " +
                "FROM Commission cm " +
                "JOIN Computer c ON cm.Computer_Id = c.Id " +
                "JOIN Client cl ON cm.Client_Id = cl.Id";

            List<Commission> commissions = new List<Commission>();

            using (MySqlCommand cmd = new MySqlCommand(selectQuery, _connection)) 
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Commission commission = new Commission
                        {
                            Id = reader.GetInt32("Идентификатор_Заказа"),
                            ComputerId = reader.GetInt32("Идентификатор_Компьютера"),
                            ComputerModel = reader.GetString("Модель_Компьютера"),
                            CommissionDate = reader.GetDateTime("Дата_Заказа"),
                            CommissionPrice = reader.GetDecimal("Цена_Заказа"),
                            ClientId = reader.GetInt32("Идентификатор_Клиента"),
                            ClientName = reader.GetString("Имя_Клиента"),
                            ClientAddress = reader.GetString("Адрес_Клиента"),
                            ClientTelephone = reader.GetString("Телефон_Клиента"),
                            Status = reader.GetString("Статус"),
                            Note = reader.GetString("Примечание"),
                        };
                        commissions.Add(commission);
                    }
                }
                return commissions;
            }
        }
    }
}
