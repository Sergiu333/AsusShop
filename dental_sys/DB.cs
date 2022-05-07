using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace dental_sys
{
    public class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost ; port=3306; username=root; password=Mama4ika12345; database=Asus_Store;");
        
        public void Open() {
            if (connection.State == System.Data.ConnectionState.Closed)
            {   
                connection.Open();
            }
        }

        public void Close() {
            if (connection.State == System.Data.ConnectionState.Open)
            {   
                connection.Close();
            }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        /*
        public string getData()
        {

            string output;
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }

            output = connection.Qu
            return output;
        }
*/
    }
}