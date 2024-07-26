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
    internal class EmailService
    {

        public static Dictionary<bool, string> SendVerificationEmail(string recipientName, string recipientEmail, string otpCode, bool passwordReset = false, bool verification = false)
        {
            // Email settings
            const string senderEmail = "basharulalamm@gmail.com";
            const string senderPassword = "xvoawtmtomxzuqio";

            string subject = string.Empty, body = string.Empty;
            if (passwordReset)
                body = GenerateRecoverPasswordEmailBody(recipientName, otpCode, out subject);
            else if (verification)
                body =  GenerateVerificationEmailBody(recipientName, otpCode, out subject);

            var result = new Dictionary<bool, string>();

            try
            {
                using (var mail = new MailMessage())
                {
                    mail.From = new MailAddress(senderEmail);
                    mail.To.Add(recipientEmail);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = true; // Enable HTML content

                    using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new NetworkCredential(senderEmail, senderPassword);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);
                    }
                }

                result.Add(true, null);
            }
            catch (Exception ex)
            {
                result.Add(false, ex.Message);
            }

            return result;
        }

        private static string GenerateVerificationEmailBody(string recipientName, string otpCode, out string subject)
        {
            subject = "Email Verification Code - Blood Donor";
            return $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Blood Donor</title>
                <style>
                    body {{ font-family: Arial, sans-serif; }}
                    .email-content {{
                        max-width: 600px;
                        margin: 0 auto;
                        padding: 20px;
                        border: 1px solid #ccc;
                        background-color: #f4f4f4;
                    }}
                    .email-heading {{
                        font-size: 24px;
                        font-weight: bold;
                        margin-bottom: 20px;
                    }}
                    .email-text {{
                        font-size: 16px;
                        line-height: 1.5;
                        margin-bottom: 20px;
                    }}
                    .email-footer {{
                        font-size: 14px;
                        margin-top: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='email-content'>
                    <div class='email-heading'>Dear {recipientName},</div>
                    <div class='email-text'>
                        Thank you for registering with Blood Donor. To complete your registration, please verify your email address by using the following One-Time Password (OTP) code within the next 2 minutes:
                        <br><br>
                        OTP Code: {otpCode}
                        <br><br>
                        Please enter this OTP code on the verification page to complete the email verification process. If you did not register with Blood Donor, please ignore this email.
                        <br><br>
                        Keep this OTP confidential and do not share it with anyone.
                    </div>
                    <div class='email-footer'>
                        If you need further assistance or have any questions, feel free to contact our support team at <a href='mailto:basharulalamm@gmail.com'>basharulalamm@gmail.com</a> or <a href='tel:+01813890622'>+8801 81389 0622</a>.
                        <br><br>
                        Thank you for joining Blood Donor.
                        <br>
                        Best regards,<br>
                        Blood Donor
                    </div>
                </div>
            </body>
            </html>";
        }
    
        private static string GenerateRecoverPasswordEmailBody(string recipientName, string otpCode, out string subject)
        {
            subject = "Password Reset OTP Code - Blood Donor";
            return $@"
            <!DOCTYPE html>
            <html lang='en'>
            <head>
                <meta charset='UTF-8'>
                <meta name='viewport' content='width=device-width, initial-scale=1.0'>
                <title>Blood Donor</title>
                <style>
                    body {{ font-family: Arial, sans-serif; }}
                    .email-content {{
                        max-width: 600px;
                        margin: 0 auto;
                        padding: 20px;
                        border: 1px solid #ccc;
                        background-color: #f4f4f4;
                    }}
                    .email-heading {{
                        font-size: 24px;
                        font-weight: bold;
                        margin-bottom: 20px;
                    }}
                    .email-text {{
                        font-size: 16px;
                        line-height: 1.5;
                        margin-bottom: 20px;
                    }}
                    .email-footer {{
                        font-size: 14px;
                        margin-top: 20px;
                    }}
                </style>
            </head>
            <body>
                <div class='email-content'>
                    <div class='email-heading'>Dear {recipientName},</div>
                    <div class='email-text'>
                        We have received a request to reset your password for your Blood Donor account. To proceed with the password reset, please use the following One-Time Password (OTP) code within the next 2 minutes:
                        <br><br>
                        OTP Code: {otpCode}
                        <br><br>
                        Please enter this OTP code on the password reset page to complete the process. If you didn't request this password reset or if you believe this is a mistake, please ignore this email and take necessary actions to secure your account.
                        <br><br>
                        Please note that this OTP is valid for a limited time and for a single use only. Keep this OTP confidential and do not share it with anyone.
                    </div>
                    <div class='email-footer'>
                        If you need further assistance or have any questions, feel free to contact our support team at <a href='mailto:basharulalamm@gmail.com'>basharulalamm@gmail.com</a> or <a href='tel:+01813890622'>+8801 81389 0622</a>.
                        <br><br>
                        Thank you for using Blood Donor.
                        <br>
                        Best regards,<br>
                        Blood Donor
                    </div>
                </div>
            </body>
            </html>";
        }

        
    }
}
