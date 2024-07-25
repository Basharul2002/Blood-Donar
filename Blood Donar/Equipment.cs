using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donar
{
    public class Equipment
    {
        public static void ToggoleButton(Guna2TextBox textBox, Guna2Button button)
        {
            if (textBox.PasswordChar != '●')
            {
                textBox.PasswordChar = '●';
                // textBox.UseSystemPasswordChar = false;
                button.Image = Properties.Resources.hide;
                return;
            }

            textBox.PasswordChar = '\0';
            // textBox.UseSystemPasswordChar = true;
            button.Image = Properties.Resources.show;
        }

        public static void GenderSelection(int gender, RadioButton maleRadioButton, RadioButton femaleRadioButton, RadioButton othersRadioButton)
        {
            if (gender == 1)
                maleRadioButton.Checked = true;
            else if (gender == 2)
                femaleRadioButton.Checked = true;
            else if (gender == 3)
                othersRadioButton.Checked = true;
        }

        public static string BloodGroupSelection(string bloodGroup)
        {
            if (bloodGroup == "1")
                return "A+";
            else if (bloodGroup == "2")
                return "A-";
            else if (bloodGroup == "3")
                return "B+";
            else if (bloodGroup == "4")
                return "B-";
            else if (bloodGroup == "5")
                return "AB+";
            else if (bloodGroup == "6")
                return "AB-";
            else if (bloodGroup == "7")
                return "O+";
            else if (bloodGroup == "8")
                return "O-";
            else if (bloodGroup == "9")
                return "Golden Blood";
            else
                return "Nothing";
        }


        public static string GenderSelection(int gender)
        {
            if (gender == 1)
                return "Male";
            else if (gender == 2)
                return "Female";
            else if (gender == 3)
                return "Others";
            else
                return null;
        }

        public static int Gender(RadioButton male_btn, RadioButton female_btn, RadioButton others_btn)
        {
            return (male_btn.Checked? 1 : female_btn.Checked? 2 : others_btn.Checked ? 3 : 0);
        }

        public static string GenerateOTP()
        {
            // Define the characters from which the OTP will be generated
            const string chars = "0123456789";

            // Create an instance of Random class
            Random random = new Random();

            // Generate a 6-digit OTP using random characters
            return new string(Enumerable.Repeat(chars, 6).Select(s => s[random.Next(s.Length)]).ToArray());

        }


        public static string MaskEmail(string email)
        {
            string[] parts = email.Split('@');
            string username = parts[0];
            string domain = parts[1];

            string maskedUsername;
            // Mask the username
            int usernameLength = username.Length;
            if (usernameLength > 3)
                maskedUsername = username.Substring(0, 2) + new string('x', usernameLength - 2);

            else if (usernameLength == 3)
                maskedUsername = username.Substring(0, 1) + new string('x', usernameLength - 1);

            else
                maskedUsername = username;

            // Mask the domain
            string[] domainPart = domain.Split('.');
            string domainFirstPart = domainPart[0];
            string domainSecondPart = domainPart[1];

            return maskedUsername + "@" + domain.Substring(0, 1) + new string('x', domainFirstPart.Length - 1) + "." + new string('x', domainSecondPart.Length);
        }

        public static string MaskPhoneNumber(string phoneNumber)
        {
            return new string('*', phoneNumber.Length - 2) + phoneNumber.Substring(phoneNumber.Length - 2);
        }

        
    }


  
}
