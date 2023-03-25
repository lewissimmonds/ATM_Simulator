using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ATM_Simulator
{
    public partial class ATM : Form
    {
        //Creates a list of accounts
        public List<Account> accounts = new List<Account>();
        

        public ATM()
        {
            InitializeComponent();
            TestingMethod();
            

        }

        //For testing purposes
        private void TestingMethod()
        {
            
            if (CreateAccount(11111, 1111, 10))
            {
                Debug.WriteLine("success");
            }
            else
            {
                Debug.WriteLine("fail");
            }

            if (AccountExists(11111))
            {
                Debug.WriteLine("success");
            }
            else
            {
                Debug.WriteLine("fail");
            }

            if (CheckPin(11111, 1111))
            {
                Debug.WriteLine("success");
            }
            else
            {
                Debug.WriteLine("fail");
            }
        }

        // method to control the keypresses inside the account number text box
        private void accNumTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the key pressed is a digit
            if (char.IsDigit(e.KeyChar))
            {
                // if there is already 6 digits in the textbox, ignore the keypress
                if ((accNumTxtBox.Text + e.KeyChar).Length > 6)
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar))
            {
                // ignore anything that isn't a number
                e.Handled = true;
            }
        }

        // method to control the keypresses inside the pin number text box
        private void pinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the key pressed is a digit
            if (char.IsDigit(e.KeyChar))
            {
                // if there is already 4 digits in the textbox, ignore the keypress
                if ((pinTxtBox.Text + e.KeyChar).Length > 4)
                {
                    e.Handled = true;
                }
            }
            else if (!char.IsControl(e.KeyChar))
            {
                // ignore anything that isn't a number
                e.Handled = true;
            }
        }


        //Method to create an account
        private bool CreateAccount(int accountNumber, int pinNum, int startingBalance)
        {
            //Checks if this account number already exists, if so, account cannot be created
            if(AccountExists(accountNumber)) {
                return false;
            }
            else
            {
                //Account num does not already exist so it is create
                Account newAccount = new Account(accountNumber, pinNum, startingBalance);
                accounts.Add(newAccount);
                return true;
            }
        }


        //Method to check if an account exists
        private bool AccountExists(int enteredNum)
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

        private bool CheckPin(int enteredAcc, int enteredPin)
        {
            //Loop through each account in the list of accounts
            foreach (Account account in accounts)
            {
                //If the account number matches, return true
                if (account.accountNum == enteredAcc)
                {
                    if(account.pin == enteredPin)
                    {
                        //Pin is valid as account pin matches the entered pin
                        return true;
                    }
                    else
                    {
                        //Pin is not valid as account pin does not match the entered pin
                        return false;
                    }
                }
            }
            //Only come here if there is not accounts that exist at all
            return false;
        }
    }
}