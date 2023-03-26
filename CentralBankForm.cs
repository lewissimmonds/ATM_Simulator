using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_Simulator
{
    public partial class CentralBankForm : Form
    {
        
        public CentralBankForm(Bank bank)
        {
            InitializeComponent();

            AccountDetailsTable.DataSource = bank.accounts;
            AccountDetailsTable.Columns[0].HeaderText = "Account Number";
            AccountDetailsTable.Columns[1].HeaderText = "PIN";
            AccountDetailsTable.Columns[2].HeaderText = "Balance";

            

            // Set the Anchor property of the DataGridView
            AccountDetailsTable.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CentralBankForm_Load(object sender, EventArgs e)
        {

        }
    }
}
