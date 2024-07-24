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
    public partial class LoginPage : UserControl
    {
        private HomePage homePage;
        public LoginPage()
        {
            InitializeComponent();
            warning_label.Visible = false;
        }


        public LoginPage(HomePage homePage) : this()
        {
            this.homePage = homePage;
        }

        private void Login(string email, string passweord)
        {
            string query = "SELECT TOP 1 FROM [User Login Information]";

            DataBase dataBase = new DataBase();
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            // If error is not empty that means something is wrong
            // So, user requst is not valid for next 
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: loginPage function: Login, error: {error}");
                return;
            }

            // If no data found in database based on email and password
            // So, user requst is not valid for next 
            if (dataTable.Rows.Count > 0)
            {
                warning_label.Text = "Invalid email or password";
                warning_label.Visible = true;
                return;
            }

            // Email and Password is matched with database data
            // So user is valid for access next page
            homePage.Hide();
            DashBoardForm dashBoard = new DashBoardForm();
            dashBoard.Show();

        }

        private void login_button_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(email_tb.Text) && string.IsNullOrWhiteSpace(password_tb.Text))
            {
                warning_label.Text = "Enter your email and password";
                warning_label.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(email_tb.Text))
            {
                warning_label.Text = "Enter your email";
                warning_label.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                warning_label.Text = "Enter your password";
                warning_label.Visible = true;
                return;
            }

            bool flag = false;

            List<Data> allData = Manager.DonarInformationManager();

            for (int i = 0; i < allData.Count; i++)
            {
                if ((allData[i].Email == email_tb.Text) && allData[i].Password == password_tb.Text)
                    flag = true;
            }

            if (!flag)
            {
                warning_label.Text = "Invalid email or password";
                warning_label.Visible = true;
                return;
            }


            homePage.Hide();
            DashBoardForm dashBoard = new DashBoardForm(email_tb.Text);
            dashBoard.Show();
        }

        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Equipment.ToggoleButton(password_tb, password_toggle_btn);
        }

        private void recover_password_btn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (RecoverPassword recoverPassword = new RecoverPassword())
            {
                DialogResult dialogResult = recoverPassword.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                }
            }
        }
    }
}
