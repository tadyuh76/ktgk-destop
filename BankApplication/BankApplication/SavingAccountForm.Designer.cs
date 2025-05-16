namespace BankApplication
{
    partial class SavingAccountForm
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

        private ListBox lstAccounts;
        private Button btnAddAccount;

        private void InitializeComponent()
        {
            lstAccounts = new ListBox { Left = 10, Top = 10, Width = 200, Height = 150 };
            btnAddAccount = new Button { Text = "Add Account", Left = 10, Top = 170, Width = 200 };

            Controls.Add(lstAccounts);
            Controls.Add(btnAddAccount);

            Text = "Saving Accounts";
            Width = 240;
            Height = 250;
        }
    }
}