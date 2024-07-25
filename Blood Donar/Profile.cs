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
    public partial class Profile : UserControl
    {
        private int id, bloodGroup, gender;
        private string name, email, phoneNumber, city, password;
        private bool emailVerify = false, phoneNumberVerify = false;
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
                PersonalProfileDataLoad();
            else
                DonarProfileDataLoad();

            DataBaseDataShow(id);
            // DataShow(email);

            // After all data collected from database
            this.id = id;
            name = name_tb.Text;
            phoneNumber = phone_number_tb.Text;
        }


        private void PersonalProfileDataLoad()
        {
            user_profile_panel.Visible = true;
            donar_profile_panel.Visible = false;

        }

        private void DonarProfileDataLoad()
        {
            MessageBox.Show($"Gender: {this.gender}");
            user_profile_panel.Visible = false;
            donar_profile_panel.Visible = true;

            name_label.Text = $"Name: {this.name}";
            email_label.Text = $"Email: {this.email}";
            phone_number_label.Text = $"Phone Number: {this.phoneNumber}";
            blood_group_label.Text = $"Blood Group: {Equipment.BloodGroupSelection(this.bloodGroup.ToString())}";
            city_label.Text = $"City: {this.city}";
            gender_label.Text = $"Gender: {Equipment.GenderSelection(this.gender)}";
        }

        private void name_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name_tb.Text) || name_tb.Text == this.Name)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void city_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(city_tb.Text) || city_tb.Text == this.Name)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void male_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (gender == 1)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void female_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (gender == 2)
            {
                update_btn.Enabled = false;
                return;
            }

            update_btn.Enabled = true;
        }

        private void others_btn_CheckedChanged(object sender, EventArgs e)
        {
            if (gender == 3)
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
            string query = $"SELECT * FROM [User Information] WHERE [ID] = {id}";
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


            this.name = name_tb.Text = dataTable.Rows[0]["Name"].ToString();
            this.email = email_tb.Text = dataTable.Rows[0]["Email"].ToString();
            this.phoneNumber = phone_number_tb.Text = dataTable.Rows[0]["Phone Number"].ToString();
            this.city = city_tb.Text = dataTable.Rows[0]["City"].ToString();
            this.password = password_tb.Text = dataTable.Rows[0]["Password"].ToString();
            this.gender = Convert.ToInt32(dataTable.Rows[0]["Gender"]);
            Equipment.GenderSelection(gender, male_btn, female_btn, others_btn);
            this.gender = blood_group_cb.SelectedIndex = Convert.ToInt32(dataTable.Rows[0]["Blood Group"]);
            // emailVerify = row["Email Verified"].ToString() == "1";
            // phoneNumberVerify = row["Phone Number Verified"].ToString() == "1";
        }



        private void verify_phone_number_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (Verify verify = new Verify(name: name, phoneNumber: phoneNumber))
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
            using (Verify verify = new Verify(name: name, email: email))
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
            using (Verify verify = new Verify(name: name, email: email))
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

            int gender = Equipment.Gender(male_btn: male_btn, female_btn: female_btn, others_btn: others_btn);
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
