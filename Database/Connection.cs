using System;
using System.Data.SqlClient;

namespace Database
{
    public class Connection
    {
        public SqlConnection database;

        private string
            SQLConnection =
                "Server=.; Initial Catalog= instaissue; Integrated Security=SSPI"; // Server=localhost\\SQLEXPRESS;Initial Catalog=instaissue;Integrated Security=False;";

        public void Connect()
        {
            try
            {
                database = new SqlConnection(SQLConnection); // To call this database connection: Connection.database.Open(); 
            }
            catch (Exception e)
            {
                //Console.WriteLine(e);
                throw;
            }
            
        }

        public SqlConnection GetSqlConnection()
        {
            database = new SqlConnection(SQLConnection);
            return database;
        }

        public SqlCommand RunCommand(string command)
        {
            SqlCommand cmd = new SqlCommand(command, database);
            return cmd;
        } 
    }
}
