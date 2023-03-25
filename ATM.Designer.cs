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
            enterInfoLabel = new Label();
            pinLabel = new Label();
            accNumLabel = new Label();
            pinTxtBox = new TextBox();
            accNumTxtBox = new TextBox();
            loginPanelLabel = new Label();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(enterInfoLabel);
            loginPanel.Controls.Add(pinLabel);
            loginPanel.Controls.Add(accNumLabel);
            loginPanel.Controls.Add(pinTxtBox);
            loginPanel.Controls.Add(accNumTxtBox);
            loginPanel.Controls.Add(loginPanelLabel);
            loginPanel.Dock = DockStyle.Fill;
            loginPanel.Location = new Point(0, 0);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(800, 450);
            loginPanel.TabIndex = 0;
            // 
            // enterInfoLabel
            // 
            enterInfoLabel.AutoSize = true;
            enterInfoLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            enterInfoLabel.Location = new Point(318, 176);
            enterInfoLabel.Name = "enterInfoLabel";
            enterInfoLabel.Size = new Size(133, 21);
            enterInfoLabel.TabIndex = 5;
            enterInfoLabel.Text = "Please enter your:";
            // 
            // pinLabel
            // 
            pinLabel.AutoSize = true;
            pinLabel.Location = new Point(243, 334);
            pinLabel.Name = "pinLabel";
            pinLabel.Size = new Size(27, 15);
            pinLabel.TabIndex = 4;
            pinLabel.Text = "Pin:";
            // 
            // accNumLabel
            // 
            accNumLabel.AutoSize = true;
            accNumLabel.Location = new Point(168, 272);
            accNumLabel.Name = "accNumLabel";
            accNumLabel.Size = new Size(102, 15);
            accNumLabel.TabIndex = 3;
            accNumLabel.Text = "Account Number:";
            // 
            // pinTxtBox
            // 
            pinTxtBox.Location = new Point(288, 331);
            pinTxtBox.Name = "pinTxtBox";
            pinTxtBox.Size = new Size(298, 23);
            pinTxtBox.TabIndex = 2;
            pinTxtBox.KeyPress += pinTxtBox_KeyPress;
            // 
            // accNumTxtBox
            // 
            accNumTxtBox.Location = new Point(288, 269);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(loginPanel);
            Name = "Form1";
            Text = "Form1";
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
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
    }
}