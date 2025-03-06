using MySql.Data.MySqlClient;
using System.Drawing.Text;

namespace ComputerMaster
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            const string database = "ISRPOlab5-computerMaster";

            const string connectionString = $"Server=localhost;Database={database};User=root;Password=;Port=3306";

            using(MySqlConnection connection = new MySqlConnection(connectionString)) 
            {
                try
                {
                    connection.Open();
                    ApplicationConfiguration.Initialize();
                    Application.Run(new MainForm(connection));
                }
                catch (Exception ex) 
                {
                    MessageBox.Show("Ошибка при подключении к БД! " + ex.Message);
                }
            }
            
            
        }
    }
}