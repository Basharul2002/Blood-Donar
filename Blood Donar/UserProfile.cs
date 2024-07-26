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
    public partial class UserProfile : UserControl
    {
        private RecoverPassword recoverPasswordForm;
        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(string name, string city, RecoverPassword recoverPasswordForm) : this()
        {
            this.recoverPasswordForm = recoverPasswordForm;
            Design(name, city);
        }

        private void Design(string name, string city)
        {
            name_label.Text = name;
            city_label.Text = city;
        }


        private void profile_Click(object sender, EventArgs e)
        {
            Data tag = (Data)this.Tag;
            recoverPasswordForm.ShowOTPSendingPanel(name: tag.Name, email: tag.Email, phoneNumber: tag.PhoneNumber, password: tag.Password);        }
    }
}
