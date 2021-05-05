using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Database
{
    public class Data
    {
        private readonly Connection connection = new Connection();

        public Data()
        {
            connection.Connect();
        }
        public String GetSLAID(String SLAName)
        {
            String ID;
            try
            {
                string buildCommand = $"SELECT slaID FROM tblsla WHERE name = '{SLAName}'";
                connection.database.Open();
                ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return ID;
        }

        public string GetContractName(string clientID)
        {
            string name = "";
            try
            {
                string buildCommand = $"SELECT B.name FROM tblcontracts A JOIN tblsla B ON A.slaID = B.slaID WHERE A.clientID = '{clientID}'";
                connection.database.Open();
                name = (String)connection.RunCommand(buildCommand).ExecuteScalar();
                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return name;
        }

        public List<string> GetSLA()
        {
            List<string> SLAs = new List<string>();
            try
            {
                connection.database.Open();
                String Q = $"SELECT name FROM tblsla";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    SLAs.Add(row["name"].ToString());
                }
                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return SLAs;
        }

        //public String GetLastClientID()
        //{
        //    String ID;
        //    try
        //    {
        //        string buildCommand = $"SELECT TOP 1 clientID FROM tblclients ORDER BY clientID DESC";
        //        connection.database.Open();
        //        ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
        //        connection.database.Close();
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    String lastID = ID;
        //    return lastID;
        //}

        //public String GetLastIssueID()
        //{
        //    String ID;
        //    try
        //    {
        //        string buildCommand = $"SELECT TOP 1 issueID FROM tblissues ORDER BY issueID DESC";
        //        connection.database.Open();
        //        ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
        //        connection.database.Close();
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    String lastID = ID;
        //    return lastID;
        //}

        //public String GetLastReqID()
        //{
        //    String ID;
        //    try
        //    {
        //        string buildCommand = $"SELECT TOP 1 requestID FROM tblrequestData ORDER BY requestID DESC";
        //        connection.database.Open();
        //        ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
        //        connection.database.Close();
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    String lastID = ID;
        //    return lastID;
        //}

        //public String GetLastSLAID()
        //{
        //    String ID;
        //    try
        //    {
        //        string buildCommand = $"SELECT TOP 1 slaID FROM tblsla ORDER BY slaID DESC";
        //        connection.database.Open();
        //        ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
        //        connection.database.Close();
        //    }
        //    catch (Exception e)
        //    {

        //        throw e;
        //    }
        //    String lastID = ID;
        //    return lastID;
        //}

        public String GetLastID(String tblName,String idCol)
        {
            String ID;
            try
            {
                string buildCommand = $"SELECT TOP 1 {idCol} FROM {tblName} ORDER BY {idCol} DESC";
                connection.database.Open();
                ID = (String)connection.RunCommand(buildCommand).ExecuteScalar();
                connection.database.Close();
            }
            catch (Exception e)
            {

                throw e;
            }
            String lastID = ID;
            return lastID;
        }

        // Check whether an ID already exists in the given table & col
        public Boolean CheckExist(string id, string tblName, string idCol)
        {
            if (connection.database.State == System.Data.ConnectionState.Open)
            {
                connection.database.Close();
            }
            else
            {
                connection.database.Open();
            }
            if (tblName == "tblusers")
            {
                try
                {
                    string buildCommand = $"SELECT COUNT(*) FROM {tblName} WHERE {idCol}] = {id}";
                    int Exist = (int)connection.RunCommand(buildCommand).ExecuteScalar();
                    if (Exist > 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
            else
            {
                try
                {
                    string buildCommand = $"SELECT COUNT(*) FROM {tblName} WHERE {idCol} = {id}";
                    int Exist = (int)connection.RunCommand(buildCommand).ExecuteScalar();
                    if (Exist >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        
        // Delete a specific entry if it exists in database, in specified table
        public Boolean DeleteEntry(string id, string tblName, string idCol)
        {
            if (CheckExist(id, tblName, idCol))
            {
                if (tblName == "tblusers")
                {
                    string buildCommand = $"DELETE FROM {tblName} WHERE {idCol} + = " + Convert.ToInt32(id);
                    connection.RunCommand(buildCommand).ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    connection.database.Open();
                    string buildCommand = $"DELETE FROM {tblName} WHERE {idCol} = {id}";
                    connection.RunCommand(buildCommand).ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                
            }
            else
            {
                return false;
            }
        }
        
        // Check if specific entry exists in database in specified table and return SQLDataReader object
        public SqlDataReader FindEntry(string id, string tblName, string idCol)
        {
            if (CheckExist(id, tblName, idCol))
            {
                string buildCommand = $"SELECT * FROM {tblName} WHERE {idCol} = '{id}'";
                SqlDataReader reader = connection.RunCommand(buildCommand).ExecuteReader();
                connection.database.Close();
                return reader;
            }
            else
            {
                return null;
            }
        }
        
        // Find all entries in specified table and return SQLDataReader object
        public SqlDataReader FindAll(string tblName)
        {
            connection.database.Open();
            string buildCommand = $"SELECT * FROM {tblName}";
            SqlDataReader reader = connection.RunCommand(buildCommand).ExecuteReader();
            connection.database.Close();
            return reader;
        }

        // Add login user
        public Boolean AddUser(string username, string password)
        {
            try
            {
                // Check if user exists, if exist then update, otherwise add
                if (CheckExist(username, "tblusers", "username"))
                {
                    // Run update user code
                    connection.RunCommand($"UPDATE tblusers SET username ='{username}', password = '{password}', updatedAt = '{DateTime.Now}' WHERE username = '{username}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add user code
                    connection.RunCommand($"INSERT INTO dbo.tblusers(username, password, createdAt, updatedAt) VALUES('{username}','{password}','{DateTime.Now}','{DateTime.Now}')").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add client user
        public Boolean AddClient(string clientID, string name, string surname, string nationalID, string phoneNumber, string email, string address, int userID = -1)
        {
            try
            {
                // Check if client exists, if exist then update, otherwise add
                if (CheckExist(clientID, "tblclients", "clientID"))
                {
                    // Run update client code
                    connection.RunCommand("UPDATE tblclients SET clientID = \'" + clientID + "\', name = \'" + name + "\', surname = \'" + surname + "\', nationalID = " +
                                          nationalID + "\', phoneNumber = \'" + phoneNumber + "\', email = \'" + email + "\', address = \'" + address + "\' WHERE clientID = \'" + clientID + "\'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add client code
                    if (userID != -1)
                    {
                        connection.RunCommand("INSERT INTO dbo.tblclients VALUES(\'" + clientID + "\'," + userID + ",\'" +
                                              name + "\',\'" + surname + "\',\'" + nationalID + "\',\'" +
                                              phoneNumber + "\',\'" + email + "\',\'" + address + "\')").ExecuteNonQuery();
                    }
                    else
                    {
                        connection.RunCommand(
                            "INSERT INTO dbo.tblclients(clientID, name, surname, nationalID, phoneNumber, email, address) " +
                            "VALUES(\'" + clientID + "\',\'" + name + "\',\'" + surname + "\',\'" + nationalID + "\',\'" +
                            phoneNumber + "\',\'" + email + "\',\'" + address + "\')").ExecuteNonQuery();
                    }
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }
        //get all staff
        public Boolean GetAllStaff()
        {
            try
            {
                connection.database.Open();
                // get all the staff
                connection.RunCommand("SELECT * from tblstaff");
                return true;
            }
            catch (Exception e)
            {
                return true;
                throw ;
            }
    }
        // Add staff user
        public Boolean AddStaff(string staffID, string name, string surname, string status, string skills, string address, int userID = -1)
        {
            try
            {
                // Check if staff exists, if exist then update, otherwise add
                if (CheckExist(staffID, "tblstaff", "staffID"))
                {
                    // Run update staff code
                    connection.RunCommand("UPDATE tblstaff SET staffID = \'" + staffID + "\', name = \'" + name + "\', surname = \'" + surname + "\', status = \'" +
                                          status + "\', skills = \'" + skills + "\', address = \'" + address + "\' WHERE staffID = \'" + staffID + "\'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;

                    
                }
                else
                {
                    // Run add staff code
                    if (userID != -1)
                    {
                        connection.RunCommand("INSERT INTO dbo.tblstaff VALUES(\'" + staffID + "\'," + userID + ",\'" +
                                              name + "\',\'" + surname + "\',\'" + status + "\',\'" +
                                              skills + "\',\'" + address + "\')").ExecuteNonQuery();
                    }
                    else
                    {
                        connection.RunCommand(
                            "INSERT INTO dbo.tblstaff(staffID, name, surname, status, skills, address) " +
                            "VALUES(\'" + staffID + "\',\'" + name + "\',\'" + surname + "\',\'" + status + "\',\'" +
                            skills + "\',\'" + address + "\')").ExecuteNonQuery();
                    }
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add sla
        public Boolean AddSLA(string slaID, string name, string description, double tarif)
        {
            try
            {
                // Check if SLA exists, if exist then update, otherwise add
                if (CheckExist(slaID, "tblsla", "slaID"))
                {
                    // Run update SLA code
                    connection.RunCommand($"UPDATE tblsla SET slaID = '{slaID}', name = '{name}', description = '{description}', tarif = {tarif} WHERE slaID = '{slaID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add sla code
                    connection.RunCommand($"INSERT INTO dbo.tblsla VALUES('{slaID}','{name}','{description}',{tarif})").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Review Record
        public Boolean AddReview(string reviewID, string clientID, DateTime startTimestamp, DateTime endTimestamp, string staffID)
        {
            try
            {
                // Check if record exists, if exist then update, otherwise add
                if (CheckExist(reviewID, "tblreviewRecords", "reviewID"))
                {
                    // Run update Review Record code
                    connection.RunCommand($"UPDATE tblreviewRecords SET reviewID = '{reviewID}', clientID = '{clientID}', startTimestamp = '{startTimestamp}', endTimestamp = '{endTimestamp}', staffID = '{staffID}' WHERE reviewID = '{reviewID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add review code
                    connection.RunCommand($"INSERT INTO dbo.tblreviewRecords VALUES('{reviewID}','{clientID}','{startTimestamp}','{endTimestamp}','{staffID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Request
        public Boolean AddRequest(string requestID, string clientID, DateTime plannedDate, DateTime deadlineDate)
        {
            try
            {
                // Check if request exists, if exist then update, otherwise add
                if (CheckExist(requestID, "tblrequestData", "requestID"))
                {
                    // Run update Request code
                    connection.RunCommand($"UPDATE tblrequestData SET requestID = '{requestID}', clientID = '{clientID}', plannedDate = '{plannedDate}', deadlineDate = '{deadlineDate}' WHERE requestID = '{requestID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add request code
                    connection.RunCommand($"INSERT INTO dbo.tblrequestData VALUES('{requestID}','{clientID}','{plannedDate}','{deadlineDate}')").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Job
        public Boolean AddJob(string jobID, DateTime scheduledDate, string service, string status, string staffID)
        {
            try
            {
                // Check if job exists, if exist then update, otherwise add
                if (CheckExist(jobID, "tbljobs", "jobID"))
                {
                    // Run update Job code
                    connection.RunCommand($"UPDATE tbljobs SET jobID = '{jobID}', scheduledDate = '{scheduledDate}', service = '{service}', status = '{status}', staffID = '{staffID}' WHERE jobID = '{jobID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add Job code
                    connection.RunCommand($"INSERT INTO dbo.tbljobs VALUES('{jobID}','{scheduledDate}','{service}','{status}','{staffID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Job Record
        public Boolean AddJobRecord(string jobRecordID, string clientID, string callRecordID, string description, string status)
        {
            try
            {
                // Check if job record exists, if exist then update, otherwise add
                if (CheckExist(jobRecordID, "tbljobRecords", "jobRecordID"))
                {
                    // Run update Job code
                    connection.RunCommand($"UPDATE tbljobRecords SET jobRecordID = '{jobRecordID}', clientID = '{clientID}', callRecordID = '{callRecordID}', description = '{description}', status = '{status}' WHERE jobRecordID = '{jobRecordID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add Job Record code
                    connection.RunCommand($"INSERT INTO dbo.tbljobRecords VALUES('{jobRecordID}','{clientID}','{callRecordID}','{description}','{status}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Issue
        public Boolean AddIssue(string issueID, DateTime reportedDate, string clientID, string status, string staffID, string description)
        {
            try
            {
                // Check if issue exists, if exist then update, otherwise add
                if (CheckExist(issueID, "tblissues", "issueID"))
                {
                    // Run update issue code
                    connection.RunCommand($"UPDATE tblissues SET issueID = '{issueID}', reportedDate = '{reportedDate}', clientID = '{clientID}', status = '{status}', staffID = '{staffID}', description = '{description}' WHERE issueID = '{issueID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add Issue code
                    connection.RunCommand($"INSERT INTO dbo.tblissues VALUES('{issueID}','{reportedDate}','{clientID}','{status}','{staffID}','{description}')").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Contract
        public Boolean AddContract(string contractID, DateTime dateSigned, string clientID, string slaID)
        {
            try
            {
                // Check if contract exists, if exist then update, otherwise add
                if (CheckExist(contractID, "tblcontracts", "contractID"))
                {
                    // Run update contract code
                    connection.RunCommand($"UPDATE tblcontracts SET contractID = '{contractID}', dateSigned = '{dateSigned}', clientID = '{clientID}', slaID = '{slaID}' WHERE contractID = '{contractID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add Contract code
                    connection.RunCommand($"INSERT INTO dbo.tblcontracts VALUES('{contractID}','{dateSigned}','{clientID}','{slaID}')").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Call Record
        public Boolean AddCall(string callRecordID, string clientID, DateTime startTimestamp, DateTime endTimestamp, string staffID)
        {
            try
            {
                // Check if call record exists, if exist then update, otherwise add
                if (CheckExist(callRecordID, "tblcallRecords", "callRecordID"))
                {
                    // Run update Call Record code
                    connection.RunCommand($"UPDATE tblcallRecords SET callRecordID = '{callRecordID}', clientID = '{clientID}', startTimestamp = '{startTimestamp}', endTimestamp = '{endTimestamp}', staffID = '{staffID}' WHERE callRecordID = '{callRecordID}'").ExecuteNonQuery();
                    connection.database.Close();
                    return true;
                }
                else
                {
                    // Run add Call Record code
                    connection.RunCommand($"INSERT INTO dbo.tblcallRecords VALUES('{callRecordID}','{clientID}','{startTimestamp}','{endTimestamp}','{staffID}')").ExecuteNonQuery();
                    connection.database.Close();
                }

                
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
