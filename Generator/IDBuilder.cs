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
    }
}
