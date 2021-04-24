using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Data
    {
        private Connection connection = new Connection();

        public Data()
        {
            connection.Connect();
        }

        // public Boolean UpdateRole(int userID, int roleID)
        // {
        //
        // }
    }
}
