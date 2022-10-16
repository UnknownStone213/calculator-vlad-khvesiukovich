using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Util
    {
        string num = "";
        public string Num
        {
            get 
            {
                return num; 
            }
            set
            {
                /*
                if (num.Length < 9)
                {
                    num = value;
                }
                else if (num.Length == 9 && (value == null || value == ""))
                {
                    num = "";
                }
                */
                if (num.Length < 9)
                {
                    num = value;
                }
                else if (num.Length == 9 && num.IndexOf('-') == -1)//9 numbers w/out minus
                {
                    if (value == "-" + num)
                    {
                        num = value;
                    }
                    else if(value == null || value == "")
                    {
                        num = "";
                    }
                }
                else if(num.Length == 9 && num.IndexOf('-') != -1)
                {
                    num = value;
                }
                else if(num.Length == 10)
                {
                    if (value == num.Substring(1, num.Length - 1))//change to plus
                    {
                        num = value;
                    }
                    else
                    {
                        if (value == null || value == "")//able to delete (clear)
                        {
                    num = "";
                }
            }
        }
            }
        }
        string num1 = "";
        public string Num1 
        {
            get
            {
                return num1;
            }
            set 
            {
                num1 = value;
            }
        }
        string action = "";
        public string Action
        {
            get { return action; }
            set { action = value; }
        }
        public void Result() 
        {
            switch (action)
            {
                case "+":
                    num1 = Convert.ToString(Convert.ToInt32(num1) + Convert.ToInt32(num));
                    action = "+";
                    break;
                case "-":
                    num1 = Convert.ToString(Convert.ToInt32(num1) - Convert.ToInt32(num));
                    action = "-";
                    break;
                case "*":
                    num1 = Convert.ToString(Convert.ToInt32(num1) * Convert.ToInt32(num));
                    action = "*";
                    break;
                case "/":// остаток
                    num1 = Convert.ToString(Convert.ToInt32(num1) / Convert.ToInt32(num));
                    action = "/";
                    break;
                default:
                    break;
            }
            num = "";
        }
    }
}
