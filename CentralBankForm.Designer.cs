﻿namespace ATM_Simulator
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
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDetailsTable
            // 
            this.AccountDetailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDetailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountDetailsTable.Location = new System.Drawing.Point(0, 144);
            this.AccountDetailsTable.Name = "AccountDetailsTable";
            this.AccountDetailsTable.RowTemplate.Height = 25;
            this.AccountDetailsTable.Size = new System.Drawing.Size(794, 304);
            this.AccountDetailsTable.TabIndex = 0;
            this.AccountDetailsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CentralBankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 596);
            this.Controls.Add(this.AccountDetailsTable);
            this.Name = "CentralBankForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CentralBankForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDetailsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView AccountDetailsTable;
    }
}