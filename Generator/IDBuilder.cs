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
            String lastID = "A00000003";//data.GetLastClientID();

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
                //Left padding here

                String tempNum = number;
                int n = tempNum.Length;

                tempNum.PadRight(7,'0');

                //switch (number.Length)
                //{
                //    case 1:
                //        {
                //            //Pad left 7
                //            number.PadLeft(7, '0');
                //        }
                //        break;
                //    case 2:
                //        {
                //            //Pad left 6
                //            number.PadLeft(6, '0');
                //        }
                //        break;
                //    case 3:
                //        {
                //            //Pad left 5
                //            number.PadLeft(5, '0');
                //        }
                //        break;
                //    case 4:
                //        {
                //            //Pad left 4
                //            number.PadLeft(4, '0');
                //        }
                //        break;
                //    case 5:
                //        {
                //            //Pad left 3
                //            number.PadLeft(3, '0');
                //        }
                //        break;
                //    case 6:
                //        {
                //            //Pad left 2
                //            number.PadLeft(2, '0');
                //        }
                //        break;
                //    case 7:
                //        {
                //            //Pad left 1
                //            number.PadLeft(1, '0');
                //        }
                //        break;
                //    default:
                //        break;
                //}

            }

            string ID = identifier+number;

            return ID;
        }
    }
}
