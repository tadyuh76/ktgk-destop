namespace BankApplication
{
    partial class TransactionForm
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

        private ComboBox cmbAccounts;
        private TextBox txtAmount;
        private Button btnDeposit;
        private Button btnWithdraw;

        private void InitializeComponent()
        {
            cmbAccounts = new ComboBox { Left = 10, Top = 10, Width = 200 };
            txtAmount = new TextBox { Left = 10, Top = 50, Width = 200 };
            btnDeposit = new Button { Text = "Deposit", Left = 10, Top = 90, Width = 95 };
            btnWithdraw = new Button { Text = "Withdraw", Left = 115, Top = 90, Width = 95 };

            Controls.Add(cmbAccounts);
            Controls.Add(txtAmount);
            Controls.Add(btnDeposit);
            Controls.Add(btnWithdraw);

            Text = "Transactions";
            Width = 240;
            Height = 170;
        }
    }
}