using Database;
using InstaIssue.AdminCenter.DomainLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using InstaIssue.CallCenter.DomainLayer;
using Generator;

namespace InstaIssue.AdminCenter.LogicLayer
{
    internal class ContractsManagment
    {
        private readonly Connection connection = new Connection();
        private readonly Data data = new Data();

        public ContractsManagment()
        {
            connection.Connect();
        }

        public List<Contracts> GetContract()
        {
            List<Contracts> contracts = new List<Contracts>();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblcontracts";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                String[] arr = new string[4];
                foreach (DataRow row in table.Rows)
                {
                    arr[0] = row["contractID"].ToString();
                    arr[1] = row["dateSigned"].ToString();
                    arr[2] = row["clientID"].ToString();
                    arr[3] = row["slaID"].ToString();

                    contracts.Add(new Contracts(arr[0], DateTime.Parse(arr[1]), arr[2], arr[3]));
                }
                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return contracts;
        }

        internal bool AddSLA(string name, string descrip, string tarif, string code)
        {
            String slaID = new IDBuilder().GenerateSlaID(code);
            return data.AddSLA(slaID,name,descrip,Double.Parse(tarif));
        }

        public List<SLA> GetSLAs()
        {
            List<SLA> slas = new List<SLA>();
            try
            {
                connection.database.Open();

                String Q = $"SELECT * FROM tblsla";
                SqlConnection con = connection.GetSqlConnection();

                SqlDataAdapter reader = new SqlDataAdapter(Q, con);
                DataTable table = new DataTable();

                reader.Fill(table);

                String[] arr = new string[4];
                foreach (DataRow row in table.Rows)
                {
                    arr[0] = row["slaID"].ToString();
                    arr[1] = row["name"].ToString();
                    arr[2] = row["description"].ToString();
                    arr[3] = row["tarif"].ToString();

                    slas.Add(new SLA(arr[0], arr[1], arr[2], arr[3]));
                }
                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return slas;
        }

        public Boolean AddContract(String contractID, DateTime dateSigned, String clientID, String SlaID)
        {
            try
            {
                data.AddContract(contractID, dateSigned, clientID, SlaID);
            }
            catch (Exception e)
            {
                MessageBox.Show("Contract could not be added.");
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public Boolean EditContract(String type, String newData)
        {
            try
            {
                //data.AddContract();
            }
            catch (Exception e)
            {
                MessageBox.Show("Contract could not be edited.");
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public Boolean DeleteContract(String contractID)
        {
            try
            {
                data.DeleteEntry(contractID, "tblcontracts", "contractID");
            }
            catch (Exception e)
            {
                MessageBox.Show("Contract could not be deleted.");
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
        public Boolean EditSLA(String type, String newData)
        {
            try
            {
                //data.AddSLA();
            }
            catch (Exception e)
            {
                MessageBox.Show("SLA could not be edited or found.");
                Console.WriteLine(e);
                return false;
            }
            return true;
        }

        public Boolean DeleteSLA(String staffID)
        {
            try
            {
                data.DeleteEntry(staffID, "tblstaff", "staffID");
            }
            catch (Exception e)
            {
                MessageBox.Show("SLA not found.");
                Console.WriteLine(e);
                return false;
            }
            return true;
        }
    }
}
