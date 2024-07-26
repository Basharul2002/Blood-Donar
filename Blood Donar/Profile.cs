using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Blood_Donar
{
    public partial class Profile : UserControl
    {
        private int id, bloodGroup, gender, emailVerify, phoneNumberVerify;
        private string name, email, phoneNumber, city, password;
        public Profile()
        {
            InitializeComponent();
        }


        public Profile(bool personalProfile, int id, string name = null, string email = null, string phoneNumber = null, string city = null, int bloodGroup = 0, int gender = 0) : this()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.city = city;
            this.gender = gender;
            this.bloodGroup = bloodGroup;

            if (personalProfile)
            {
                DataBaseDataShow(id);
                PersonalProfileDataLoad();
            }
                
            else
                DonarProfileDataLoad();
           
        }


        private void PersonalProfileDataLoad()
        {
            user_profile_panel.Visible = true;
            donar_profile_panel.Visible = false;

            if (emailVerify == 1)
            {
                verify_email.Text = "Verified";
                verify_email.Enabled = false;
            }

            if (phoneNumberVerify == 1)
            {
                verify_phone_number.Text = "Verified";
                verify_phone_number.Enabled = false;
            }
                

        }

        private void DonarProfileDataLoad()
        {
            MessageBox.Show($"Gender: {this.gender}");
            user_profile_panel.Visible = false;
            donar_profile_panel.Visible = true;

            name_label.Text = $"Name: {this.name}";
            email_label.Text = $"Email: {this.email}";
            phone_number_label.Text = $"Phone Number: {this.phoneNumber}";
            blood_group_label.Text = $"Blood Group: {Utility.GetBloodGroupName(this.bloodGroup.ToString())}";
            city_label.Text = $"City: {this.city}";
            gender_label.Text = $"Gender: {Utility.GetGenderName(this.gender)}";
        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
           // MessageBox.Show($"Name: {this.name}\nText: {name_tb.Text}");
            if (string.IsNullOrWhiteSpace(name_tb.Text) || name_tb.Text == this.name)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void city_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(city_tb.Text) || city_tb.Text == this.city)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void gender_radio_btn_CheckedChanged(object sender, EventArgs e)
        {
          //  MessageBox.Show($"Gender: {this.gender}\nButton: {male_btn.Checked}, {female_btn.Checked}, {others_btn.Checked}");
            if ((gender == 1 && male_btn.Checked) || (gender == 2 && female_btn.Checked) || (gender == 3 && others_btn.Checked))
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void DataBaseDataShow(int id)
        {
            // MessageBox.Show($"Email: {email}");
            DataBase dataBase = new DataBase();
            string query = $@"SELECT 
                                UI.ID, 
                                UI.Name, 
                                UI.Email, 
                                UI.[Phone Number], 
                                UI.City, 
                                UI.[Blood Group], 
                                UI.Gender, 
                                UI.Password, 
                                UVI.Email AS [Email Verify], 
                                UVI.[Phone Number] AS [Phone Number Verify]
                            FROM 
                                [User Information] UI
                            INNER JOIN 
                                [User Verify Information] UVI ON UI.ID = UVI.ID
                            WHERE 
                                UI.ID = {id}";
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Profile Function: DataBaseDataShow \nException: {error}");
                return;
            }

            if (dataTable == null)
            {
                MessageBox.Show("No Data Found", "NULL");
                return;
            }

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                return;
            }

            this.id = Convert.ToInt32(dataTable.Rows[0]["ID"]);
            name_tb.Text = this.name = dataTable.Rows[0]["Name"].ToString();
            email_tb.Text = this.email = dataTable.Rows[0]["Email"].ToString();
            phone_number_tb.Text = this.phoneNumber = dataTable.Rows[0]["Phone Number"].ToString();
            city_tb.Text = this.city = dataTable.Rows[0]["City"].ToString();
            this.gender = Convert.ToInt32(dataTable.Rows[0]["Gender"]);
            this.password = dataTable.Rows[0]["Password"].ToString();
            Utility.SelectGenderRadioButton(gender, male_btn, female_btn, others_btn);
            blood_group_cb.SelectedIndex = this.bloodGroup = Convert.ToInt32(dataTable.Rows[0]["Blood Group"]);
            emailVerify = Convert.ToInt32(dataTable.Rows[0]["Email Verify"]);
            phoneNumberVerify = Convert.ToInt32(dataTable.Rows[0]["Phone Number Verify"]);
        }

        private void change_password_btn_Click(object sender, EventArgs e)
        {
            using (ChangePassword changePassword = new ChangePassword(this.id, this.password)) 
            {
                DialogResult dialogResult = changePassword.ShowDialog();

            }
        }

        private void verify_phone_number_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Verify verify = new Verify(id: this.id, name: name, phoneNumber: phoneNumber))
            {
                DialogResult dialogResult = verify.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_phone_number.Text = "Verified";
                    verify_phone_number.Enabled = false;
                }
            }
        }

        private void change_email_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Change change = new Change(oldEmail: email);
        }

        private void change_phone_number_button_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Change change = new Change(oldPhoneNumber: phoneNumber))
            {
                DialogResult dialogResult = change.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_email.Text = "Verified";
                    verify_email.Enabled = false;
                }
            }
        }

        private void change_email_button_Click(object sender, EventArgs e)
        {
            using (Change change = new Change(oldPhoneNumber: phoneNumber))
            {
                DialogResult dialogResult = change.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_email.Text = "Verified";
                    verify_email.Enabled = false;
                }
            }
        }

        private void verify_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Verify verify = new Verify(id: this.id, name: name, email: email))
            {
                DialogResult dialogResult = verify.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_email.Text = "Verified";
                    verify_email.Enabled = false;
                }
            }
        }


        private void verify_email_Click(object sender, EventArgs e)
        {
            using (Verify verify = new Verify(id: this.id, name: name, email: email))
            {
                DialogResult dialogResult = verify.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_email.Text = "Verified";
                    verify_email.Enabled = false;
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE [User Information] SET ";

            if (name != name_tb.Text)
                query += $"Name = '{name_tb.Text}', ";

            int gender = Utility.GetGenderID(male_btn: male_btn, female_btn: female_btn, others_btn: others_btn);
            if (this.gender != gender)
                query += $"Gender = {gender}, ";

            if (city != city_tb.Text)
                query += $"City = '{city_tb.Text}', ";

            if (bloodGroup != blood_group_cb.SelectedIndex)
                query += $"[Blood Group] = {blood_group_cb.SelectedIndex}, ";

            query += $"{query.Remove(query.Length - 2)} WHERE [ID] = '{this.id}'";

                // Execute the query using your DataBase class
            DataBase dataBase = new DataBase();
            string error;
            dataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {                    
                MessageBox.Show($"Class: Profile Function: update_btn_Click \nError: {error}");
                return;
            }

        }

    }
}
