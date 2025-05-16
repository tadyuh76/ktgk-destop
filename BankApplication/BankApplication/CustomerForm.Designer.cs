namespace BankApplication
{
    partial class CustomerForm
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

        private ListBox lstCustomers;
        private Button btnAddCustomer;

        private void InitializeComponent()
        {
            lstCustomers = new ListBox { Left = 10, Top = 10, Width = 200, Height = 150 };
            btnAddCustomer = new Button { Text = "Add Customer", Left = 10, Top = 170, Width = 200 };

            Controls.Add(lstCustomers);
            Controls.Add(btnAddCustomer);

            Text = "Customers";
            Width = 240;
            Height = 250;
        }
    }
}