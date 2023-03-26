using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ATM_Simulator
{
    public partial class ATM : Form
    {
        //Creates a list of accounts
        public List<Account> accounts = new List<Account>();
        private Account currentUser;


        public ATM()
        {

            InitializeComponent();
            loginPanel.Visible = true;
            accntScreenPanel.Visible = false;
            balancePanel.Visible = false;
            TestingMethod();

        }

        //For testing purposes
        private void TestingMethod()
        {

            CreateAccount(111111, 1111, 10);
            CreateAccount(222222, 2222, 20);
            CreateAccount(333333, 3333, 30);

/*            foreach (Account account in accounts)
            {
                string blah = account.accountNum.ToString();
                string blh = account.pin.ToString();
                MessageBox.Show(blah + "\n" + blh);

            }*/

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

        // method to check if the login details are valid when the login button is clicked
        private void loginButton_Click(object sender, EventArgs e)
        {
            // check if account number and pin number text boxes are empty
            if (string.IsNullOrWhiteSpace(accNumTxtBox.Text) || string.IsNullOrWhiteSpace(pinTxtBox.Text))
            {
                MessageBox.Show("Account details incorrect or account does not exist");
                return;
            }

            // get the contents of the account number and pin number fields, 
            // and convert to ints
            int accntNum = Convert.ToInt32(accNumTxtBox.Text);
            int pinNum = Convert.ToInt32(pinTxtBox.Text);

            // if account details are valid
            if (CheckPin(accntNum, pinNum))
            {

                // display the account balance in a label
                balanceLabel.Text = "Your balance is: �" + currentUser.balance.ToString();

                // hide the login screen
                accntScreenPanel.BringToFront();
                accntScreenPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Account details incorrect or account does not exist");
            }
        }


        //Method to create an account
        private bool CreateAccount(int accountNumber, int pinNum, int startingBalance)
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
        private static bool LengthCheck(int accNum, int pin)
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

        // method to check the account number and pin entered
        private bool CheckPin(int enteredAcc, int enteredPin)
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

        // method to bring user to the balance screen
        private void checkBalanceButton_Click(object sender, EventArgs e)
        {

            balancePanel.BringToFront();
            balancePanel.Visible = true;
        }

        // method to return the user to the account screen
        private void balanceReturnButton_Click(object sender, EventArgs e)
        {
            balancePanel.Visible = false;
            accntScreenPanel.BringToFront();
            accntScreenPanel.Visible = true;
        }
    }
}