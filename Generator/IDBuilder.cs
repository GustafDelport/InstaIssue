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
            String lastID = data.GetLastClientID();

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

        public String GenerateSlaID()
        {
            //Example: AA0001         
            String number = "";

            String type = "";
            String importance = "";

            String contractID = type + importance + number;

            return contractID;
        }
        public String GenerateIssueID()
        {
            //Example: IA0001     
            String number = "";

            String prefix = "I";
            String indicator = "";

            String IssueID = prefix + indicator + number;

            return IssueID;
        }
    }
}
