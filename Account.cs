using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{

    //Class handles storing of all the account data
    public class Account
    {
        public int accountNum { get; set; }
        public int pin { get; set; }
        public int balance { get; set; }

        public Account(int accNum, int pinNum, int bal)
        {
            accountNum = accNum;
            pin = pinNum;
            balance = bal;
        }
    }
}
