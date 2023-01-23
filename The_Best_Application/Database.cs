using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace The_Best_Application
{
    public class Database
    {
        private readonly string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }

        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login TEXT, "
                    + "password TEXT, "
                    + "role TEXT);";
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }

        public bool createUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                SQLiteCommand cmd = conn.CreateCommand();
                cmd.CommandText = string.Format("INSERT INTO users (login, password)"
                + "VALUES ('{0}', '{1}')",
                username, password);
                cmd.ExecuteNonQuery();
                return true;
            }
            return true;
        }


        public bool ValidUser(string username, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(*) "
                    + "FROM users "
                    + "where login = '{0}' AND "
                    + "password = '{1}'",
                   username, password);

                    var a = cmd.ExecuteScalar();

                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }

        public bool ValidUser_1(string username)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    cmd.CommandText = string.Format("SELECT COUNT(*) "
                    + "FROM users "
                    + "where login = '{0}'",
                   username);

                    var a = cmd.ExecuteScalar();

                    var usersCount = Convert.ToInt32(cmd.ExecuteScalar());
                    return usersCount > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }
    }
}
