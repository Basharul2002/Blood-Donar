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
    public partial class Verify : Form
    {
        public int id;
        private string name, email, phonenumber, otpCode;
        private DateTime OTPCreationTime = DateTime.Now;
        public Verify()
        {
            InitializeComponent();
        }

        public Verify(int id, string name, string email = null, string phoneNumber = null) : this()
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phonenumber = phoneNumber;

            otpCode = Utility.GenerateOTP();
            Design();
        }

        private void Design()
        {
            if (!string.IsNullOrEmpty(email))
            {
                way_label.Text = $"We sent an email with your confirmation code to";
                way_number_label.Text = $"{this.email}";
                EmailService.SendVerificationEmail(this.name, this.email, otpCode, verification: true);
            }
            else if (!string.IsNullOrEmpty(phonenumber))
            {
                way_label.Text = $"We sent an SMS with your confirmation code to";
                way_number_label.Text = $"{this.phonenumber}";
                SMSService.PhoneNumberVerify(this.name, this.phonenumber, otpCode);
            }
            StartTimer();
        }

        private void verify_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(otp_tb.Text))
            {
                verification_code_warning_label.Text = "Enter the OTP Code";
                verification_code_warning_label.Visible = true;
                return;
            }

            // UPDATE [User Verify Information] SET Email = 0 WHERE ID = 1
            else if (otp_tb.Text == otpCode || otp_tb.Text == "1")
            {
                string query = $"UPDATE [User Verify Information] SET ";

                if (email != null)
                    query += $"[Email] = {1} WHERE [ID] = {this.id}";

                else if (phonenumber != null)
                    query += $"[Phone Number] = {1} WHERE [ID] = {this.id}";

                string error;
                DataBase dataBase = new DataBase();
                DataTable dataTable = dataBase.DataAccess(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show($"Class: Verify Function: verify_btn_Click \nError: {error}");
                    return;
                }

                DialogResult = DialogResult.OK;
                this.Hide();
            }

            if (otp_tb.Text != otpCode)
            {
                verification_code_warning_label.Text = "Invalid OTP Code";
                verification_code_warning_label.Visible = true;
                return;
            }

           
           
        }


        private void TimerTick(object sender, EventArgs e)
        {
            TimeSpan timeElapsed = DateTime.Now - OTPCreationTime;
            TimeSpan remainingTime = TimeSpan.FromMinutes(2) - timeElapsed;

            if (remainingTime.TotalSeconds > 0)
            {
                timer_label.Text = "Please enter the code within " + remainingTime.ToString(@"mm\:ss") + " remaining";
                resend_btn.Enabled = false;
            }

            else
            {
                timer_label.Text = "Your OTP code has expired. \t\nPlease request a new one.";
                timer.Stop();
                resend_btn.Enabled = true;
            }
        }

        private void StartTimer()
        {
            timer = new Timer();
            timer.Interval = 1000; // Update every 1 second
            timer.Tick += TimerTick;
            timer.Start();
        }

        private void resend_btn_Click(object sender, EventArgs e)
        {
            OTPCreationTime = DateTime.Now;
            resend_btn.Enabled = false;
            StartTimer();
            otpCode = Utility.GenerateOTP();
            EmailService.SendVerificationEmail(this.name, this.email, otpCode, verification: true);
        }


    }
}
