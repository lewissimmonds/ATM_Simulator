using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ATM_Simulator
{
    public partial class CentralBankForm : Form
    {
        Bank bank;
        bool dataCon = false;

        public CentralBankForm(Bank bank)
        {
            this.bank = bank;
            InitializeComponent();

            int windowWidth = 700;
            int windowHeight = 600;

            //Locks window to windowWidth by windowHeight
            this.MaximumSize = new Size(windowWidth, windowHeight);
            this.MinimumSize = new Size(windowWidth, windowHeight);


            //Set the details table to be based of the accounts array
            AccountDetailsTable.DataSource = bank.accounts;

            //Sets the headers to be proper names rather than var names
            AccountDetailsTable.Columns[0].HeaderText = "Account Number";
            AccountDetailsTable.Columns[1].HeaderText = "PIN";
            AccountDetailsTable.Columns[2].HeaderText = "Balance";

            //Centre details table
            int cornerW = (this.ClientSize.Width - AccountDetailsTable.Width) / 2;
            int cornerH = ((this.ClientSize.Height - AccountDetailsTable.Height) / 2)-100;
            AccountDetailsTable.Location = new Point(cornerW, cornerH);


            //Change Title properties
            TitleLabel.Text = "Bank of Dundee Computing";
            TitleLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            TitleLabel.ForeColor = Color.DarkBlue;

            //Centre title
            TitleLabel.Location = new Point(this.ClientSize.Width/2-(TitleLabel.Width/2), 10);


            //Centre button
            int tableBottomPoint = cornerH + AccountDetailsTable.Height + 5;
            btnShowATMs.Location = new Point(this.ClientSize.Width / 2 - (btnShowATMs.Width / 2), tableBottomPoint);


            //Set checkbox location
            checkBoxDataConcurrency.Location = new Point(cornerW, tableBottomPoint + 3);


            //Centre Logbox
            int logboxW = (this.ClientSize.Width - LogTextBox.Width) / 2;
            int logboxH = ((this.ClientSize.Height - LogTextBox.Height) / 2) + 160;
            LogTextBox.Location = new Point(logboxW, logboxH);

            LogMessage("[INFO] Started central bank system");

        }

        public void LogMessage(string message)
        {
            LogTextBox.AppendText(message + Environment.NewLine);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CentralBankForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (dataCon == false)
            {
                dataCon = true;
            }
            else
            {
                dataCon= false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowATMs_Click(object sender, EventArgs e)
        {
            LogMessage("[INFO] Starting ATMs");

            Thread Atm0 = new Thread(() => Application.Run(new ATM(bank, dataCon, LogTextBox)));
            Thread Atm1 = new Thread(() => Application.Run(new ATM(bank, dataCon, LogTextBox)));

            Atm0.Start();
            Atm1.Start();
        }
    }
}
