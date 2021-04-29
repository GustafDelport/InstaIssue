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

    }
}
