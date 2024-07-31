namespace Blood_Donar
{
    partial class Change
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.otp_panel = new System.Windows.Forms.Panel();
            this.resend_btn = new Guna.UI2.WinForms.Guna2Button();
            this.verify_btn = new Guna.UI2.WinForms.Guna2Button();
            this.verification_code_warning_label = new System.Windows.Forms.Label();
            this.way_number_label = new System.Windows.Forms.Label();
            this.way_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.otp_code_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.update_phone_number_panel = new System.Windows.Forms.Panel();
            this.phoneNumber_next_btn = new Guna.UI2.WinForms.Guna2Button();
            this.phone_number_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.update_email_panel = new System.Windows.Forms.Panel();
            this.email_add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.email_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.add_email_label = new System.Windows.Forms.Label();
            this.add_email_warning_message_label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.otp_panel.SuspendLayout();
            this.update_phone_number_panel.SuspendLayout();
            this.update_email_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.otp_panel);
            this.panel1.Controls.Add(this.update_phone_number_panel);
            this.panel1.Controls.Add(this.update_email_panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 246);
            this.panel1.TabIndex = 0;
            // 
            // otp_panel
            // 
            this.otp_panel.Controls.Add(this.resend_btn);
            this.otp_panel.Controls.Add(this.verify_btn);
            this.otp_panel.Controls.Add(this.verification_code_warning_label);
            this.otp_panel.Controls.Add(this.way_number_label);
            this.otp_panel.Controls.Add(this.way_label);
            this.otp_panel.Controls.Add(this.label9);
            this.otp_panel.Controls.Add(this.otp_code_tb);
            this.otp_panel.Controls.Add(this.timer_label);
            this.otp_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.otp_panel.Location = new System.Drawing.Point(0, 484);
            this.otp_panel.Name = "otp_panel";
            this.otp_panel.Size = new System.Drawing.Size(467, 241);
            this.otp_panel.TabIndex = 8;
            // 
            // resend_btn
            // 
            this.resend_btn.BackColor = System.Drawing.Color.Transparent;
            this.resend_btn.BorderRadius = 15;
            this.resend_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.resend_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.resend_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.resend_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.resend_btn.FillColor = System.Drawing.Color.IndianRed;
            this.resend_btn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.resend_btn.ForeColor = System.Drawing.Color.White;
            this.resend_btn.Location = new System.Drawing.Point(113, 191);
            this.resend_btn.Name = "resend_btn";
            this.resend_btn.Size = new System.Drawing.Size(100, 35);
            this.resend_btn.TabIndex = 16;
            this.resend_btn.Text = "RESEND";
            this.resend_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.resend_btn.UseTransparentBackground = true;
            this.resend_btn.Click += new System.EventHandler(this.resend_btn_Click);
            // 
            // verify_btn
            // 
            this.verify_btn.BackColor = System.Drawing.Color.Transparent;
            this.verify_btn.BorderRadius = 15;
            this.verify_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.verify_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.verify_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.verify_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.verify_btn.FillColor = System.Drawing.Color.IndianRed;
            this.verify_btn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.verify_btn.ForeColor = System.Drawing.Color.White;
            this.verify_btn.Location = new System.Drawing.Point(262, 192);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(100, 35);
            this.verify_btn.TabIndex = 17;
            this.verify_btn.Text = "VERIFY";
            this.verify_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.verify_btn.UseTransparentBackground = true;
            this.verify_btn.Click += new System.EventHandler(this.verify_btn_Click);
            // 
            // verification_code_warning_label
            // 
            this.verification_code_warning_label.AutoSize = true;
            this.verification_code_warning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_code_warning_label.ForeColor = System.Drawing.Color.Red;
            this.verification_code_warning_label.Location = new System.Drawing.Point(57, 150);
            this.verification_code_warning_label.Name = "verification_code_warning_label";
            this.verification_code_warning_label.Size = new System.Drawing.Size(81, 17);
            this.verification_code_warning_label.TabIndex = 15;
            this.verification_code_warning_label.Text = "Invalid OTP";
            this.verification_code_warning_label.Visible = false;
            // 
            // way_number_label
            // 
            this.way_number_label.AutoSize = true;
            this.way_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.way_number_label.Location = new System.Drawing.Point(127, 55);
            this.way_number_label.Name = "way_number_label";
            this.way_number_label.Size = new System.Drawing.Size(200, 20);
            this.way_number_label.TabIndex = 14;
            this.way_number_label.Text = "basharulalam6@gmail.com";
            // 
            // way_label
            // 
            this.way_label.AutoSize = true;
            this.way_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.way_label.Location = new System.Drawing.Point(61, 34);
            this.way_label.Name = "way_label";
            this.way_label.Size = new System.Drawing.Size(349, 20);
            this.way_label.TabIndex = 13;
            this.way_label.Text = "We sent an email with your confirmation code to \r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(80, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 31);
            this.label9.TabIndex = 12;
            this.label9.Text = "Enter Confirmation Code";
            // 
            // otp_code_tb
            // 
            this.otp_code_tb.Animated = true;
            this.otp_code_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.otp_code_tb.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.otp_code_tb.BorderThickness = 2;
            this.otp_code_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otp_code_tb.DefaultText = "";
            this.otp_code_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otp_code_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otp_code_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_code_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_code_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_code_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otp_code_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otp_code_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_code_tb.Location = new System.Drawing.Point(61, 111);
            this.otp_code_tb.Name = "otp_code_tb";
            this.otp_code_tb.PasswordChar = '\0';
            this.otp_code_tb.PlaceholderText = "Enter the OTP Code";
            this.otp_code_tb.SelectedText = "";
            this.otp_code_tb.Size = new System.Drawing.Size(315, 36);
            this.otp_code_tb.TabIndex = 11;
            // 
            // timer_label
            // 
            this.timer_label.BackColor = System.Drawing.Color.Transparent;
            this.timer_label.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(61, 85);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(285, 20);
            this.timer_label.TabIndex = 10;
            this.timer_label.Text = "Please enter the code with in 00:00:00";
            // 
            // update_phone_number_panel
            // 
            this.update_phone_number_panel.Controls.Add(this.phoneNumber_next_btn);
            this.update_phone_number_panel.Controls.Add(this.phone_number_tb);
            this.update_phone_number_panel.Controls.Add(this.label5);
            this.update_phone_number_panel.Controls.Add(this.label6);
            this.update_phone_number_panel.Controls.Add(this.label7);
            this.update_phone_number_panel.Controls.Add(this.label8);
            this.update_phone_number_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.update_phone_number_panel.Location = new System.Drawing.Point(0, 241);
            this.update_phone_number_panel.Name = "update_phone_number_panel";
            this.update_phone_number_panel.Size = new System.Drawing.Size(467, 243);
            this.update_phone_number_panel.TabIndex = 6;
            // 
            // phoneNumber_next_btn
            // 
            this.phoneNumber_next_btn.BackColor = System.Drawing.Color.Transparent;
            this.phoneNumber_next_btn.BorderRadius = 15;
            this.phoneNumber_next_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_next_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.phoneNumber_next_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.phoneNumber_next_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.phoneNumber_next_btn.FillColor = System.Drawing.Color.IndianRed;
            this.phoneNumber_next_btn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.phoneNumber_next_btn.ForeColor = System.Drawing.Color.White;
            this.phoneNumber_next_btn.Location = new System.Drawing.Point(158, 193);
            this.phoneNumber_next_btn.Name = "phoneNumber_next_btn";
            this.phoneNumber_next_btn.Size = new System.Drawing.Size(100, 35);
            this.phoneNumber_next_btn.TabIndex = 19;
            this.phoneNumber_next_btn.Text = "NEXT";
            this.phoneNumber_next_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.phoneNumber_next_btn.UseTransparentBackground = true;
            this.phoneNumber_next_btn.Click += new System.EventHandler(this.phoneNumber_next_btn_Click);
            // 
            // phone_number_tb
            // 
            this.phone_number_tb.Animated = true;
            this.phone_number_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.phone_number_tb.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.phone_number_tb.BorderThickness = 2;
            this.phone_number_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_number_tb.DefaultText = "";
            this.phone_number_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_number_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_number_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phone_number_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phone_number_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number_tb.Location = new System.Drawing.Point(32, 121);
            this.phone_number_tb.Name = "phone_number_tb";
            this.phone_number_tb.PasswordChar = '\0';
            this.phone_number_tb.PlaceholderText = "";
            this.phone_number_tb.SelectedText = "";
            this.phone_number_tb.Size = new System.Drawing.Size(351, 36);
            this.phone_number_tb.TabIndex = 5;
            this.phone_number_tb.TextChanged += new System.EventHandler(this.phone_number_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label5.Location = new System.Drawing.Point(28, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Enter Phone Number";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(29, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Please enter new email";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label7.Location = new System.Drawing.Point(12, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(434, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "We’ll use this phone number across all of your accounts\r\nin Accounts Center to pe" +
    "rsonalize experiences";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(92, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(290, 31);
            this.label8.TabIndex = 4;
            this.label8.Text = "Update Phone Number";
            // 
            // update_email_panel
            // 
            this.update_email_panel.Controls.Add(this.email_add_btn);
            this.update_email_panel.Controls.Add(this.email_tb);
            this.update_email_panel.Controls.Add(this.add_email_label);
            this.update_email_panel.Controls.Add(this.add_email_warning_message_label);
            this.update_email_panel.Controls.Add(this.label13);
            this.update_email_panel.Controls.Add(this.label14);
            this.update_email_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.update_email_panel.Location = new System.Drawing.Point(0, 0);
            this.update_email_panel.Name = "update_email_panel";
            this.update_email_panel.Size = new System.Drawing.Size(467, 241);
            this.update_email_panel.TabIndex = 0;
            // 
            // email_add_btn
            // 
            this.email_add_btn.BackColor = System.Drawing.Color.Transparent;
            this.email_add_btn.BorderRadius = 15;
            this.email_add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.email_add_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.email_add_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.email_add_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.email_add_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.email_add_btn.FillColor = System.Drawing.Color.IndianRed;
            this.email_add_btn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.email_add_btn.ForeColor = System.Drawing.Color.White;
            this.email_add_btn.Location = new System.Drawing.Point(158, 197);
            this.email_add_btn.Name = "email_add_btn";
            this.email_add_btn.Size = new System.Drawing.Size(100, 35);
            this.email_add_btn.TabIndex = 19;
            this.email_add_btn.Text = "NEXT";
            this.email_add_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.email_add_btn.UseTransparentBackground = true;
            this.email_add_btn.Click += new System.EventHandler(this.email_add_btn_Click);
            // 
            // email_tb
            // 
            this.email_tb.Animated = true;
            this.email_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.email_tb.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.email_tb.BorderThickness = 2;
            this.email_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_tb.DefaultText = "";
            this.email_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.email_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Location = new System.Drawing.Point(32, 121);
            this.email_tb.Name = "email_tb";
            this.email_tb.PasswordChar = '\0';
            this.email_tb.PlaceholderText = "";
            this.email_tb.SelectedText = "";
            this.email_tb.Size = new System.Drawing.Size(351, 36);
            this.email_tb.TabIndex = 5;
            this.email_tb.TextChanged += new System.EventHandler(this.email_tb_TextChanged);
            // 
            // add_email_label
            // 
            this.add_email_label.AutoSize = true;
            this.add_email_label.Font = new System.Drawing.Font("Montserrat", 11F);
            this.add_email_label.Location = new System.Drawing.Point(28, 98);
            this.add_email_label.Name = "add_email_label";
            this.add_email_label.Size = new System.Drawing.Size(162, 19);
            this.add_email_label.TabIndex = 1;
            this.add_email_label.Text = "Enter Email Address";
            this.add_email_label.Visible = false;
            // 
            // add_email_warning_message_label
            // 
            this.add_email_warning_message_label.AutoSize = true;
            this.add_email_warning_message_label.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.add_email_warning_message_label.ForeColor = System.Drawing.Color.Red;
            this.add_email_warning_message_label.Location = new System.Drawing.Point(29, 160);
            this.add_email_warning_message_label.Name = "add_email_warning_message_label";
            this.add_email_warning_message_label.Size = new System.Drawing.Size(147, 15);
            this.add_email_warning_message_label.TabIndex = 2;
            this.add_email_warning_message_label.Text = "Please enter new email";
            this.add_email_warning_message_label.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Montserrat", 11F);
            this.label13.Location = new System.Drawing.Point(12, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(448, 38);
            this.label13.TabIndex = 3;
            this.label13.Text = "We’ll use this email address across all of your accounts in \r\nAccounts Center to " +
    "personalize experiences";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(92, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(283, 31);
            this.label14.TabIndex = 4;
            this.label14.Text = "Update Email Address";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(484, 246);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change";
            this.panel1.ResumeLayout(false);
            this.otp_panel.ResumeLayout(false);
            this.otp_panel.PerformLayout();
            this.update_phone_number_panel.ResumeLayout(false);
            this.update_phone_number_panel.PerformLayout();
            this.update_email_panel.ResumeLayout(false);
            this.update_email_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel update_email_panel;
        private System.Windows.Forms.Label add_email_label;
        private System.Windows.Forms.Label add_email_warning_message_label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TextBox email_tb;
        private System.Windows.Forms.Panel otp_panel;
        private Guna.UI2.WinForms.Guna2Button resend_btn;
        private Guna.UI2.WinForms.Guna2Button verify_btn;
        private System.Windows.Forms.Label verification_code_warning_label;
        private System.Windows.Forms.Label way_number_label;
        private System.Windows.Forms.Label way_label;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox otp_code_tb;
        private Guna.UI2.WinForms.Guna2HtmlLabel timer_label;
        private System.Windows.Forms.Panel update_phone_number_panel;
        private Guna.UI2.WinForms.Guna2TextBox phone_number_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button email_add_btn;
        private System.Windows.Forms.Timer timer;
        private Guna.UI2.WinForms.Guna2Button phoneNumber_next_btn;
    }
}