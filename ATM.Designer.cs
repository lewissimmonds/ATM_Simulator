namespace ATM_Simulator
{
    partial class ATM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginPanel = new Panel();
            loginButton = new Button();
            enterInfoLabel = new Label();
            pinLabel = new Label();
            accNumLabel = new Label();
            pinTxtBox = new TextBox();
            accNumTxtBox = new TextBox();
            loginPanelLabel = new Label();
            accntScreenPanel = new Panel();
            returnCardButton = new Button();
            checkBalanceButton = new Button();
            withdrawButton = new Button();
            balancePanel = new Panel();
            balanceReturnButton = new Button();
            balanceLabel = new Label();
            loginPanel.SuspendLayout();
            accntScreenPanel.SuspendLayout();
            balancePanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(enterInfoLabel);
            loginPanel.Controls.Add(pinLabel);
            loginPanel.Controls.Add(accNumLabel);
            loginPanel.Controls.Add(pinTxtBox);
            loginPanel.Controls.Add(accNumTxtBox);
            loginPanel.Controls.Add(loginPanelLabel);
            loginPanel.Controls.Add(accntScreenPanel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(800, 450);
            loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(332, 367);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(119, 40);
            loginButton.TabIndex = 6;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // enterInfoLabel
            // 
            enterInfoLabel.AutoSize = true;
            enterInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterInfoLabel.Location = new Point(318, 155);
            enterInfoLabel.Name = "enterInfoLabel";
            enterInfoLabel.Size = new Size(133, 21);
            enterInfoLabel.TabIndex = 5;
            enterInfoLabel.Text = "Please enter your:";
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(238, 291);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(27, 15);
            pinLabel.TabIndex = 4;
            pinLabel.Text = "Pin:";
            // 
            // accNumLabel
            // 
            accNumLabel.AutoSize = true;
            accNumLabel.Location = new Point(163, 229);
            accNumLabel.Name = "accNumLabel";
            accNumLabel.Size = new Size(102, 15);
            accNumLabel.TabIndex = 3;
            accNumLabel.Text = "Account Number:";
            // 
            // pinTxtBox
            // 
            pinTxtBox.Location = new Point(283, 288);
            pinTxtBox.Name = "pinTxtBox";
            pinTxtBox.Size = new Size(298, 23);
            pinTxtBox.TabIndex = 2;
            pinTxtBox.KeyPress += pinTxtBox_KeyPress;
            // 
            // accNumTxtBox
            // 
            accNumTxtBox.Location = new Point(283, 226);
            accNumTxtBox.Name = "accNumTxtBox";
            accNumTxtBox.Size = new Size(298, 23);
            accNumTxtBox.TabIndex = 1;
            accNumTxtBox.KeyPress += accNumTxtBox_KeyPress;
            // 
            // loginPanelLabel
            // 
            loginPanelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginPanelLabel.AutoSize = true;
            loginPanelLabel.Font = new Font("Russo One", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            loginPanelLabel.Location = new Point(301, 38);
            loginPanelLabel.Name = "loginPanelLabel";
            loginPanelLabel.Size = new Size(172, 77);
            loginPanelLabel.TabIndex = 0;
            loginPanelLabel.Text = "ATM";
            // 
            // accntScreenPanel
            // 
            accntScreenPanel.Controls.Add(returnCardButton);
            accntScreenPanel.Controls.Add(checkBalanceButton);
            accntScreenPanel.Controls.Add(withdrawButton);
            accntScreenPanel.Controls.Add(balancePanel);
            accntScreenPanel.Dock = DockStyle.Fill;
            accntScreenPanel.Location = new Point(0, 0);
            accntScreenPanel.Name = "accntScreenPanel";
            accntScreenPanel.Size = new Size(800, 450);
            accntScreenPanel.TabIndex = 1;
            // 
            // returnCardButton
            // 
            returnCardButton.Location = new Point(332, 326);
            returnCardButton.Name = "returnCardButton";
            returnCardButton.Size = new Size(119, 57);
            returnCardButton.TabIndex = 2;
            returnCardButton.Text = "Return Card";
            returnCardButton.UseVisualStyleBackColor = true;
            // 
            // checkBalanceButton
            // 
            checkBalanceButton.Location = new Point(332, 206);
            checkBalanceButton.Name = "checkBalanceButton";
            checkBalanceButton.Size = new Size(119, 61);
            checkBalanceButton.TabIndex = 1;
            checkBalanceButton.Text = "Check Balance";
            checkBalanceButton.UseVisualStyleBackColor = true;
            checkBalanceButton.Click += checkBalanceButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(332, 81);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(119, 58);
            withdrawButton.TabIndex = 0;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            // 
            // balancePanel
            // 
            balancePanel.Controls.Add(balanceReturnButton);
            balancePanel.Controls.Add(balanceLabel);
            balancePanel.Dock = DockStyle.Fill;
            balancePanel.Location = new Point(0, 0);
            balancePanel.Name = "balancePanel";
            balancePanel.Size = new Size(800, 450);
            balancePanel.TabIndex = 3;
            // 
            // balanceReturnButton
            // 
            balanceReturnButton.Location = new Point(27, 28);
            balanceReturnButton.Name = "balanceReturnButton";
            balanceReturnButton.Size = new Size(75, 23);
            balanceReturnButton.TabIndex = 1;
            balanceReturnButton.Text = "Return";
            balanceReturnButton.UseVisualStyleBackColor = true;
            balanceReturnButton.Click += balanceReturnButton_Click;
            // 
            // balanceLabel
            // 
            balanceLabel.Dock = DockStyle.Fill;
            balanceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            balanceLabel.Location = new Point(0, 0);
            balanceLabel.Name = "balanceLabel";
            balanceLabel.Size = new Size(800, 450);
            balanceLabel.TabIndex = 0;
            balanceLabel.Text = "label1";
            balanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanel);
            Name = "ATM";
            Text = "Form1";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            accntScreenPanel.ResumeLayout(false);
            balancePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Label loginPanelLabel;
        private Label enterInfoLabel;
        private Label pinLabel;
        private Label accNumLabel;
        private TextBox pinTxtBox;
        private TextBox accNumTxtBox;
        private Button loginButton;
        private Panel accntScreenPanel;
        private Button returnCardButton;
        private Button checkBalanceButton;
        private Button withdrawButton;
        private Panel balancePanel;
        private Button balanceReturnButton;
        private Label balanceLabel;
    }
}