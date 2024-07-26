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
    public partial class DonarInformation : UserControl
    {
        public DonarInformation()
        {
            InitializeComponent();
        }


        public DonarInformation(int id, string name, string email, string phoneNumber, string city, int bloodGroup, int gender) : this()
        {
            DataShow(name, email, phoneNumber, city, bloodGroup);
            this.Tag = new Data { ID = id, Name = name, Email = email, PhoneNumber = phoneNumber, City = city, BloodGroup = bloodGroup, Gender = gender};
        }

        private void DataShow(string name, string email, string phoneNumber, string city, int bloodGroup)
        {
            name_label.Text = $"<b>NAME : </b>{name}";
            email_label.Text = $"<b>EMAIL : </b>{email}";
            phone_number_label.Text = $"<b>PHONE NUMBER : </b>{phoneNumber}";
            city_label.Text = $"<b>CITY : </b>{city}";
            blood_group_label.Text = $"<b>Blood Group: </b>{Utility.GetBloodGroupName(bloodGroup.ToString())}";
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (!DashBoardForm.Instance.panelContainer.Controls.ContainsKey("Profile"))
            {
                Data tag = (Data)this.Tag;
            
                DashBoardForm.Instance.panelContainer.Controls.Clear(); 
                Profile profile = new Profile(personalProfile: false, id: Convert.ToInt32(tag.ID), name: tag.Name, email: tag.Email, phoneNumber: tag.PhoneNumber, city: tag.City, bloodGroup: tag.BloodGroup, gender: tag.Gender);
                profile.Dock = DockStyle.Fill;
                DashBoardForm.Instance.panelContainer.Controls.Add(profile);
            }            
        }
    }
}
