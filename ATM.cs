using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ATM_Simulator
{
    public partial class ATM : Form
    {
        private Bank bank;
        public ATM(Bank bank)
        {
            InitializeComponent();
            LoginPanel.Visible = true;
            AccntScreenPanel.Visible = false;
            BalancePanel.Visible = false;
            WithdrawPanel.Visible = false;

            this.bank = bank;
        }

        // method to control the keypresses inside the account number text box
        private void AccNumTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the key pressed is a digit
            if (char.IsDigit(e.KeyChar))
            {
                // if there is already 6 digits in the textbox, ignore the keypress
                if ((AccNumTxtBox.Text + e.KeyChar).Length > 6)
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
        private void PinTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // check if the key pressed is a digit
            if (char.IsDigit(e.KeyChar))
            {
                // if there is already 4 digits in the textbox, ignore the keypress
                if ((PinTxtBox.Text + e.KeyChar).Length > 4)
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
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // check if account number and pin number text boxes are empty
            if (string.IsNullOrWhiteSpace(AccNumTxtBox.Text) || string.IsNullOrWhiteSpace(PinTxtBox.Text))
            {
                MessageBox.Show("Account details incorrect or account does not exist");
                return;
            }

            // get the contents of the account number and pin number fields, 
            // and convert to ints
            int accntNum = Convert.ToInt32(AccNumTxtBox.Text);
            int pinNum = Convert.ToInt32(PinTxtBox.Text);

            // if account details are valid
            if (bank.CheckPin(accntNum, pinNum))
            {

                // display the account balance in a label
                BalanceLabel.Text = "Your balance is: £" + bank.currentUser.balance.ToString();

                // hide the login screen
                AccntScreenPanel.BringToFront();
                AccntScreenPanel.Visible = true;
            }
            else
            {
                MessageBox.Show("Account details incorrect or account does not exist");
            }
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {



        }

        private void WithdrawReturnButton_Click(object sender, EventArgs e)
        {



        }


        // method to bring user to the balance screen
        private void CheckBalanceButton_Click(object sender, EventArgs e)
        {

            BalancePanel.BringToFront();
            BalancePanel.Visible = true;
        }

        // method to return the user to the account screen
        private void BalanceReturnButton_Click(object sender, EventArgs e)
        {
            BalancePanel.Visible = false;
            AccntScreenPanel.BringToFront();
            AccntScreenPanel.Visible = true;
        }

        // method to "return the card", aka, log the user out
        private void ReturnCardButton_Click(object sender, EventArgs e)
        {

            // reset the login details fields
            AccNumTxtBox.Text = "";
            PinTxtBox.Text = "";

            AccntScreenPanel.Visible = false;
            LoginPanel.Visible = true;
            LoginPanel.BringToFront();
        }
    }
}