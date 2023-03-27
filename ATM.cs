using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Transactions;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class ATM : Form
    {
        private Bank bank;
        string currentState;
        int accntNumber;
        int withdrawAmount;

        public ATM(Bank bank)
        {
            InitializeComponent();

            this.bank = bank;
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

                    // if the user hasn't entered a 6-digit number
                    if (ScreenTextBox.Text.Length != 6)
                    {

                        // have a popup to signify error
                        MessageBox.Show("ERROR: lease enter a 6-digit account number");
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        return;
                    }

                    int accntNum = Convert.ToInt32(ScreenTextBox.Text);

                    if (bank.AccountExists(accntNum))
                    {

                        // put this entered account number into a variable for later
                        accntNumber = accntNum;
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        ScreenOutputTextBox.Text = "Please enter your pin number";

                        // change the state to pin login
                        currentState = "pinLogin";
                    }
                    break;

                // case where atm wants pin number
                case "pinLogin":
                    if (ScreenTextBox.Text.Length != 4)
                    {
                        MessageBox.Show("Please enter a 4-digit pin number");
                        ScreenTextBox.Text = "";
                        ScreenTextBox.Focus();
                        return;
                    }

                    int pinNum = Convert.ToInt32(ScreenTextBox.Text);

                    if (bank.CheckPin(accntNumber, pinNum))
                    {
                        ScreenOutputTextBox.Text = "Please select the option you'd like to do";
                        Option1Label.Visible = true;
                        Option2Label.Visible = true;
                        Option3Label.Visible = true;
                        ScreenTextBox.Visible = false;
                        currentState = "loggedIn";
                    }
                    break;

                case "loggedIn":

                    break;

                case "customAmount":

                    int withdrawAmount = Convert.ToInt32(ScreenTextBox.Text);

                    WithdrawingLogic(withdrawAmount);


                    break;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ScreenTextBox.Text = "";
            ScreenTextBox.Select(ScreenTextBox.Text.Length, 0);
            ScreenTextBox.Focus();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("withdrawing"):

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

                case ("customAmount"):

                    ScreenOutputTextBox.Text = "How much would you like to withdraw?";
                    Option1Label.Text = "£500";
                    Option2Label.Text = "£250";
                    Option3Label.Text = "£100";
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

        private void Num1Button_Click(object sender, EventArgs e)
        {
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

        private void Option1Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("loggedIn"):

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

                    WithdrawingLogic(500);

                    break;
            }
        }

        private void Option2Button_Click(object sender, EventArgs e)
        {
            switch (currentState)
            {
                case ("loggedIn"):

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

                    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                    timer.Interval = 2000;
                    timer.Tick += (object sender, EventArgs e) =>
                    {

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

        private void WithdrawingLogic(int withdrawalAmount)
        {


            withdrawAmount = withdrawalAmount;

            if (withdrawAmount > bank.currentUser.balance)
            {
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

                // using a timer to pause execution of the next lines of code
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

                

                System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
                timer1.Interval = 2000;
                timer1.Tick += (object sender, EventArgs e) =>
                {

                    int tempBalance = bank.currentUser.balance;
                    Thread.Sleep(500);

                    //reduce amount from temporary balance and wait
                    tempBalance = tempBalance - withdrawAmount;
                    Thread.Sleep(500);

                    bank.currentUser.balance = tempBalance;

                    BalanceLabel.Text = "Your new balance is: £" + bank.currentUser.balance;
                    BalanceLabel.Location = new Point(80, 145);
                    BalanceLabel.Visible = true;
                    timer1.Stop();

                    System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
                    timer2.Interval = 2000;
                    timer2.Tick += (object sender, EventArgs e) =>
                    {
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
        }

        private void DispenseCash()
        {
            int targetY = MoneyImage.Location.Y + 120; // the target Y position after moving down by 100 pixels
            int steps = 40; // the number of steps to take to reach the target position
            int duration = 2000; // the duration in milliseconds of the animation

            int startY = MoneyImage.Location.Y;
            int deltaY = (targetY - startY) / steps;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = duration / steps;
            int stepCount = 0;
            timer.Tick += (object sender, EventArgs e) =>
            {
                int newY = startY + (deltaY * stepCount);
                MoneyImage.Location = new Point(MoneyImage.Location.X, newY);

                stepCount++;
                if (stepCount >= steps)
                {
                    timer.Stop();
                    // Start a second timer to hide the image after a delay
                    System.Windows.Forms.Timer hideTimer = new System.Windows.Forms.Timer();
                    hideTimer.Interval = 2000;
                    hideTimer.Tick += (object s, EventArgs evt) =>
                    {
                        MoneyImage.Visible = false;
                        hideTimer.Stop();
                    };
                    hideTimer.Start();
                }
            };
            timer.Start();
        }

    }
}

