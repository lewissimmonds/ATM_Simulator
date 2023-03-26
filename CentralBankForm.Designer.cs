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
            this.AccountDetailsTable = new System.Windows.Forms.DataGridView();
            this.BankTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.checkBoxDataConcurrency = new System.Windows.Forms.CheckBox();
            this.btnShowATMs = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDetailsTable
            // 
            this.AccountDetailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDetailsTable.Location = new System.Drawing.Point(70, 86);
            this.AccountDetailsTable.Name = "AccountDetailsTable";
            this.AccountDetailsTable.RowTemplate.Height = 25;
            this.AccountDetailsTable.Size = new System.Drawing.Size(535, 207);
            this.AccountDetailsTable.TabIndex = 0;
            this.AccountDetailsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BankTitle
            // 
            this.BankTitle.AutoSize = true;
            this.BankTitle.Location = new System.Drawing.Point(223, 57);
            this.BankTitle.Name = "BankTitle";
            this.BankTitle.Size = new System.Drawing.Size(0, 15);
            this.BankTitle.TabIndex = 1;
            this.BankTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 2;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(322, 37);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(57, 15);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "TitleLabel";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TitleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBoxDataConcurrency
            // 
            this.checkBoxDataConcurrency.AutoSize = true;
            this.checkBoxDataConcurrency.Location = new System.Drawing.Point(70, 301);
            this.checkBoxDataConcurrency.Name = "checkBoxDataConcurrency";
            this.checkBoxDataConcurrency.Size = new System.Drawing.Size(121, 19);
            this.checkBoxDataConcurrency.TabIndex = 4;
            this.checkBoxDataConcurrency.Text = "Data Concurrency";
            this.checkBoxDataConcurrency.UseVisualStyleBackColor = true;
            this.checkBoxDataConcurrency.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnShowATMs
            // 
            this.btnShowATMs.Location = new System.Drawing.Point(290, 299);
            this.btnShowATMs.Name = "btnShowATMs";
            this.btnShowATMs.Size = new System.Drawing.Size(100, 21);
            this.btnShowATMs.TabIndex = 5;
            this.btnShowATMs.Text = "Show ATMs";
            this.btnShowATMs.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogTextBox.Location = new System.Drawing.Point(70, 341);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.Size = new System.Drawing.Size(535, 208);
            this.LogTextBox.TabIndex = 6;
            this.LogTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CentralBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.btnShowATMs);
            this.Controls.Add(this.checkBoxDataConcurrency);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BankTitle);
            this.Controls.Add(this.AccountDetailsTable);
            this.Name = "CentralBankForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CentralBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView AccountDetailsTable;
        private Label BankTitle;
        private Label label1;
        private Label TitleLabel;
        private CheckBox checkBox1;
        private Button btnShowATMs;
        private CheckBox checkBoxDataConcurrency;
        private TextBox LogTextBox;
    }
}