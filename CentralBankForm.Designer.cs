namespace ATM_Simulator
{
    partial class CentralBankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CentralBankForm));
            AccountDetailsTable = new DataGridView();
            BankTitle = new Label();
            label1 = new Label();
            TitleLabel = new Label();
            checkBoxDataConcurrency = new CheckBox();
            btnShowATMs = new Button();
            LogTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)AccountDetailsTable).BeginInit();
            SuspendLayout();
            // 
            // AccountDetailsTable
            // 
            AccountDetailsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AccountDetailsTable.BackgroundColor = Color.FromArgb(11, 0, 68);
            AccountDetailsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AccountDetailsTable.GridColor = Color.Black;
            AccountDetailsTable.Location = new Point(70, 86);
            AccountDetailsTable.Name = "AccountDetailsTable";
            AccountDetailsTable.ReadOnly = true;
            AccountDetailsTable.RowHeadersVisible = false;
            AccountDetailsTable.RowTemplate.Height = 25;
            AccountDetailsTable.Size = new Size(535, 207);
            AccountDetailsTable.TabIndex = 0;
            AccountDetailsTable.TabStop = false;
            AccountDetailsTable.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BankTitle
            // 
            BankTitle.AutoSize = true;
            BankTitle.Location = new Point(223, 57);
            BankTitle.Name = "BankTitle";
            BankTitle.Size = new Size(0, 15);
            BankTitle.TabIndex = 1;
            BankTitle.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 68);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.ForeColor = Color.FromArgb(11, 0, 68);
            TitleLabel.Location = new Point(322, 37);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(57, 15);
            TitleLabel.TabIndex = 3;
            TitleLabel.Text = "TitleLabel";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.Click += label2_Click;
            // 
            // checkBoxDataConcurrency
            // 
            checkBoxDataConcurrency.AutoSize = true;
            checkBoxDataConcurrency.Location = new Point(70, 301);
            checkBoxDataConcurrency.Name = "checkBoxDataConcurrency";
            checkBoxDataConcurrency.Size = new Size(121, 19);
            checkBoxDataConcurrency.TabIndex = 4;
            checkBoxDataConcurrency.Text = "Data Concurrency";
            checkBoxDataConcurrency.UseVisualStyleBackColor = true;
            checkBoxDataConcurrency.Click += checkBoxDataConcurrency_Click;
            // 
            // btnShowATMs
            // 
            btnShowATMs.Location = new Point(290, 299);
            btnShowATMs.Name = "btnShowATMs";
            btnShowATMs.Size = new Size(100, 21);
            btnShowATMs.TabIndex = 5;
            btnShowATMs.Text = "Show ATMs";
            btnShowATMs.UseVisualStyleBackColor = true;
            btnShowATMs.Click += btnShowATMs_Click;
            // 
            // LogTextBox
            // 
            LogTextBox.BackColor = Color.FromArgb(11, 0, 68);
            LogTextBox.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            LogTextBox.ForeColor = Color.White;
            LogTextBox.Location = new Point(70, 341);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ReadOnly = true;
            LogTextBox.Size = new Size(535, 208);
            LogTextBox.TabIndex = 6;
            LogTextBox.TextChanged += textBox1_TextChanged;
            // 
            // CentralBankForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(684, 561);
            Controls.Add(LogTextBox);
            Controls.Add(btnShowATMs);
            Controls.Add(checkBoxDataConcurrency);
            Controls.Add(TitleLabel);
            Controls.Add(label1);
            Controls.Add(BankTitle);
            Controls.Add(AccountDetailsTable);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CentralBankForm";
            Text = "Dundee Computing Central Bank";
            Load += CentralBankForm_Load;
            ((System.ComponentModel.ISupportInitialize)AccountDetailsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView AccountDetailsTable;
        private Label BankTitle;
        private Label label1;
        private Label TitleLabel;
        private Button btnShowATMs;
        private CheckBox checkBoxDataConcurrency;
        private TextBox LogTextBox;
    }
}