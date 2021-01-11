using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public class DB
    {
        MySqlConnection connection = new MySqlConnection("" +
            "server=localhost;port=3306;username=root;password=root;database=3oproject");

        public int openConnection()
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                    connection.Open();
                return 1;
            }
            catch
            {
                return 0;
            }

        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();

        }
        public MySqlConnection getConnection()
        {
            return connection;
        }





    }
}
