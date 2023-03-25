using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    internal class Account
    {
        public int accountNum { get; set; }
        public int pin { get; set; }

        public Account(int accNum, int pinNum)
        {
            accountNum = accNum;
            pin = pinNum;
        }
    }
}
