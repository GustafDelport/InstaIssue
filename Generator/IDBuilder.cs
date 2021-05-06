using Database;
using System;

namespace Generator
{
    public class IDBuilder
    {
        private readonly Connection connection = new Connection();
        private Data data;
        private readonly Char[] Alphabet = new Char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        public IDBuilder()
        {
            connection.Connect();
            this.data = new Data();
        }

        public string GenerateClientID()
        {

            //Example ID : A00000001
            //             A99999999
            //             B00000001
            String lastID = data.GetLastID("tblclients","clientID");

            //Now we check it and change it
            String identifier = lastID.Substring(0, 1);
            String number = lastID.Substring(1, 8);

            if (int.Parse(number) == 99999999)
            {
                int n = 1;
                foreach (char item in Alphabet)
                {
                    if (Char.Parse(identifier) == item)
                    {
                        identifier = Alphabet[n].ToString();
                        number = "00000001";
                        break;
                    }
                    n++;
                }
            }
            else
            {
                int newNumber = int.Parse(number);
                newNumber++;
                number = newNumber.ToString();

                //My genius left pad replacement XDD DDD !!!!!!!!!
                int tempNum = int.Parse(number);
                number = tempNum.ToString($"D8");
            }

            string ID = identifier+number;

            return ID;
        }

        public String GenerateContractID(String SLAID)
        {
            //Four numeric digits representing the year the contract was issued.
            //▪ An alphabetic character specifying the general contract type(any uppercase
            //character from A to Z).
            //▪ An alphabetic character indicating the importance of the client, i.e.the general
            //service level to be afforded a client of this importance(A, B, C, or D).
            //▪ Six numeric digits, left padded with zeroes

            //Example: 2020AA000001
            Char[] charVersion = SLAID.ToCharArray();
            String number = "";

            String year = DateTime.Now.ToString("yyyy");
            String type = charVersion[0].ToString();
            String importance = charVersion[1].ToString();

            for (int i = 2; i < charVersion.Length-1; i++)
            {
                number += charVersion[i];
            }

            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D6");

            String contractID = year+type+importance+number;

            return contractID;
        }

        public String GenerateSlaID(string code)
        {
            String type = "";
            String importance = "";

            string[] raw = code.Split(',');
            switch (raw[0])
            {
                case "Maintenance":
                    {
                        type = "M";
                    }
                    break;
                case "Repair":
                    {
                        type = "R";
                    }
                    break;
                case "Replace":
                    {
                        type = "P";
                    }
                    break;
                case "Ultimate":
                    {
                        type = "U";
                    }
                    break;
            }
            
            switch (raw[1])
            {
                case "Level 1 - Most important":
                    {
                        importance = "A";
                    }
                    break;
                case "Level 2 - Important":
                    {
                        importance = "B";
                    }
                    break;
                case "Level 3 - Reductable":
                    {
                        importance = "C";
                    }
                    break;
            }

            string number = data.GetLastID("tblsla","slaID").Substring(2, 4);

            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D4");

            String contractID = type + importance + number;

            return contractID;
        }

        public String GenerateIssueID()
        {
            //Example: IA0001
            string lastID = data.GetLastID("tblissues","issueID");

            String prefix = "I";
            String number = lastID.Substring(2,4);
            String indicator = lastID.Substring(1,1);

            if (int.Parse(number) == 9999)
            {
                int n = 1;
                foreach (char item in Alphabet)
                {
                    if (Char.Parse(indicator) == item)
                    {
                        indicator = Alphabet[n].ToString();
                        number = "0001";
                        break;
                    }
                    n++;
                }
            }
            else
            {
                int newNumber = int.Parse(number);
                newNumber++;
                number = newNumber.ToString();

                //My genius left pad replacement XDD DDD !!!!!!!!!
                int tempNum = int.Parse(number);
                number = tempNum.ToString($"D4");
            }

            String IssueID = prefix + indicator + number;

            return IssueID;
        }

        public String GenerateReqID()
        {
            //Example REQ0000001
            String lastID = data.GetLastID("tblrequestData", "requestID");

            //Now we check it and change it
            String identifier = lastID.Substring(0, 3);
            String number = lastID.Substring(3, 7);

            if (int.Parse(number) == 9999999)
            {
                int n = 1;
                foreach (char item in Alphabet)
                {
                    if (Char.Parse(identifier) == item)
                    {
                        identifier = "REQ";
                        number = "0000001";
                        break;
                    }
                    n++;
                }
            }
            else
            {
                int newNumber = int.Parse(number);
                newNumber++;
                number = newNumber.ToString();

                //My genius left pad replacement XDD DDD !!!!!!!!!
                int tempNum = int.Parse(number);
                number = tempNum.ToString($"D7");
            }

            string ID = identifier + number;

            return ID;
        }

        public String GenerateProductID()
        {
            //A00000001
            String lastID = data.GetLastID("tblproducts", "productID");

            //Now we check it and change it
            String identifier = lastID.Substring(0, 1);
            String number = lastID.Substring(1, 8);

            if (int.Parse(number) == 99999999)
            {
                int n = 1;
                foreach (char item in Alphabet)
                {
                    if (Char.Parse(identifier) == item)
                    {
                        identifier = Alphabet[n].ToString();
                        number = "00000001";
                        break;
                    }
                    n++;
                }
            }
            else
            {
                int newNumber = int.Parse(number);
                newNumber++;
                number = newNumber.ToString();

                //My genius left pad replacement XDD DDD !!!!!!!!!
                int tempNum = int.Parse(number);
                number = tempNum.ToString($"D8");
            }

            string ID = identifier + number;

            return ID;
        }

        public String GenerateStaffID(string staffType)
        {
            //SM0004
            //SC0003
            //SA0002
            //Limit 9999 Staff members!

            string indicator = "S";
            string type = staffType.Substring(0,1);
            string number = "";

            String lastID = data.GetLastID("tblstaff", "staffID");

            number = lastID.Substring(2, 4);
            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D4");

            return indicator+type+number;
        }

        public String GenerateJobID(string clientID)
        {
            //JB00001A00000004
            //JB constant
            //00001 the number
            //A00000004 : clientID

            string constant = "JB";
            string number = "";
            string cID = clientID;

            String lastID = data.GetLastID("tbljobs", "productID");

            number = lastID.Substring(2, 3);
            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D5");

            return constant+number+cID;
        }

        public String GenerateJobRecordID(string clientID)
        {
            //JR00001A00000004
            //C constant
            //001 the number
            //A00000004 : clientID

            string constant = "JR";
            string number = "";
            string cID = clientID;

            String lastID = data.GetLastID("tbljobRecords", "jobRecordID");

            number = lastID.Substring(2, 3);
            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D5");


            return constant+number+cID;
        }

        public String GenerateCallRecordID(string clientID)
        {
            //CR00001A00000004
            //C constant
            //001 the number
            //A00000004 : clientID

            string constant = "CR";
            string number = "";
            string cID = clientID;

            String lastID = data.GetLastID("tblcallRecords", "callRecordID");

            number = lastID.Substring(2, 3);
            int newNumber = int.Parse(number);
            newNumber++;
            number = newNumber.ToString();

            int tempNum = int.Parse(number);
            number = tempNum.ToString($"D5");

            return constant + number + cID;
        }

    }

    
}
