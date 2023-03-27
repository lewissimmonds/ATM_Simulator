using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    public class Bank
    {
        //Creates a list of accounts
        public List<Account> accounts = new List<Account>();
        public Account currentUser;
        public ATM atm;

        public Bank() { 
            TestingMethod();
            currentUser = new Account(000000, 0000, 0);
        }

        //For testing purposes
        private void TestingMethod()
        {

            CreateAccount(111111, 1111, 100);
            CreateAccount(222222, 2222, 200);
            CreateAccount(333333, 3333, 300);

            /*            foreach (Account account in accounts)
                        {
                            string blah = account.accountNum.ToString();
                            string blh = account.pin.ToString();
                            MessageBox.Show(blah + "\n" + blh);

                        }*/

        }

        //Method to create an account
        public bool CreateAccount(int accountNumber, int pinNum, int startingBalance)
        {
            //Checks if length of pin and account num are valid
            if (LengthCheck(accountNumber, pinNum))
            {
                //Checks if this account number already exists, if so, account cannot be created
                if (AccountExists(accountNumber))
                {
                    Debug.WriteLine("ERROR: Account with entered number already exists");
                    return false;
                }
                else
                {
                    //Account num does not already exist so it is created
                    Account newAccount = new Account(accountNumber, pinNum, startingBalance);
                    accounts.Add(newAccount);
                    return true;
                }
            }
            else
            {
                return false;
            }


        }

        //Method to check pin is 4 digits long and account is 6 digits long
        public bool LengthCheck(int accNum, int pin)
        {
            if (accNum.ToString().Length == 6)
            {
                if (pin.ToString().Length == 4)
                {
                    return true;
                }
                else
                {
                    Debug.WriteLine("ERROR: Pin number not 4 digits");
                    return false;
                }
            }
            else
            {
                Debug.WriteLine("ERROR: Account number not 6 digits");
                return false;
            }
        }



        //Method to check if an account exists
        public bool AccountExists(int enteredNum)
        {
            //Loop through each account in the list of accounts
            foreach (Account account in accounts)
            {
                //If the account number matches, return true
                if (account.accountNum == enteredNum)
                {
                    return true;
                }
            }

            //If no account with the given account number was found, return false
            return false;
        }

        // method to check the account number and pin entered
        public bool CheckPin(int enteredAcc, int enteredPin)
        {
            // Loop through each account in the list of accounts
            foreach (Account account in accounts)
            {
                // If the account number and pin match, set the current user to the found account and return true
                if (account.accountNum == enteredAcc && account.pin == enteredPin)
                {
                    currentUser = account;
                    return true;
                }
            }

            // If no account with the given account number and pin was found, show an error message and return false
            MessageBox.Show("ERROR: Account details incorrect or account does not exist");
            return false;
        }
    }
}
