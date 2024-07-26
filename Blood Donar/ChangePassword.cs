using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donar
{
    public partial class ChangePassword : Form
    {
        private int id;
        private string password;
        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(int id, string password) : this()
        {
            this.id = id;
            this.password = password;
        }

        private void reset_password_Click(object sender, EventArgs e)
        {
            current_password_warning_label.Visible = false;
            new_password_warning_label.Visible = false;
            confirm_password_warning_label.Visible = false;
            if (string.IsNullOrWhiteSpace(current_password_tb.Text))
            {
                current_password_warning_label.Text = "Please enter the current password";
                current_password_warning_label.Visible = true;
                current_password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(new_password_tb.Text))
            {
                new_password_warning_label.Text = "Please enter the new password";
                new_password_warning_label.Visible = true;
                new_password_tb.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                confirm_password_warning_label.Text = "Enter the new password one more time";
                confirm_password_warning_label.Visible = true;
                confirm_password_tb.Focus();
                return;
            }

            if (this.password != current_password_tb.Text)
            {
                current_password_warning_label.Text = "Password does not match";
                current_password_warning_label.Visible = true;
                current_password_tb.Focus();
                return ;
            }

            if (this.password == new_password_tb.Text)
            {
                new_password_warning_label.Text = "The new password cannot be same as the old password.";
                new_password_warning_label.Visible = true;
                new_password_tb.Focus();
                return;
            }

            if (new_password_tb.Text != confirm_password_tb.Text)
            {
                confirm_password_warning_label.Text = "New password does not match";
                confirm_password_warning_label.Visible = true;
                confirm_password_tb.Focus();
                return ;
            }

            string error, query = $"UPDATE [User Information] SET Password = '{new_password_tb.Text}' WHERE ID = {this.id}";
            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: ChangePassword function: reset_password_Click \nError: {error}");
                return;
            }

            this.Close();
            DialogResult = DialogResult.OK; 
        }
    }
}
