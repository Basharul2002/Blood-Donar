using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using System.Xml.Linq;

namespace Blood_Donar
{
    internal class Verification
    {
        
        public static Dictionary<bool, string> EmailVerify(string name, string recipientEmail, string otp)
        {
            // Email settings
            string senderEmail = "basharulalamm@gmail.com"; // Replace with your sender email address
            string senderPassword = "xvoawtmtomxzuqio"; // Replace with your sender email password

            string subject = "Password Reset OTP Code - VOVO";
            string body = @"<!DOCTYPE html>
                            <html lang='en'>
                            <head>
                              <meta charset='UTF-8'>
                              <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                              <title>Blood Donar</title>
                               <style>
                            body 
                            {
                                font-family: Arial, sans-serif;
                            }
                            .email-content 
                            {
                                max-width: 600px;
                                margin: 0 auto;
                                padding: 20px;
                                border: 1px solid #ccc;
                                background-color: #f4f4f4;
                            }
                            .email-heading 
                            {
                              font-size: 24px;
                              font-weight: bold;
                              margin-bottom: 20px;
                            }
                        .email-text {
                          font-size: 16px;
                          line-height: 1.5;
                          margin-bottom: 20px;
                        }
                        .email-list {
                          margin-left: 20px;
                        }
                        .email-list li {
                          list-style-type: disc;
                          margin-bottom: 10px;
                        }
                        .email-footer {
                          font-size: 14px;
                          margin-top: 20px;
                        }
                      </style>
                            </head>
                            <body>
                              <div class='email-content'>
                                <div class='email-heading'>Dear " + name + @",</div>
                                <div class='email-text'>
                                    We have received a request to reset your password for your [Your Website/App Name] account. To proceed with the password reset, please use the following One-Time Password (OTP) code within the next 2 minutes:                                  <br><br>
                                  OTP Code: " + otp + @"
                                  <br><br>
                                  Please enter this OTP code on the password reset page to complete the process. If you didn't request this password reset or if you believe this is a mistake, please ignore this email and take necessary actions to secure your account.
                                  <br><br>
                                  Please note that this OTP is valid for a limited time and for a single use only. Keep this OTP confidential and do not share it with anyone.
                                </div>
                                <div class='email-footer'>
                                  If you need further assistance or have any questions, feel free to contact our support team at <a href='mailto:basharulalamm@gmail.com'> basharulalamm@gmail.com</a> or <a href='tel:+01813890622'>+8801 81389 0622</a>.
                                  <br><br>
                                  Thank you for using [Platform/Service Name].
                                  <br>
                                  <div class='email-footer'>Best regards,<br>Blood Donar</div>
                                </div>
                              </div>
                            </body>
                            </html>";

            Dictionary<bool, string> keyValuePairs = new Dictionary<bool, string>();

            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Set this property to true

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                    {
                        smtp.Port = 587;
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;

                        smtp.Send(mail);
                    }
                }

                keyValuePairs.Add(true, null);

                // CustomMessageBox.Show("Email sent successfully.");
                return keyValuePairs;
            }
            catch (Exception ex)
            {
                keyValuePairs.Add(false, ex.Message);
                // CustomMessageBox.Show("Error sending email: " + ex.Message);
                return keyValuePairs;
            }
        }
        
        public static void PhoneNumberVerify(string name, string phoneNumber, string otpCode)
        {

        }
    }
}
