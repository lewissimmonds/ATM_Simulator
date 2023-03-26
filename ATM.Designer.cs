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
            LoginPanel = new Panel();
            LoginButton = new Button();
            EnterInfoLabel = new Label();
            PinLabel = new Label();
            AccNumLabel = new Label();
            PinTxtBox = new TextBox();
            AccNumTxtBox = new TextBox();
            LoginPanelLabel = new Label();
            AccntScreenPanel = new Panel();
            ReturnCardButton = new Button();
            CheckBalanceButton = new Button();
            WithdrawButton = new Button();
            WithdrawPanel = new Panel();
            ConfirmWithdrawButton = new Button();
            WithdrawTxtBox = new TextBox();
            WithdrawBalanceLabel = new Label();
            WithdrawQLabel = new Label();
            WithdrawReturnButton = new Button();
            BalancePanel = new Panel();
            BalanceReturnButton = new Button();
            BalanceLabel = new Label();
            LoginPanel.SuspendLayout();
            AccntScreenPanel.SuspendLayout();
            WithdrawPanel.SuspendLayout();
            BalancePanel.SuspendLayout();
            SuspendLayout();
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(LoginButton);
            LoginPanel.Controls.Add(EnterInfoLabel);
            LoginPanel.Controls.Add(PinLabel);
            LoginPanel.Controls.Add(AccNumLabel);
            LoginPanel.Controls.Add(PinTxtBox);
            LoginPanel.Controls.Add(AccNumTxtBox);
            LoginPanel.Controls.Add(LoginPanelLabel);
            LoginPanel.Controls.Add(AccntScreenPanel);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(800, 450);
            LoginPanel.TabIndex = 0;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(332, 367);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(119, 40);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "LOGIN";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // EnterInfoLabel
            // 
            EnterInfoLabel.AutoSize = true;
            EnterInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnterInfoLabel.Location = new Point(318, 155);
            EnterInfoLabel.Name = "EnterInfoLabel";
            EnterInfoLabel.Size = new Size(133, 21);
            EnterInfoLabel.TabIndex = 5;
            EnterInfoLabel.Text = "Please enter your:";
            // 
            // PinLabel
            // 
            PinLabel.AutoSize = true;
            PinLabel.Location = new Point(238, 291);
            PinLabel.Name = "PinLabel";
            PinLabel.Size = new Size(27, 15);
            PinLabel.TabIndex = 4;
            PinLabel.Text = "Pin:";
            // 
            // AccNumLabel
            // 
            AccNumLabel.AutoSize = true;
            AccNumLabel.Location = new Point(163, 229);
            AccNumLabel.Name = "AccNumLabel";
            AccNumLabel.Size = new Size(102, 15);
            AccNumLabel.TabIndex = 3;
            AccNumLabel.Text = "Account Number:";
            // 
            // PinTxtBox
            // 
            PinTxtBox.Location = new Point(283, 288);
            PinTxtBox.Name = "PinTxtBox";
            PinTxtBox.Size = new Size(298, 23);
            PinTxtBox.TabIndex = 2;
            PinTxtBox.KeyPress += PinTxtBox_KeyPress;
            // 
            // AccNumTxtBox
            // 
            AccNumTxtBox.Location = new Point(283, 226);
            AccNumTxtBox.Name = "AccNumTxtBox";
            AccNumTxtBox.Size = new Size(298, 23);
            AccNumTxtBox.TabIndex = 1;
            AccNumTxtBox.KeyPress += AccNumTxtBox_KeyPress;
            // 
            // LoginPanelLabel
            // 
            LoginPanelLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            LoginPanelLabel.AutoSize = true;
            LoginPanelLabel.Font = new Font("Russo One", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            LoginPanelLabel.Location = new Point(301, 38);
            LoginPanelLabel.Name = "LoginPanelLabel";
            LoginPanelLabel.Size = new Size(172, 77);
            LoginPanelLabel.TabIndex = 0;
            LoginPanelLabel.Text = "ATM";
            // 
            // AccntScreenPanel
            // 
            AccntScreenPanel.Controls.Add(ReturnCardButton);
            AccntScreenPanel.Controls.Add(CheckBalanceButton);
            AccntScreenPanel.Controls.Add(WithdrawButton);
            AccntScreenPanel.Controls.Add(WithdrawPanel);
            AccntScreenPanel.Controls.Add(BalancePanel);
            AccntScreenPanel.Dock = DockStyle.Fill;
            AccntScreenPanel.Location = new Point(0, 0);
            AccntScreenPanel.Name = "AccntScreenPanel";
            AccntScreenPanel.Size = new Size(800, 450);
            AccntScreenPanel.TabIndex = 1;
            // 
            // ReturnCardButton
            // 
            ReturnCardButton.Location = new Point(332, 326);
            ReturnCardButton.Name = "ReturnCardButton";
            ReturnCardButton.Size = new Size(119, 57);
            ReturnCardButton.TabIndex = 2;
            ReturnCardButton.Text = "Return Card";
            ReturnCardButton.UseVisualStyleBackColor = true;
            ReturnCardButton.Click += ReturnCardButton_Click;
            // 
            // CheckBalanceButton
            // 
            CheckBalanceButton.Location = new Point(332, 206);
            CheckBalanceButton.Name = "CheckBalanceButton";
            CheckBalanceButton.Size = new Size(119, 61);
            CheckBalanceButton.TabIndex = 1;
            CheckBalanceButton.Text = "Check Balance";
            CheckBalanceButton.UseVisualStyleBackColor = true;
            CheckBalanceButton.Click += CheckBalanceButton_Click;
            // 
            // WithdrawButton
            // 
            WithdrawButton.Location = new Point(332, 81);
            WithdrawButton.Name = "WithdrawButton";
            WithdrawButton.Size = new Size(119, 58);
            WithdrawButton.TabIndex = 0;
            WithdrawButton.Text = "Withdraw";
            WithdrawButton.UseVisualStyleBackColor = true;
            WithdrawButton.Click += WithdrawButton_Click;
            // 
            // WithdrawPanel
            // 
            WithdrawPanel.Controls.Add(ConfirmWithdrawButton);
            WithdrawPanel.Controls.Add(WithdrawTxtBox);
            WithdrawPanel.Controls.Add(WithdrawBalanceLabel);
            WithdrawPanel.Controls.Add(WithdrawQLabel);
            WithdrawPanel.Controls.Add(WithdrawReturnButton);
            WithdrawPanel.Dock = DockStyle.Fill;
            WithdrawPanel.Location = new Point(0, 0);
            WithdrawPanel.Name = "WithdrawPanel";
            WithdrawPanel.Size = new Size(800, 450);
            WithdrawPanel.TabIndex = 2;
            // 
            // ConfirmWithdrawButton
            // 
            ConfirmWithdrawButton.Location = new Point(341, 338);
            ConfirmWithdrawButton.Name = "ConfirmWithdrawButton";
            ConfirmWithdrawButton.Size = new Size(100, 23);
            ConfirmWithdrawButton.TabIndex = 4;
            ConfirmWithdrawButton.Text = "Withdraw";
            ConfirmWithdrawButton.UseVisualStyleBackColor = true;
            ConfirmWithdrawButton.Click += ConfirmWithdrawButton_Click;
            // 
            // WithdrawTxtBox
            // 
            WithdrawTxtBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawTxtBox.Location = new Point(341, 221);
            WithdrawTxtBox.Name = "WithdrawTxtBox";
            WithdrawTxtBox.Size = new Size(100, 33);
            WithdrawTxtBox.TabIndex = 3;
            WithdrawTxtBox.TextAlign = HorizontalAlignment.Center;
            // 
            // WithdrawBalanceLabel
            // 
            WithdrawBalanceLabel.AutoSize = true;
            WithdrawBalanceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawBalanceLabel.Location = new Point(320, 48);
            WithdrawBalanceLabel.Name = "WithdrawBalanceLabel";
            WithdrawBalanceLabel.Size = new Size(52, 21);
            WithdrawBalanceLabel.TabIndex = 2;
            WithdrawBalanceLabel.Text = "label1";
            WithdrawBalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WithdrawQLabel
            // 
            WithdrawQLabel.AutoSize = true;
            WithdrawQLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WithdrawQLabel.Location = new Point(207, 142);
            WithdrawQLabel.Name = "WithdrawQLabel";
            WithdrawQLabel.Size = new Size(390, 25);
            WithdrawQLabel.TabIndex = 1;
            WithdrawQLabel.Text = "Enter the amount you would like to withdraw";
            WithdrawQLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // WithdrawReturnButton
            // 
            WithdrawReturnButton.Location = new Point(26, 27);
            WithdrawReturnButton.Name = "WithdrawReturnButton";
            WithdrawReturnButton.Size = new Size(75, 23);
            WithdrawReturnButton.TabIndex = 0;
            WithdrawReturnButton.Text = "Return";
            WithdrawReturnButton.UseVisualStyleBackColor = true;
            WithdrawReturnButton.Click += WithdrawReturnButton_Click;
            // 
            // BalancePanel
            // 
            BalancePanel.Controls.Add(BalanceReturnButton);
            BalancePanel.Controls.Add(BalanceLabel);
            BalancePanel.Dock = DockStyle.Fill;
            BalancePanel.Location = new Point(0, 0);
            BalancePanel.Name = "BalancePanel";
            BalancePanel.Size = new Size(800, 450);
            BalancePanel.TabIndex = 3;
            // 
            // BalanceReturnButton
            // 
            BalanceReturnButton.Location = new Point(27, 28);
            BalanceReturnButton.Name = "BalanceReturnButton";
            BalanceReturnButton.Size = new Size(75, 23);
            BalanceReturnButton.TabIndex = 1;
            BalanceReturnButton.Text = "Return";
            BalanceReturnButton.UseVisualStyleBackColor = true;
            BalanceReturnButton.Click += BalanceReturnButton_Click;
            // 
            // BalanceLabel
            // 
            BalanceLabel.Dock = DockStyle.Fill;
            BalanceLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BalanceLabel.Location = new Point(0, 0);
            BalanceLabel.Name = "BalanceLabel";
            BalanceLabel.Size = new Size(800, 450);
            BalanceLabel.TabIndex = 0;
            BalanceLabel.Text = "label1";
            BalanceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            Name = "ATM";
            Text = "ATM";
            LoginPanel.ResumeLayout(false);
            LoginPanel.PerformLayout();
            AccntScreenPanel.ResumeLayout(false);
            WithdrawPanel.ResumeLayout(false);
            WithdrawPanel.PerformLayout();
            BalancePanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginPanel;
        private Label LoginPanelLabel;
        private Label EnterInfoLabel;
        private Label PinLabel;
        private Label AccNumLabel;
        private TextBox PinTxtBox;
        private TextBox AccNumTxtBox;
        private Button LoginButton;
        private Panel AccntScreenPanel;
        private Button ReturnCardButton;
        private Button CheckBalanceButton;
        private Button WithdrawButton;
        private Panel BalancePanel;
        private Button BalanceReturnButton;
        private Label BalanceLabel;
        private Panel WithdrawPanel;
        private Button WithdrawReturnButton;
        private Label WithdrawQLabel;
        private Button ConfirmWithdrawButton;
        private TextBox WithdrawTxtBox;
        private Label WithdrawBalanceLabel;
    }
}