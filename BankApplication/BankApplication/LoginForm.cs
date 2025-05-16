using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankApplication
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private TextBox txtUsername;
        private TextBox txtPassword;

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            using var client = new HttpClient();
            var content = new StringContent(
                JsonSerializer.Serialize(new { username, password }),
                Encoding.UTF8, "application/json");

            var response = await client.PostAsync("https://your-backend-url/api/login", content);

            if (response.IsSuccessStatusCode)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed. Please check your credentials.");
            }
        }
    }
}
