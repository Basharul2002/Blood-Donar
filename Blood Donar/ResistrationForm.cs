using Blood_Donar.Properties;
using Guna.UI2.WinForms;
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
    public partial class ResistrationForm : UserControl
    {
        private HomePage homePage;
        public ResistrationForm()
        {
            InitializeComponent();
        }

        public ResistrationForm(HomePage homePage) : this()
        {
            this.homePage = homePage;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void Clear()
        {
            name_tb.Text = "";
            email_tb.Text = "";
            phone_number_tb.Text = "";
            blood_group_cb.SelectedIndex = 0;
            city_tb.Text = "";
            password_tb.Text = "";
            confirm_password_tb.Text = "";
            male_btn.Checked = false;
            female_btn.Checked = false;
            others_btn.Checked = false;
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            DataStore();
        }

        private int Gender()
        {
            if (male_btn.Checked)
                return 1;
            else if (female_btn.Checked)
                return 2;
            else if (others_btn.Checked)
                return 3;
            else
                return 0;
        }

        private void DataStore()
        {
            name_warning_label.Visible = false;
            email_warning_label.Visible = false;
            phone_number_warning_label.Visible = false;
            blood_group_warning_label.Visible = false;
            city_warning_label.Visible = false;
            gender_warning_label.Visible = false;
            password_warning_label.Visible = false;
            confirm_password_warning_label.Visible = false;



            if (string.IsNullOrWhiteSpace(name_tb.Text) )
            {
                name_tb.Focus();
                name_warning_label.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(email_tb.Text) )
            {
                email_tb.Focus();
                email_warning_label.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(phone_number_tb.Text))
            {
                phone_number_tb.Focus();
                phone_number_warning_label.Visible = true;
                return;
            }
            if (blood_group_cb.SelectedIndex == 0 )
            {
                blood_group_warning_label.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(city_tb.Text))
            {
                city_tb.Focus();
                city_warning_label.Visible = true;
                return;
            }
            if (Gender() == 0)
            {
                gender_panel.Focus();
                gender_warning_label.Visible= true;
                return;
            }
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                password_tb.Focus();
                password_warning_label.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(confirm_password_tb.Text))
            {
                confirm_password_tb.Focus();
                confirm_password_warning_label.Text = "Fill the CONFIRM PASSWORD";
                confirm_password_warning_label.Visible = true;
                return;
            }
            if (password_tb.Text != confirm_password_tb.Text)
            {
                confirm_password_tb.Focus();
                confirm_password_warning_label.Text = "Password does not match";
                confirm_password_warning_label.Visible = true;
                return;
            }

            DataBase dataBase = new DataBase();
            string query, error;
            DataTable dataTable;

            // Here check have any account input email
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Email] = '{email_tb.Text}'";
            dataTable = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 1 \nError: {error}", "Email");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                email_warning_label.Text = "This EMAIL is already resistered";
                email_warning_label.Visible = true;
                email_tb.Focus();
                return;
            }
            

            // Check the phone number is register or not
            query = $"SELECT TOP 1 * FROM [User Information] WHERE [Phone Number] = '{phone_number_tb.Text}'";
            dataTable = dataBase.DataAccess(query, out error);
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 2 \nError: {error}", "Phone Number");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                phone_number_warning_label.Text = "This PHONE NUMBER is already resistered";
                phone_number_warning_label.Visible = true;
                phone_number_tb.Focus();
                return;
            }

            // Here register the information as a new account
            query = $@"INSERT INTO [User Information] (Name, Email, [Phone Number], [Blood Group], City, Gender, Password)
                              VALUES('{name_tb.Text}', '{email_tb.Text}', '{phone_number_tb.Text}', {BloodGroup()}, '{city_tb.Text}', {Gender()}, '{password_tb.Text}')";

            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 3 \nError: {error}", "Data Insert 1");
                return;
            }

            query = $@"INSERT INTO [User Verify Information] (ID, Email, [Phone Number])
                        VALUES
                            ((SELECT MAX(ID) FROM [User Information]), 
                             {0},
                             {0}";
            dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class Name: ResistrationForm Function: DataStore 3 \nError: {error}", "Data Insert 2");
                return;
            }
            if (!HomePage.Instance.leftPanelContainer.Controls.ContainsKey("LoginPage"))
            {
                HomePage.Instance.leftPanelContainer.Controls.Clear();
                LoginPage login_Page = new LoginPage(homePage);
                login_Page.Dock = DockStyle.Fill;
                HomePage.Instance.leftPanelContainer.Controls.Add(login_Page);
            }

            if (!HomePage.Instance.rightPanelContainer.Controls.ContainsKey("ResistrationInitialPage"))
            {
                HomePage.Instance.rightPanelContainer.Controls.Clear();
                ResistrationInitialPage resistration_Initial_Panel = new ResistrationInitialPage(homePage);
                resistration_Initial_Panel.Dock = DockStyle.Fill;
                HomePage.Instance.rightPanelContainer.Controls.Add(resistration_Initial_Panel);
            }
        }

        private int BloodGroup()
        {
            return (blood_group_cb.SelectedIndex);
            
        }

        private void ResistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void female_btn_CheckedChanged(object sender, EventArgs e)
        {

        }

       

        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_password_toggle_btn);
        }

        private void password_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
