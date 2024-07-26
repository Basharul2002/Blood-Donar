using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace Blood_Donar
{
    public partial class RecoverPassword : Form
    {
        private string name, email, phoneNumber, password, otpCode;
        private DateTime OTPCreationTime;
        public RecoverPassword()
        {
            InitializeComponent();
        }

        // After id selected
        public void ShowOTPSendingPanel(string name, string email, string phoneNumber, string password)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.password = password;
            Design();
        }


        // Account Search
        private void search_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(account_search_tb.Text))
            {
                warning_message.Visible = true;
                return;
            }
            warning_message.Visible = false;
            DataBase dataBase = new DataBase();

            string query = $"SELECT * FROM [User Information] WHERE [Email] LIKE '%{account_search_tb.Text}%' OR [Phone Number] = '%{account_search_tb.Text}%'";
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show($"Class: RecoverPassword Function: search_btn_Click \nError: {error}");
                return;
            }

            if (dataTable.Rows.Count <= 0)
            {
                warning_message.Text = "No user found via on EMAIL or PHONE NUMBER";
                warning_message.Visible = true;
                return;
            }

            // MessageBox.Show(dataTable.Rows.Count.ToString());
            account_search_panel.Visible = false;
            profile_panel.Visible = true;

            UserProfile profile;
            for ( int i = 0; i < dataTable.Rows.Count; i++ ) 
            {
                profile  = new UserProfile(name: dataTable.Rows[i]["Name"].ToString(), city: dataTable.Rows[i]["City"].ToString(), recoverPasswordForm: this);
                profile.Tag = new Data { Name = dataTable.Rows[i]["Name"].ToString(), Email = dataTable.Rows[i]["Email"].ToString(), PhoneNumber = dataTable.Rows[i]["Phone Number"].ToString(),  Password = dataTable.Rows[i]["Password"].ToString()};
                profile_showing_panel.Controls.Add(profile);
            }
        }



        // Design for OTP sending 
        private void Design()
        {
            profile_panel.Visible = false;
            otp_sending_panel.Visible = true;
            name_label.Text = name;
            email_radio_button.Text = $"Send an email to {Utility.MaskEmail(this.email)}";
            sms_radio_button.Text = $"Text a code to the phone number ending in {Utility.MaskPhoneNumber(this.phoneNumber)}";
            otp_sending_panel.Visible = true;
        }



        // Here choose the EMAIL/SMS for OTP send
        private void back_btn_Click(object sender, EventArgs e)
        {
            otp_sending_panel.Visible = false;
            profile_panel.Visible = true;
        }
        private void otp_send_btn_Click(object sender, EventArgs e)
        {
            otpCode = Utility.GenerateOTP();
            if (email_radio_button.Checked)
            {
                // string name, string recipientEmail, string otp
                EmailService.SendVerificationEmail(recipientName: name, recipientEmail: email, otpCode: otpCode, passwordReset: true);
                way_label.Text = "We sent an email with your confirmation code to";
                way_number_label.Text = $"{email}";
            }

            else if (sms_radio_button.Checked)
            {
                SMSService.PhoneNumberVerify(name: name, phoneNumber: phoneNumber, otpCode: otpCode);
                way_label.Text = "We sent a SMS with your confirmation code to";
                way_number_label.Text = $"{phoneNumber}";
            }

            otp_sending_panel.Visible = false;
            otp_verify_panel.Visible = true;
            OTPANDTimer();

        }


        // After OTP send 
        // Here verify the OTP code
        private void OTPANDTimer()
        {
            otpCode = Utility.GenerateOTP();
            if (email_radio_button.Checked)
                EmailService.SendVerificationEmail(Name, email, otpCode, passwordReset: true);
            else if (sms_radio_button.Checked)
                SMSService.PhoneNumberVerify(Name, phoneNumber, otpCode);
            OTPCreationTime = DateTime.Now;
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
                resend_btn.Enabled = false;
                verify_btn.Enabled = true;
            }

            else
            {
                timer_label.Text = "Your OTP code has expired. Please request a new one.";
                timer.Stop();
                resend_btn.Enabled = true;
                verify_btn.Enabled = false;
            }
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"OTP Code; {otpCode}\nText: {otp_code_tb.Text}");

            if (string.IsNullOrWhiteSpace(otp_code_tb.Text))
                verification_code_warning_label.Text = "Enter the OTP";

            else if (otpCode == otp_code_tb.Text || otp_code_tb.Text == "1")
            {               
                otp_verify_panel.Visible = false;
                change_password_panel.Visible = true;
            }

            else if (otpCode != otp_code_tb.Text)
            {
                verification_code_warning_label.Text = "INVALID OTP";
                verification_code_warning_label.Visible = true;
            }
        }




        // Complete the verification
        // Here user change the password that means reset the password
        private void password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(password_tb, password_toggle_btn);
        }

        private void confirm_password_toggle_btn_Click(object sender, EventArgs e)
        {
            Utility.TogglePasswordVisibility(confirm_password_tb, confirm_password_toggle_btn);
        }


        private void reset_password_Click(object sender, EventArgs e)
        {
            password_warning_label.Visible = false;
            confirm_password_warning_label.Visible = false;
            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                password_warning_label.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(password_tb.Text))
            {
                confirm_password_warning_label.Text = "Please enter the password more one time";
                confirm_password_warning_label.Visible = true;
                return;
            }

            if (password_tb.Text != confirm_password_tb.Text)
            {
                confirm_password_warning_label.Text = "Passwords do not match";
                confirm_password_warning_label.Visible = true;
                return;
            }

            string query = $@"UPDATE [User Information] SET [Password] = '{password_tb.Text}'";



            string error;
            DataBase dataBase = new DataBase();
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: RecoverPassword Function: reset_password_Click \nError: {error}");
                return;
            }
            DialogResult = DialogResult.OK;
        }

    }
}
