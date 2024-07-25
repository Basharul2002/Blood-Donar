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
        private int id;
        private string name, email, phoneNumber;
        private bool emailVerify = false, phoneNumberVerify = false;
        public Profile()
        {
            InitializeComponent();
        }


        public Profile(bool personalProfile, int id) : this() 
        {
            if (personalProfile)
                PersonalProfileDataLoad();
            else
                PersonProfileDataLoad();

            DataBaseDataShow(id);
            // DataShow(email);

            // After all data collected from database
            this.id = id;
            name = name_tb.Text;
            phoneNumber = phone_number_tb.Text;
        }


        private void PersonalProfileDataLoad()
        {
            password_label.Visible = true;
            name_tb.Visible = true;
            back_btn.Location = new Point(185, 420);
            gender1.Visible = true;
            gender2.Visible = false;
            Editable(true);
        }

        private void PersonProfileDataLoad()
        {
            password_label.Visible = false;
            password_tb.Visible = false;
            back_btn.Location = new Point(185, 345);
            gender1.Visible = false;
            gender2.Visible = true;
            Editable(false);
        }

        private void Editable(bool flag)
        {
            name_tb.Enabled = flag;
            name_tb.ReadOnly = flag;
            email_tb.Enabled = flag;
            email_tb.ReadOnly = flag;
            phone_number_tb.Enabled = flag;
            phone_number_tb.ReadOnly = flag;
            city_tb.Enabled = flag;
            city_tb.ReadOnly = flag;
            blood_group_cb.Enabled = flag;
            male_btn2.Enabled = flag;
            female_btn2 .Enabled = flag;
            others_btn2.Enabled = flag;
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

            if (dataTable == null )
            {
                MessageBox.Show("No Data Found", "NULL");
                return;
            }

            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("No Data Found");
                return;
            }


            name_tb.Text = dataTable.Rows[0]["Name"].ToString();
            email_tb.Text = dataTable.Rows[0]["Email"].ToString();
            phone_number_tb.Text = dataTable.Rows[0]["Phone Number"].ToString();
            city_tb.Text = dataTable.Rows[0]["City"].ToString();
            password_tb.Text = dataTable.Rows[0]["Password"].ToString();
            Equipment.GenderSelection(Convert.ToInt32(dataTable.Rows[0]["Gender"]), male_btn1, female_btn1, others_btn1);
            Equipment.GenderSelection(Convert.ToInt32(dataTable.Rows[0]["Gender"]), male_btn2, female_btn2, others_btn2);
            blood_group_cb.SelectedIndex = Convert.ToInt32(dataTable.Rows[0]["Blood Group"]);
            // emailVerify = row["Email Verified"].ToString() == "1";
            // phoneNumberVerify = row["Phone Number Verified"].ToString() == "1";
        }


        private void DataShow(string email)
        {
            List<Data> allData = Manager.DonarInformationManager();
            foreach (Data data in allData)
            {
                if (data.Email == email)
                {
                    name_tb.Text = data.Name;
                    email_tb.Text = data.Email;
                    phone_number_tb.Text = data.PhoneNumber;
                    blood_group_cb.Text = data.BloodGroup;
                    city_tb.Text = data.City;
                    password_tb.Text = data.Password;
                    SelectGender(data.Gender);
                }
            }
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

        private void SelectGender(int gender)
        {
            if (gender == 1)
            {
                male_btn1.Checked = true;
                male_btn2.Checked = true;
            }
            else if (gender == 2)
            {
                female_btn1.Checked = true;
                female_btn2.Checked = true;
            }
            else if (gender == 3)
            {
                others_btn1.Checked = true;
                others_btn2.Checked = true;
            }
        }

        private void verify_email_Click(object sender, EventArgs e)
        {
            using (Verify verify =  new Verify(name: name, email: email)) 
            {
                DialogResult dialogResult = verify. ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    verify_email.Text = "Verified";
                    verify_email.Enabled = false;
                }
            }
        }
    }
}
