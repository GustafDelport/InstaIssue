using System;
using System.Data;
using System.Data.SqlClient;
using Database;

namespace Authentication
{
    public class Login
    {
        private readonly Connection connection = new Connection();

        public Login()
        {
        //test
        }

        public Boolean LoginUser(String username, String password)
        {
            Boolean flag = true;

            try
            {
                String Q = "SELECT * FROM tblusers WHERE username=@username AND password=@password";
                SqlConnection con = connection.GetSqlConnection();
                con.Open();

                using (SqlCommand cmd = new SqlCommand(Q, con))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        flag = true;
                    }
                    else flag = false;
                }
                con.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return flag;
        }
    }
}
