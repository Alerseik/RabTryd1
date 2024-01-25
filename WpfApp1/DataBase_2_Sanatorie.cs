using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Controls;

namespace WpfApp1
{
    class DataBase_2_Sanatorie
    {
        MySqlConnectionStringBuilder connectionstring;
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=0303;database=new_pabota");
        public DataBase_2_Sanatorie()
        {
            connectionstring = new MySqlConnectionStringBuilder();
            connectionstring.Server = "localhost";
            connectionstring.UserID = "root";
            connectionstring.Password = "0303";
            connectionstring.Database = "new_pabota";
        }

        public object Products { get; internal set; }

        public int AddUser(int idd, string name)
        {
            var check = -1;
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();
            string cndText = "INSERT INTO new_pabota.students(id, name)" +
                $"VALUES ('{idd}','{name}');";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);
            check = cmd.ExecuteNonQuery();

            connection.Close();
            return check;
        }
        public void ChangeUser(string name, int id)
        {
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();

            string cndText = $"UPDATE new_pabota.students SET `name` = '{name}' WHERE `id` = '{id}';";

            MySqlCommand cmd = new MySqlCommand(cndText, connection);

            cmd.ExecuteNonQuery();
            connection.Close();
        }
        public void RemoveDataBese(int id)
        {

            using (MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=Adad4320033002;database=new_compani_pk"))
            {
                string sql = "DELETE FROM new_pabota.students WHERE (`id` =@id)";
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(sql, connection);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
        }
        public void closeConnecrion()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection getConnection()
        {
            return connection;
        }
        public DataTable GetTable()
        {
            MySqlConnection connection = new MySqlConnection(connectionstring.ConnectionString);
            connection.Open();

            MySqlDataAdapter sqlDa = new MySqlDataAdapter("select * from new_pabota.students", connection);
            DataTable dt = new DataTable();
            sqlDa.Fill(dt);
            return dt;

        }
    }
}
