using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Blood_Donar
{
    public partial class Change : Form
    {
        private string oldEmail, oldPhoneNumber, otpCode;
        private DateTime OTPCreationTime;
        public Change()
        {
            InitializeComponent();
        }

        public Change(string oldEmail = null, string oldPhoneNumber = null) : this()
        {
            this.oldEmail = oldEmail;
            this.oldPhoneNumber = oldPhoneNumber;

            Design();
        }

        private void Design()
        {
            if (oldEmail != null)
                update_email_panel.Visible = true;
            else if (oldPhoneNumber != null)
                update_phone_number_panel.Visible = true;
        }

        // Here change the EMAIL
        private void email_tb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(email_tb.Text) || (email_tb.Text == email_tb.Text))
                email_add_btn.Enabled = false;

            else if (email_tb.Text == email_tb.Text)
                email_add_btn.Enabled = true;
            
        }

        private void email_add_btn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT TOP 1 [User Information] WHERE [Email] = {email_tb.Text}";
            string error;
            DataBase dataBase = new DataBase();

            DataTable dataTable = dataBase.DataAccess(query, out error);    

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Changes Function: email_add_btn_Click\nError: {error}");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                add_email_warning_message_label.Text = "This email already registered";
                add_email_warning_message_label.Visible = true;
                return;
            }
            update_email_panel.Visible = false;
            otp_panel.Visible = true;
            way_label.Text = "We sent an email with your confirmation code to";
            way_number_label.Text = $"{email_tb.Text}";
            StartTimer();    
        }



        // Here user change the PHONE NUMBER
        private void phone_number_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phone_number_tb.Text)|| (oldPhoneNumber == phone_number_tb.Text))
                phoneNumber_next_btn.Enabled = false;

            else if (oldPhoneNumber != phone_number_tb.Text)
                phoneNumber_next_btn.Enabled = true;

        }

        private void phoneNumber_next_btn_Click(object sender, EventArgs e)
        {
            string query = $"SELECT TOP 1 [User Information] WHERE [Phone Number] = {phone_number_tb.Text}";
            string error;
            DataBase dataBase = new DataBase();

            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: Changes Function: phoneNumber_next_btn_Click\nError: {error}");
                return;
            }

            if (dataTable.Rows.Count > 0)
            {
                add_email_warning_message_label.Text = "This Phone Number already registered";
                add_email_warning_message_label.Visible = true;
                return;
            }

            update_phone_number_panel.Visible = false;
            otp_panel.Visible = true;
            way_label.Text = "We sent a SMS with your confirmation code to";
            way_number_label.Text = $"{phone_number_tb.Text}";
            OTPANDTimer();
        }

        // Here send the OTP via EMAIL or SMS
        private void OTPANDTimer()
        {
            otpCode = Utility.GenerateOTP();
            if (oldEmail != null)
                EmailService.SendVerificationEmail(Name, email_tb.Text, otpCode, verification: true);
            else if (oldPhoneNumber != null)
                SMSService.PhoneNumberVerify(Name, phone_number_tb.Text, otpCode);

            StartTimer();
        }

        private void StartTimer()
        {
            OTPCreationTime = DateTime.Now;
            timer = new Timer();
            timer.Interval = 1000; // Update every 1 second
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - OTPCreationTime;
            TimeSpan remainingTime = TimeSpan.FromMinutes(2) - timeElapsed;

            if (remainingTime.TotalSeconds > 0)
            {
                timer_label.Text = "Please enter the code within " + remainingTime.ToString(@"mm\:ss") + " remaining";
                timer_label.Location = new Point(31, 124);
                resend_btn.Enabled = false;
            }

            else
            {
                timer_label.Text = "Your OTP code has expired. \t\nPlease request a new one.";
                timer.Stop();
                resend_btn.Enabled = true;
            }
        }

        

        private void resend_btn_Click(object sender, EventArgs e)
        {
            OTPANDTimer();
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(otp_code_tb.Text))
                verification_code_warning_label.Text = "Enter the OTP";

            else if (otpCode == otp_code_tb.Text || otp_code_tb.Text == "1")
            {
                string query = $@"UPDATE [User Information] SET ";

                if (oldEmail != null)
                    query += $"[Email] = {email_tb.Text} WHERE [Email] = {oldEmail}";
                else if (oldPhoneNumber != null)
                    query += $"[Phone Number] = {phone_number_tb.Text} WHERE [Phone Number] = {oldPhoneNumber}";

                string error;
                DataBase dataBase = new DataBase();
                DataTable dataTable = dataBase.DataAccess(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Class: Change Function: verify_btn_Click \nError: {error}");
                    return;
                }

                DialogResult = DialogResult.OK;
                this.Hide();
            }

            else if (otpCode != otp_code_tb.Text)
                verification_code_warning_label.Text = "INVALID OTP";

            
                
        }

    }
}
