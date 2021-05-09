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

        public DataTable GetContracts()
        {
            DataTable table = new DataTable();
            table.Load(new Data().FindAll("tblcontracts"));
            return table;
        }

        public List<SLA> GetListSLAs()
        {
            List<SLA> SLAs = new List<SLA>();
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

                    SLAs.Add(new SLA(arr[0], arr[1], arr[2], arr[3]));
                }

                connection.database.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            return SLAs;
        }

        internal bool AddSLA(string name, string descrip, string tarif, string code)
        {
            String slaID = new IDBuilder().GenerateSlaID(code);
            return data.AddSLA(slaID,name,descrip,Double.Parse(tarif));
        }

        public DataTable GetSLAs()
        {
            DataTable table = new DataTable();
            table.Load(new Data().FindAll("tblsla"));
            return table;
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
        public Boolean EditSLA(SLA sla)
        {
            try
            {
                data.AddSLA(sla.SLAID1, sla.Name, sla.Description, double.Parse(sla.Tarif));
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
