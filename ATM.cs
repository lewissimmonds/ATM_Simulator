namespace ATM_Simulator
{
    public partial class ATM : Form
    {
        public ATM()
        {
            InitializeComponent();
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


    }
}