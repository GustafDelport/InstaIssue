using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Authentication
{
    public class Validations
    {
        public Boolean ValidateRegisterClient(Panel panel)
        {
            Boolean[] flagArr = new Boolean[7];
            Boolean flag = false;
            int n = 0;

            foreach (Control item in panel.Controls)
            {
                if (item is TextBox)
                {
                    switch (item.Name)
                    {
                        case "txtNatID":
                            {
                                flagArr[n] = ValidateID(item.Text);
                                n++;
                            }
                            break;
                        case "txtPhone":
                            {
                                flagArr[n] = validateNumber(item.Text);
                                n++;
                            }
                            break;
                        case "txtEmail":
                            {
                                flagArr[n] = validateEmail(item.Text);
                                n++;
                            }
                            break;
                        default:
                            {
                                flagArr[n] = validateText(item.Text);
                                n++;
                            }
                            break;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;

                    if (box.SelectedIndex == -1)
                    {
                        flagArr[n] = false;
                        n++;
                    }
                    else
                    {
                        flagArr[n] = true;
                        n++;
                    }
                }
                else
                {
                    continue;
                }
                
            }

            foreach (var item in flagArr)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }

            return flag;
        }

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
          
            switch (data.Substring(1,1))
            {
                case "A":
                    {
                        //Call Agent
                        n = 2;
                    }
                    break;
                case "C":
                    {
                        //Admin
                        n = 1;
                    }
                    break;
                case "M":
                    {
                        //Service Manager
                        n = 3;
                    }
                    break;             
            }

            return n;
        }

        public Boolean validateText(String data)
        {
            Boolean flag = true;

            if (!String.IsNullOrEmpty(data) && !Regex.IsMatch(data, "^[0-9]+$"))
            {
                flag = true;
            }
            else flag = false;

            return flag;
        }

        public Boolean validateNumber(String data)
        {
            Boolean flag = true;

            if (!String.IsNullOrEmpty(data) && Regex.IsMatch(data, "^[0-9]+$"))
            {
                flag = true;
            }
            else flag = false;

            return flag;
        }

        public Boolean validateEmail(String data)
        {
            Boolean flag = true;

            if (!String.IsNullOrEmpty(data) && Regex.IsMatch(data, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                flag = true;
            }
            else flag = false;

            return flag;
        }

        public Boolean validateIssueCreation(Panel panel)
        {
            Boolean[] flagArr = new Boolean[7];
            Boolean flag = false;
            int n = 0;

            foreach (Control item in panel.Controls)
            {
                if (item is RichTextBox)
                {
                    flagArr[n] = validateText(item.Text);
                    n++;
                }
            }
            foreach (var item in flagArr)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }

            return flag;
        }

        public Boolean validateSLACreation(Panel panel)
        {
            Boolean flag = false;
            Boolean[] flagArr = new Boolean[5];
            int n = 0;

            foreach (Control item in panel.Controls)
            {
                if (item is RichTextBox || item is TextBox)
                {
                    if (item.Name == "txtTarif")
                    {
                        flagArr[n] = validateNumber(item.Text);
                        n++;
                    }
                    else if (item.Name == "txtName")
                    {
                        flagArr[n] = validateText(item.Text);
                        n++;
                    }
                    else
                    {
                        flagArr[n] = validateText(item.Text);
                        n++;
                    }
                }
                else if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;

                    if (box.SelectedIndex == -1)
                    {
                        flagArr[n] = false;
                        n++;
                    }
                    else
                    {
                        flagArr[n] = true;
                        n++;
                    }
                }
                else
                {
                    continue;
                }

            }
            foreach (var item in flagArr)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }

            return flag;
        }

        public Boolean validateReqCreation(Panel panel)
        {
            Boolean[] flagArr = new Boolean[3];
            Boolean flag = false;
            int n = 0;

            foreach (Control item in panel.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;

                    if (box.SelectedIndex == -1)
                    {
                        flagArr[n] = false;
                        n++;
                    }
                    else
                    {
                        flagArr[n] = true;
                        n++;
                    }
                }
                else { continue; }
            }

            foreach (var item in flagArr)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }

            return flag;
        }

        public Boolean validateProductsCreation(Panel panel)
        {
            Boolean flag = false;
            Boolean[] flagArr = new Boolean[4];
            int n = 0;

            foreach (Control item in panel.Controls)
            {
                if (item is TextBox || item is DateTimePicker)
                {
                    flagArr[n] = validateText(item.Text);
                }
                else if (item is ComboBox)
                {
                    ComboBox box = (ComboBox)item;

                    if (box.SelectedIndex == -1)
                    {
                        flagArr[n] = false;
                        n++;
                    }
                    else
                    {
                        flagArr[n] = true;
                        n++;
                    }
                }
                else
                {
                    continue;
                }

            }
            foreach (var item in flagArr)
            {
                if (!item)
                {
                    //Our final flag to count as one singular status check
                    flag = false;
                    break;
                }
                else
                {
                    flag = true;

                }
            }
            return flag;
        }
    }
}
