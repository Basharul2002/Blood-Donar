using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blood_Donar
{
    public class Equipment
    {
        public static void ToggoleButton(Guna2TextBox textBox, Guna2Button button)
        {
            if (textBox.UseSystemPasswordChar)
            {
                // textBox.PasswordChar = '*';
                textBox.UseSystemPasswordChar = false;
                button.Image = Properties.Resources.hide;
                return;
            }

            // textBox.PasswordChar = string.Clear();
            textBox.UseSystemPasswordChar = true;
            button.Image = Properties.Resources.show;
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
