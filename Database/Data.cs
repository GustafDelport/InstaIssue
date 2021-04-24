using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    class Data
    {
        private readonly Connection connection = new Connection();

        public Data()
        {
            connection.Connect();
        }
        
        // Check whether an ID already exists in the given table & col
        public Boolean CheckExist(string id, string tblName, string idCol)
        {
            if (tblName == "tblusers")
            {
                try
                {
                    string buildCommand = "SELECT COUNT(*) FROM [" + tblName + "] WHERE ([" + idCol + "] = " + id + ")";
                    connection.database.Open();
                    int Exist = (int)connection.RunCommand(buildCommand).ExecuteScalar();
                    connection.database.Close();
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
                    string buildCommand = "SELECT COUNT(*) FROM [" + tblName + "] WHERE ([" + idCol + "] = \'" + id + "\')";
                    connection.database.Open();
                    int Exist = (int)connection.RunCommand(buildCommand).ExecuteScalar();
                    connection.database.Close();
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
        }

        // Add login user
        public Boolean AddUser(string username, string password)
        {
            try
            {
                // Add some logic here to first check whether the user already exists, if the role already exists then update, otherwise add new role and return true
                // code

                // Run add user code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblusers(username, password, createdAt, updatedAt) VALUES(\'" + username + "\',\'" + password + "\'," + DateTime.Now + "," + DateTime.Now + ")").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the client already exists, if the client already exists then update, otherwise add new client and return true
                // code

                // Run add client code
                connection.database.Open();
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
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add staff user
        public Boolean AddStaff(string staffID, string name, string surname, string status, string skills, string address, int userID = -1)
        {
            try
            {
                // Add some logic here to first check whether the staff account already exists, if the account already exists then update, otherwise add new account and return true
                // code

                // Run add staff code
                connection.database.Open();
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
                // Add some logic here to first check whether the SLA already exists, if the SLA already exists then update, otherwise add new SLA and return true
                // code

                // Run add sla code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblsla VALUES(\'" + slaID + "\'," + name + ",\'" +
                                      description + "\'," + tarif + ")").ExecuteNonQuery();
                connection.database.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // Add Review Record
        public Boolean AddReview(string reviewID, string clientID, DateTime startTimestamp, DateTime endTimestamp)
        {
            try
            {
                // Add some logic here to first check whether the Review already exists, if the Review already exists then update, otherwise add new Review and return true
                // code

                // Run add review code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblreviewRecords VALUES(\'" + reviewID + "\'," + clientID + "," +
                                      startTimestamp + "," + endTimestamp + ")").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Request already exists, if the Request already exists then update, otherwise add new Request and return true
                // code

                // Run add request code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblrequestData VALUES(\'" + requestID + "\',\'" + clientID + "\'," +
                                      plannedDate + "," + deadlineDate + ")").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Job already exists, if the Job already exists then update, otherwise add new Job and return true
                // code

                // Run add Job code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tbljobs VALUES(\'" + jobID + "\'," + scheduledDate + ",\'" +
                                      service + "\',\'" + status + "\',\'" + staffID + "\')").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Job Record already exists, if the Job Record already exists then update, otherwise add new Job Record and return true
                // code

                // Run add Job Record code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tbljobRecords VALUES(\'" + jobRecordID + "\',\'" + clientID + "\',\'" +
                                      callRecordID + "\',\'" + description + "\',\'" + status + "\')").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Issue already exists, if the Issue already exists then update, otherwise add new Issue and return true
                // code

                // Run add Issue code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblissues VALUES(\'" + issueID + "\'," + reportedDate + ",\'" +
                                      clientID + "\',\'" + status + "\',\'" + staffID + "\',\'" + description + "\')").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Contract already exists, if the Contract already exists then update, otherwise add new Contract and return true
                // code

                // Run add Contract code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblcontracts VALUES(\'" + contractID + "\'," + dateSigned + ",\'" +
                                      clientID + "\',\'" + slaID + "\')").ExecuteNonQuery();
                connection.database.Close();
                return true;
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
                // Add some logic here to first check whether the Call Record already exists, if the Call Record already exists then update, otherwise add new Call Record and return true
                // code

                // Run add Call code
                connection.database.Open();
                connection.RunCommand("INSERT INTO dbo.tblcontracts VALUES(\'" + callRecordID + "\',\'" + clientID + "\'," +
                                      startTimestamp + "," + endTimestamp + ",\'" + staffID + "\')").ExecuteNonQuery();
                connection.database.Close();
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
