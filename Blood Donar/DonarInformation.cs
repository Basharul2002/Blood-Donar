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


        public DonarInformation(string name, string email, string phoneNumber, string city, string bloodGroup) : this()
        {
            DataShow(name, email, phoneNumber, city, bloodGroup);
            this.Tag = email;
        }

        private void DataShow(string name, string email, string phoneNumber, string city, string bloodGroup)
        {
            name_label.Text = $"<b>NAME : </b>{name}";
            email_label.Text = $"<b>EMAIL : </b>{email}";
            phone_number_label.Text = $"<b>PHONE NUMBER : </b>{phoneNumber}";
            city_label.Text = $"<b>CITY : </b>{city}";
            blood_group_label.Text = $"<b>Blood Group: </b>{bloodGroup}";
        }

        private void profile_Click(object sender, EventArgs e)
        {
            if (!DashBoardForm.Instance.panelContainer.Controls.ContainsKey("Profile"))
            {
                DashBoardForm.Instance.panelContainer.Controls.Clear(); 
                Profile profile = new Profile(false, this.Tag.ToString());
                profile.Dock = DockStyle.Fill;
                DashBoardForm.Instance.panelContainer.Controls.Add(profile);
            }            
        }
    }
}
