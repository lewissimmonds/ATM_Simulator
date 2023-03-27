using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class ATM : Form
    {

        // declare variables
        private CentralBankForm _centralBankForm;
        private Bank bank;
        private TextBox textBox;
        string currentState;
        int accntNumber;
        int withdrawAmount;
        bool dataCon;
        private SemaphoreSlim userSemaphore;

        // constructor for atm object
        public ATM(Bank bank, bool dataCon, TextBox textBox)
        {
            InitializeComponent();
            this.dataCon = dataCon;
            this.bank = bank;
            this.textBox = textBox;
            userSemaphore = new SemaphoreSlim(1);

            // current state is set to account login for the first screen
            // user is presented with
            currentState = "accountLogin";

        }

        // method to allow only numbers to be typed
        private void ScreenTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allow digits, backspace and delete keys
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 127)
            {
                e.Handled = true;
            }
        }

        // method to handle the enter button
        private void EnterButton_Click(object sender, EventArgs e)
        {

            // switch-case to execute logic depending on the current state of the atm interaction
            switch (currentState)
            {

                // case where atm wants account number
                case "accountLogin":

                    // error handling for if user enters an account number that isn't 6-digits
                    if (ScreenTextBox.Text.Length != 6)
                    {

                        // have a popup to signify error
                        MessageBox.Show("ERROR: please enter a 6-digit account number");
                        LogMessage("[INFO] Failed login");
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        return;
                    }

                    LogMessage("[INFO] Account found");


                    // method to show card being inserted
                    InsertCard();

                    // get the account number from what user has typed
                    int accntNum = Convert.ToInt32(ScreenTextBox.Text);

                    // if a bank account with this account number is found
                    if (bank.AccountExists(accntNum))
                    {

                        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                        timer.Interval = 2000;
                        timer.Tick += (object sender, EventArgs e) =>
                        {

                            // put this entered account number into a variable for later
                            accntNumber = accntNum;
                            ScreenTextBox.Text = "";
                            ScreenTextBox.Focus();
                            ScreenOutputTextBox.Text = "Please enter your pin number";

                            timer.Stop();

                        };
                        timer.Start();
                    }

                    // change the state to pin login
                    currentState = "pinLogin";

                    break;

                // case where atm wants pin number
                case "pinLogin":

                    // error handling for if user enters a pin number that isn't 4-digits
                    if (ScreenTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Please enter a 4-digit pin number");
                        LogMessage("[INFO] Failed login");
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        return;
                    }

                    // get the pin number from what user has typed
                    int pinNum = Convert.ToInt32(ScreenTextBox.Text);

                    // if the account pin match
                    if (bank.CheckPin(accntNumber, pinNum))
                    {

                        // display to the user the options
                        ScreenOutputTextBox.Text = "Please select the option you'd like to do";
                        Option1Label.Visible = true;
                        Option2Label.Visible = true;
                        Option3Label.Visible = true;
                        ScreenTextBox.Visible = false;
                        LogMessage("[INFO] Successful login");
                        currentState = "loggedIn";
                    }
                    break;

                case "loggedIn":

                    break;

                case "customAmount":

                    // store the amount the user wants to withdraw in a variable
                    int withdrawAmount = Convert.ToInt32(ScreenTextBox.Text);

                    // pass that into a method which deals with the withdrawing logic
                    WithdrawingLogic(withdrawAmount);
                    break;
            }
        }

        // method to deal with when the clear button is clicked
        private void ClearButton_Click(object sender, EventArgs e)
        {

            // clear the textbox of any text and return focus to it
            ScreenTextBox.Text = "";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        // method to deal with when the cancel button is clicked
        private void CancelButton_Click(object sender, EventArgs e)
        {

            // case-switch to deal with the current state the machine is in
            switch (currentState)
            {

                // if the state is withdrawing
                case ("withdrawing"):

                    // return to the options menu
                    ScreenOutputTextBox.Visible = true;
                    ScreenOutputTextBox.Text = "Please select the option you'd like to do";
                    Option1Label.Visible = true;
                    Option1Label.Text = "Withdraw";
                    Option2Label.Visible = true;
                    Option2Label.Text = "Check Balance";
                    Option3Label.Visible = true;
                    Option3Label.Text = "Return Card";
                    Option4Label.Visible = false;
                    Option5Label.Visible = false;
                    Option6Label.Visible = false;
                    Option7Label.Visible = false;
                    Option8Label.Visible = false;
                    ScreenTextBox.Visible = false;
                    currentState = "loggedIn";

                    break;

                // if the case is when a custom amount is being input
                case ("customAmount"):

                    // return the user to the amount to withdraw menu
                    ScreenOutputTextBox.Text = "How much would you like to withdraw?";
                    Option1Label.Text = "�500";
                    Option2Label.Text = "�250";
                    Option3Label.Text = "�100";
                    Option1Label.Visible = true;
                    Option2Label.Visible = true;
                    Option3Label.Visible = true;
                    Option4Label.Visible = true;
                    Option5Label.Visible = true;
                    Option6Label.Visible = true;
                    Option7Label.Visible = true;
                    Option8Label.Visible = true;
                    currentState = "withdrawing";

                    break;
            }
        }

        //various methods to deal with the number buttons being clicked
        private void Num1Button_Click(object sender, EventArgs e)
        {

            // add a one to the textbox and return focus to it
            ScreenTextBox.Text += "1";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num2Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "2";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num3Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "3";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num4Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "4";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num5Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "5";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num6button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "6";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num7Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "7";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num8Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "8";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num9Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "9";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void Num0Button_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text += "0";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }


        // methods to deal with when the user clicks the option buttons around the atm screen
        private void Option1Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("loggedIn"):

                    // user wants to withdraw, display the amounts available 
                    ScreenOutputTextBox.Text = "How much would you like to withdraw?";
                    Option1Label.Text = "£500";
                    Option2Label.Text = "£250";
                    Option3Label.Text = "£100";
                    Option4Label.Visible = true;
                    Option5Label.Visible = true;
                    Option6Label.Visible = true;
                    Option7Label.Visible = true;
                    Option8Label.Visible = true;
                    currentState = "withdrawing";

                    break;

                case ("withdrawing"):

                    // withdraw the amount clicked, in this case option 1 is £500
                    WithdrawingLogic(500);

                    break;
            }
        }

        private void Option2Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("loggedIn"):

                    // display the balance to the user
                    BalanceLabel.Visible = true;
                    BalanceLabel.Text = "Your balance is: £" + bank.currentUser.balance.ToString();
                    ScreenOutputTextBox.Visible = false;
                    Option1Label.Visible = false;
                    Option2Label.Visible = false;
                    Option3Label.Visible = false;
                    Option4Label.Visible = true;
                    Option4Label.Text = "Go Back";
                    currentState = "checkingBalance";

                    break;

                case ("withdrawing"):

                    WithdrawingLogic(250);

                    break;
            }
        }

        private void Option3Button_Click(object sender, EventArgs e)
        {

            switch (currentState)
            {
                case ("loggedIn"):

                    // "log the user out" by hiding all visible elements on screen
                    Option1Label.Visible = false;
                    Option2Label.Visible = false;
                    Option3Label.Visible = false;
                    Option4Label.Visible = false;
                    Option5Label.Visible = false;
                    Option6Label.Visible = false;
                    Option7Label.Visible = false;
                    Option8Label.Visible = false;
                    ScreenOutputTextBox.Visible = false;
                    BalanceLabel.Location = new Point(110, 145);
                    BalanceLabel.Text = "Have a nice day!";
                    BalanceLabel.Visible = true;

                    LogMessage("[INFO] Successfully logged out");
                    RemoveCard();

                    // timer to keep message on screen for 2 seconds
                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 2000;
                    timer.Tick += (object sender, EventArgs e) =>
                    {

                        // take user back to screen to input account number
                        BalanceLabel.Visible = false;
                        ScreenOutputTextBox.Visible = true;
                        ScreenOutputTextBox.Text = "Please enter your account number";
                        ScreenTextBox.Visible = true;
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        currentState = "accountLogin";
                        timer.Stop();
                    };
                    timer.Start();

                    break;

                case ("withdrawing"):

                    WithdrawingLogic(100);

                    break;
            }


        }

        private void Option4Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("checkingBalance"):

                    // take the user back from the checking balance screen to options menu
                    Option1Label.Visible = true;
                    Option2Label.Visible = true;
                    Option3Label.Visible = true;
                    Option4Label.Visible = false;
                    BalanceLabel.Visible = false;
                    ScreenOutputTextBox.Visible = true;
                    currentState = "loggedIn";

                    break;

                case ("withdrawing"):

                    WithdrawingLogic(50);

                    break;
            }
        }

        private void Option5Button_Click(object sender, EventArgs e)
        {
            WithdrawingLogic(25);
        }

        private void Option6Button_Click(object sender, EventArgs e)
        {
            WithdrawingLogic(15);
        }

        private void Option7Button_Click(object sender, EventArgs e)
        {
            WithdrawingLogic(10);
        }

        private void Option8Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("withdrawing"):

                    // take user to screen to input custom amount
                    Option1Label.Visible = false;
                    Option2Label.Visible = false;
                    Option3Label.Visible = false;
                    Option4Label.Visible = false;
                    Option5Label.Visible = false;
                    Option6Label.Visible = false;
                    Option7Label.Visible = false;
                    Option8Label.Visible = false;
                    ScreenOutputTextBox.Text = "Please enter the amount you'd like to withdraw";
                    ScreenOutputTextBox.Font = new Font(ScreenOutputTextBox.Font.FontFamily, 10);
                    ScreenTextBox.Visible = true;
                    ScreenTextBox.Text = "";
                    ScreenTextBox.Focus();

                    currentState = "customAmount";

                    break;

                case ("customAmount"):

                    ScreenOutputTextBox.Font = new Font(ScreenOutputTextBox.Font.FontFamily, 12);

                    break;
            }
        }

        // method to execute the logic for money withdrawal
        private void WithdrawingLogic(int withdrawalAmount)
        {

            // variable for the amount to withdraw
            withdrawAmount = withdrawalAmount;

            // can't withdraw funds you don't have 
            if (withdrawAmount > bank.currentUser.balance)
            {

                // display an error to signify this
                WithdrawWarningLabel.Visible = true;
                ScreenTextBox.Visible = false;
                Option1Label.Visible = false;
                Option2Label.Visible = false;
                Option3Label.Visible = false;
                Option4Label.Visible = false;
                Option5Label.Visible = false;
                Option5Label.Visible = false;
                Option6Label.Visible = false;
                Option7Label.Visible = false;
                Option8Label.Visible = false;
                ScreenOutputTextBox.Visible = false;

                // using a timer to pause execution of the next lines of code,
                // and execute after 2 seconds
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Interval = 2000;
                timer.Tick += (object sender, EventArgs e) =>
                {
                    WithdrawWarningLabel.Visible = false;
                    Option1Label.Visible = true;
                    Option2Label.Visible = true;
                    Option3Label.Visible = true;
                    Option4Label.Visible = true;
                    Option5Label.Visible = true;
                    Option5Label.Visible = true;
                    Option6Label.Visible = true;
                    Option7Label.Visible = true;
                    Option8Label.Visible = true;
                    ScreenOutputTextBox.Visible = true;
                    ScreenOutputTextBox.Text = "How much would you like to withdraw?";
                    ScreenOutputTextBox.Font = new Font(ScreenOutputTextBox.Font.FontFamily, 12);
                    currentState = "withdrawing";
                    timer.Stop();
                };
                timer.Start();

            }
            else
            {

                // display to user that cash is being dispensed
                BalanceLabel.Visible = true;
                BalanceLabel.Location = new Point(100, 145);
                BalanceLabel.Text = "Dispensing cash...";
                DispenseCash();
                ScreenOutputTextBox.Visible = false;
                Option1Label.Visible = false;
                Option2Label.Visible = false;
                Option3Label.Visible = false;
                Option4Label.Visible = false;
                Option5Label.Visible = false;
                Option6Label.Visible = false;
                Option7Label.Visible = false;
                Option8Label.Visible = false;

                // another timer to simulate calculations taking place
                System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 2000;
                timer1.Tick += (object sender, EventArgs e) =>
                {

                    if (!dataCon)
                    {
                        int currentBalance;
                        try
                        {
                            // Wait for other threads to release the semaphore and acquire it for this thread
                            userSemaphore.Wait();

                            // Get the current balance and wait
                            currentBalance = bank.currentUser.balance;
                            Thread.Sleep(500);

                            // Calculate the new balance and wait again
                            currentBalance = currentBalance - withdrawAmount;
                            Thread.Sleep(500);

                            // Update the balance held within the bank system with the new balance
                            bank.currentUser.balance = currentBalance;
                        }
                        finally
                        {
                            // Release the semaphore when we're done
                            userSemaphore.Release();
                        }
                    }
                    else
                    {
                        try
                        {
                            // Wait for other threads to release the semaphore and acquire it for this thread
                            userSemaphore.Wait();

                            // Update the balance held within the bank system with the new balance
                            bank.currentUser.balance -= withdrawAmount;
                        }
                        finally
                        {
                            // Release the semaphore when we're done
                            userSemaphore.Release();
                        }
                    }

                    // display the users new balance
                    BalanceLabel.Text = "Your new balance is: £" + bank.currentUser.balance;
                    BalanceLabel.Location = new Point(80, 145);
                    BalanceLabel.Visible = true;
                    timer1.Stop();

                    // another timer to allow new balance message to stay on screen
                    System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                    timer2.Interval = 2000;
                    timer2.Tick += (object sender, EventArgs e) =>
                    {

                        // return user to options screen
                        BalanceLabel.Visible = false;
                        ScreenOutputTextBox.Visible = true;
                        ScreenOutputTextBox.Text = "Please select the option you'd like to do";
                        Option1Label.Visible = true;
                        Option1Label.Text = "Withdraw";
                        Option2Label.Visible = true;
                        Option2Label.Text = "Check Balance";
                        Option3Label.Visible = true;
                        Option3Label.Text = "Return Card";
                        ScreenTextBox.Visible = false;
                        currentState = "loggedIn";

                        timer2.Stop();
                    };
                    timer2.Start();
                };
                timer1.Start();
            }

            LogMessage("[INFO] £" + withdrawAmount + " withdrawn");

        }

        //method to "dispense" cash from atm by moving image
        private void DispenseCash()
        {

            // make the money image visible and return it to starting location if not there already
            MoneyImage.Visible = true;
            MoneyImage.Location = new Point(743, 351);

            // set the target location, how many steps for it to be done in, and duration for the animation
            int targetY = MoneyImage.Location.Y + 120;
            int steps = 40;
            int duration = 2000;

            // variable for the starting position of the image, and how far to move per step
            int startY = MoneyImage.Location.Y;
            int stepY = (targetY - startY) / steps;

            // create a timer to update the image location for each step
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = duration / steps;
            int stepCount = 0;
            timer.Tick += (object sender, EventArgs e) =>
            {

                // calculate the new Y position for the image and set the new location to that
                int newY = startY + (stepY * stepCount);
                MoneyImage.Location = new Point(MoneyImage.Location.X, newY);

                // increment the step count
                stepCount++;

                // stop the timer when all steps have been done
                if (stepCount >= steps)
                {
                    timer.Stop();

                    // start a second timer to hide the image after a delay
                    System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                    timer2.Interval = 2000;
                    timer2.Tick += (object s, EventArgs evt) =>
                    {

                        // hide the money image
                        MoneyImage.Visible = false;
                        timer2.Stop();
                    };
                    timer2.Start();
                }
            };
            timer.Start();
        }

        // method to simulate the card entering the atm
        // card image gotten from https://www.psdgraphics.com/psd/credit-card-template/
        private void InsertCard()
        {
            // make the bank card image visible and return it to starting location if not there already
            BankCard.Visible = true;
            BankCard.Location = new Point(796, 137);

            // set the target location, how many steps for it to be done in, and duration for the animation
            int targetY = BankCard.Location.Y - 350;
            int steps = 80;
            int duration = 1000;

            // variable for the starting position of the image, and how far to move per step
            int startY = BankCard.Location.Y;
            int stepY = (targetY - startY) / steps;

            // create a timer to update the image location for each step
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = duration / steps;
            int stepCount = 0;
            timer.Tick += (object sender, EventArgs e) =>
            {
                // calculate the new Y position for the image and set the new location to that
                int newY = startY + (stepY * stepCount);
                BankCard.Location = new Point(BankCard.Location.X, newY);

                // increment the step count
                stepCount++;

                // stop the timer when all steps have been done
                if (stepCount >= steps)
                {
                    timer.Stop();

                    // start a second timer to hide the image after a delay
                    System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                    timer2.Interval = 2000;
                    timer2.Tick += (object s, EventArgs evt) =>
                    {
                        // hide the bank card image
                        BankCard.Visible = false;
                        timer2.Stop();
                    };
                    timer2.Start();
                }
            };
            timer.Start();
        }

        // method to simulate card being removed from atm
        private void RemoveCard()
        {
            // make the bank card image visible and return it to starting location if not there already
            BankCard.Visible = true;
            BankCard.Location = new Point(796, -84);

            // set the target location, how many steps for it to be done in, and duration for the animation
            int targetY = BankCard.Location.Y + 210;
            int steps = 80;
            int duration = 1000;

            // variable for the starting position of the image, and how far to move per step
            int startY = BankCard.Location.Y;
            int stepY = (targetY - startY) / steps;

            // create a timer to update the image location for each step
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = duration / steps;
            int stepCount = 0;
            timer.Tick += (object sender, EventArgs e) =>
            {
                // calculate the new Y position for the image and set the new location to that
                int newY = startY + (stepY * stepCount);
                BankCard.Location = new Point(BankCard.Location.X, newY);

                // increment the step count
                stepCount++;

                // stop the timer when all steps have been done
                if (stepCount >= steps)
                {
                    timer.Stop();

                    // start a second timer to hide the image after a delay
                    System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                    timer2.Interval = 2000;
                    timer2.Tick += (object s, EventArgs evt) =>
                    {
                        // hide the bank card image
                        BankCard.Visible = false;
                        timer2.Stop();
                    };
                    timer2.Start();
                }
            };
            timer.Start();
        }

        public void LogMessage(string message)
        {
            textBox.AppendText(message + Environment.NewLine);
        }

    }


}


