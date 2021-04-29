using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Authentication
{
    public class Validations
    {
        public Boolean ValidateID(String data)
        {
            Boolean flag = false;

            if (data.Length == 13 && Regex.IsMatch(data, "^[0-9]+$"))
            {
                flag = true;
            }
            else flag = false;

            return flag;
        }

        public int ValidateStaffRank(String data)
        {
            int n = 0;

            switch (data.Substring(0,3))
            {
                case "AGT":
                    {
                        //Call Agent
                        n = 1;
                    }
                    break;
                case "ADM":
                    {
                        //Admin
                        n = 2;
                    }
                    break;
                case "SEM":
                    {
                        //Service Manager
                        n = 3;
                    }
                    break;
                case "Agt":
                    {
                        n = 1;
                    }
                    break;
            }

            return n;
        }

    }
}
