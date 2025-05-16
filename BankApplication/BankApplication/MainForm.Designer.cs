namespace BankApplication
{
    partial class MainForm
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

        private Button btnCustomers;
        private Button btnAccounts;
        private Button btnTransactions;

        private void InitializeComponent()
        {
            btnCustomers = new Button { Text = "Customers", Left = 30, Top = 30, Width = 120 };
            btnAccounts = new Button { Text = "Accounts", Left = 30, Top = 70, Width = 120 };
            btnTransactions = new Button { Text = "Transactions", Left = 30, Top = 110, Width = 120 };

            btnCustomers.Click += btnCustomers_Click;
            btnAccounts.Click += btnAccounts_Click;
            btnTransactions.Click += btnTransactions_Click;

            Controls.Add(btnCustomers);
            Controls.Add(btnAccounts);
            Controls.Add(btnTransactions);

            Text = "Bank Application";
            Width = 200;
            Height = 200;
        }
    }
}