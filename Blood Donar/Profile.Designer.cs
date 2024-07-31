namespace Blood_Donar
{
    partial class Profile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.warning_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.sign = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phone_number_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.city_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.blood_group_cb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gender_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.others_btn = new System.Windows.Forms.RadioButton();
            this.female_btn = new System.Windows.Forms.RadioButton();
            this.male_btn = new System.Windows.Forms.RadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.change_phone_number_button = new System.Windows.Forms.LinkLabel();
            this.change_email_button = new System.Windows.Forms.LinkLabel();
            this.verify_email = new System.Windows.Forms.LinkLabel();
            this.verify_phone_number = new System.Windows.Forms.LinkLabel();
            this.user_profile_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.change_password_btn = new Guna.UI2.WinForms.Guna2Button();
            this.donar_profile_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.gender_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.city_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.blood_group_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phone_number_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.email_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.name_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.gender_panel.SuspendLayout();
            this.user_profile_panel.SuspendLayout();
            this.donar_profile_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // warning_label
            // 
            this.warning_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.warning_label.BackColor = System.Drawing.Color.Transparent;
            this.warning_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(2, 55);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(43, 18);
            this.warning_label.TabIndex = 14;
            this.warning_label.Text = "Name";
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update_btn.BackColor = System.Drawing.Color.Transparent;
            this.update_btn.BorderColor = System.Drawing.Color.Red;
            this.update_btn.BorderRadius = 20;
            this.update_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.update_btn.Enabled = false;
            this.update_btn.FillColor = System.Drawing.Color.IndianRed;
            this.update_btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F);
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.Location = new System.Drawing.Point(333, 333);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(140, 45);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "UPDATE";
            this.update_btn.UseTransparentBackground = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // sign
            // 
            this.sign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sign.BackColor = System.Drawing.Color.Transparent;
            this.sign.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(289, -129);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(122, 35);
            this.sign.TabIndex = 10;
            this.sign.Text = "PROFILE";
            // 
            // name_tb
            // 
            this.name_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name_tb.DefaultText = "";
            this.name_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.name_tb.ForeColor = System.Drawing.Color.Black;
            this.name_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name_tb.Location = new System.Drawing.Point(2, 90);
            this.name_tb.Name = "name_tb";
            this.name_tb.PasswordChar = '\0';
            this.name_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.name_tb.PlaceholderText = "Password";
            this.name_tb.SelectedText = "";
            this.name_tb.Size = new System.Drawing.Size(305, 36);
            this.name_tb.TabIndex = 12;
            this.name_tb.TextChanged += new System.EventHandler(this.name_tb_TextChanged);
            // 
            // email_tb
            // 
            this.email_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_tb.DefaultText = "";
            this.email_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.email_tb.ForeColor = System.Drawing.Color.Black;
            this.email_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_tb.Location = new System.Drawing.Point(2, 150);
            this.email_tb.Name = "email_tb";
            this.email_tb.PasswordChar = '\0';
            this.email_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.email_tb.PlaceholderText = "Password";
            this.email_tb.SelectedText = "";
            this.email_tb.Size = new System.Drawing.Size(305, 36);
            this.email_tb.TabIndex = 15;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(372, 55);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(101, 18);
            this.guna2HtmlLabel2.TabIndex = 18;
            this.guna2HtmlLabel2.Text = "Phone Number";
            // 
            // phone_number_tb
            // 
            this.phone_number_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_number_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone_number_tb.DefaultText = "";
            this.phone_number_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone_number_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone_number_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone_number_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.phone_number_tb.ForeColor = System.Drawing.Color.Black;
            this.phone_number_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone_number_tb.Location = new System.Drawing.Point(372, 79);
            this.phone_number_tb.Name = "phone_number_tb";
            this.phone_number_tb.PasswordChar = '\0';
            this.phone_number_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.phone_number_tb.PlaceholderText = "Password";
            this.phone_number_tb.SelectedText = "";
            this.phone_number_tb.Size = new System.Drawing.Size(284, 36);
            this.phone_number_tb.TabIndex = 17;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(2, 212);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(31, 18);
            this.guna2HtmlLabel3.TabIndex = 20;
            this.guna2HtmlLabel3.Text = "City";
            // 
            // city_tb
            // 
            this.city_tb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.city_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.city_tb.DefaultText = "";
            this.city_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.city_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.city_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.city_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.city_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.city_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.city_tb.ForeColor = System.Drawing.Color.Black;
            this.city_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.city_tb.Location = new System.Drawing.Point(2, 236);
            this.city_tb.Name = "city_tb";
            this.city_tb.PasswordChar = '\0';
            this.city_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.city_tb.PlaceholderText = "Password";
            this.city_tb.SelectedText = "";
            this.city_tb.Size = new System.Drawing.Size(305, 36);
            this.city_tb.TabIndex = 19;
            this.city_tb.TextChanged += new System.EventHandler(this.city_tb_TextChanged);
            // 
            // blood_group_cb
            // 
            this.blood_group_cb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blood_group_cb.BackColor = System.Drawing.Color.Transparent;
            this.blood_group_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.blood_group_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blood_group_cb.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.blood_group_cb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.blood_group_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.blood_group_cb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.blood_group_cb.ItemHeight = 30;
            this.blood_group_cb.Items.AddRange(new object[] {
            "Type",
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-",
            "Golden"});
            this.blood_group_cb.Location = new System.Drawing.Point(372, 167);
            this.blood_group_cb.Name = "blood_group_cb";
            this.blood_group_cb.Size = new System.Drawing.Size(144, 36);
            this.blood_group_cb.StartIndex = 0;
            this.blood_group_cb.TabIndex = 22;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(372, 143);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(84, 18);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Blood Group";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(372, 214);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(51, 18);
            this.guna2HtmlLabel6.TabIndex = 14;
            this.guna2HtmlLabel6.Text = "Gender";
            // 
            // gender_panel
            // 
            this.gender_panel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gender_panel.Controls.Add(this.others_btn);
            this.gender_panel.Controls.Add(this.female_btn);
            this.gender_panel.Controls.Add(this.male_btn);
            this.gender_panel.Location = new System.Drawing.Point(372, 236);
            this.gender_panel.Name = "gender_panel";
            this.gender_panel.Size = new System.Drawing.Size(314, 25);
            this.gender_panel.TabIndex = 23;
            // 
            // others_btn
            // 
            this.others_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.others_btn.AutoSize = true;
            this.others_btn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.others_btn.Location = new System.Drawing.Point(194, 4);
            this.others_btn.Name = "others_btn";
            this.others_btn.Size = new System.Drawing.Size(76, 19);
            this.others_btn.TabIndex = 0;
            this.others_btn.TabStop = true;
            this.others_btn.Tag = "2";
            this.others_btn.Text = "OTHERS";
            this.others_btn.UseVisualStyleBackColor = true;
            this.others_btn.CheckedChanged += new System.EventHandler(this.gender_radio_btn_CheckedChanged);
            // 
            // female_btn
            // 
            this.female_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.female_btn.AutoSize = true;
            this.female_btn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.female_btn.Location = new System.Drawing.Point(93, 4);
            this.female_btn.Name = "female_btn";
            this.female_btn.Size = new System.Drawing.Size(76, 19);
            this.female_btn.TabIndex = 0;
            this.female_btn.TabStop = true;
            this.female_btn.Tag = "2";
            this.female_btn.Text = "FEMALE";
            this.female_btn.UseVisualStyleBackColor = true;
            this.female_btn.CheckedChanged += new System.EventHandler(this.gender_radio_btn_CheckedChanged);
            // 
            // male_btn
            // 
            this.male_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.male_btn.AutoSize = true;
            this.male_btn.Font = new System.Drawing.Font("Montserrat", 9F);
            this.male_btn.Location = new System.Drawing.Point(5, 4);
            this.male_btn.Name = "male_btn";
            this.male_btn.Size = new System.Drawing.Size(61, 19);
            this.male_btn.TabIndex = 0;
            this.male_btn.TabStop = true;
            this.male_btn.Tag = "1";
            this.male_btn.Text = "MALE";
            this.male_btn.UseVisualStyleBackColor = true;
            this.male_btn.CheckedChanged += new System.EventHandler(this.gender_radio_btn_CheckedChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(2, 127);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(38, 17);
            this.guna2HtmlLabel1.TabIndex = 16;
            this.guna2HtmlLabel1.Text = "Email";
            // 
            // change_phone_number_button
            // 
            this.change_phone_number_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.change_phone_number_button.AutoSize = true;
            this.change_phone_number_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_phone_number_button.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.change_phone_number_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.change_phone_number_button.LinkColor = System.Drawing.Color.Black;
            this.change_phone_number_button.Location = new System.Drawing.Point(372, 118);
            this.change_phone_number_button.Name = "change_phone_number_button";
            this.change_phone_number_button.Size = new System.Drawing.Size(155, 15);
            this.change_phone_number_button.TabIndex = 28;
            this.change_phone_number_button.TabStop = true;
            this.change_phone_number_button.Text = "Change Phone Number?";
            this.change_phone_number_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.change_phone_number_button_LinkClicked);
            // 
            // change_email_button
            // 
            this.change_email_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.change_email_button.AutoSize = true;
            this.change_email_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_email_button.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.change_email_button.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.change_email_button.LinkColor = System.Drawing.Color.Black;
            this.change_email_button.Location = new System.Drawing.Point(1, 189);
            this.change_email_button.Name = "change_email_button";
            this.change_email_button.Size = new System.Drawing.Size(98, 15);
            this.change_email_button.TabIndex = 29;
            this.change_email_button.TabStop = true;
            this.change_email_button.Text = "Change Email?";
            this.change_email_button.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.change_email_button_LinkClicked);
            this.change_email_button.Click += new System.EventHandler(this.change_email_button_Click);
            // 
            // verify_email
            // 
            this.verify_email.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verify_email.AutoSize = true;
            this.verify_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify_email.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.verify_email.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.verify_email.LinkColor = System.Drawing.Color.Black;
            this.verify_email.Location = new System.Drawing.Point(311, 161);
            this.verify_email.Name = "verify_email";
            this.verify_email.Size = new System.Drawing.Size(43, 15);
            this.verify_email.TabIndex = 29;
            this.verify_email.TabStop = true;
            this.verify_email.Text = "Verify";
            this.verify_email.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.verify_email_LinkClicked);
            // 
            // verify_phone_number
            // 
            this.verify_phone_number.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.verify_phone_number.AutoSize = true;
            this.verify_phone_number.Cursor = System.Windows.Forms.Cursors.Hand;
            this.verify_phone_number.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.verify_phone_number.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.verify_phone_number.LinkColor = System.Drawing.Color.Black;
            this.verify_phone_number.Location = new System.Drawing.Point(658, 90);
            this.verify_phone_number.Name = "verify_phone_number";
            this.verify_phone_number.Size = new System.Drawing.Size(43, 15);
            this.verify_phone_number.TabIndex = 29;
            this.verify_phone_number.TabStop = true;
            this.verify_phone_number.Text = "Verify";
            this.verify_phone_number.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.verify_phone_number_LinkClicked);
            // 
            // user_profile_panel
            // 
            this.user_profile_panel.Controls.Add(this.change_password_btn);
            this.user_profile_panel.Controls.Add(this.update_btn);
            this.user_profile_panel.Controls.Add(this.verify_phone_number);
            this.user_profile_panel.Controls.Add(this.verify_email);
            this.user_profile_panel.Controls.Add(this.change_email_button);
            this.user_profile_panel.Controls.Add(this.change_phone_number_button);
            this.user_profile_panel.Controls.Add(this.gender_panel);
            this.user_profile_panel.Controls.Add(this.blood_group_cb);
            this.user_profile_panel.Controls.Add(this.guna2HtmlLabel3);
            this.user_profile_panel.Controls.Add(this.city_tb);
            this.user_profile_panel.Controls.Add(this.guna2HtmlLabel2);
            this.user_profile_panel.Controls.Add(this.phone_number_tb);
            this.user_profile_panel.Controls.Add(this.guna2HtmlLabel1);
            this.user_profile_panel.Controls.Add(this.email_tb);
            this.user_profile_panel.Controls.Add(this.guna2HtmlLabel6);
            this.user_profile_panel.Controls.Add(this.guna2HtmlLabel5);
            this.user_profile_panel.Controls.Add(this.warning_label);
            this.user_profile_panel.Controls.Add(this.name_tb);
            this.user_profile_panel.Controls.Add(this.sign);
            this.user_profile_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.user_profile_panel.Location = new System.Drawing.Point(0, 0);
            this.user_profile_panel.Name = "user_profile_panel";
            this.user_profile_panel.Size = new System.Drawing.Size(681, 439);
            this.user_profile_panel.TabIndex = 30;
            // 
            // change_password_btn
            // 
            this.change_password_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.change_password_btn.BackColor = System.Drawing.Color.Transparent;
            this.change_password_btn.BorderColor = System.Drawing.Color.Red;
            this.change_password_btn.BorderRadius = 20;
            this.change_password_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.change_password_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.change_password_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.change_password_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.change_password_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.change_password_btn.FillColor = System.Drawing.Color.IndianRed;
            this.change_password_btn.Font = new System.Drawing.Font("Franklin Gothic Heavy", 10F);
            this.change_password_btn.ForeColor = System.Drawing.Color.White;
            this.change_password_btn.Location = new System.Drawing.Point(131, 333);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(140, 45);
            this.change_password_btn.TabIndex = 11;
            this.change_password_btn.Text = "Change Password";
            this.change_password_btn.UseTransparentBackground = true;
            this.change_password_btn.Click += new System.EventHandler(this.change_password_btn_Click);
            // 
            // donar_profile_panel
            // 
            this.donar_profile_panel.Controls.Add(this.gender_label);
            this.donar_profile_panel.Controls.Add(this.city_label);
            this.donar_profile_panel.Controls.Add(this.blood_group_label);
            this.donar_profile_panel.Controls.Add(this.phone_number_label);
            this.donar_profile_panel.Controls.Add(this.email_label);
            this.donar_profile_panel.Controls.Add(this.name_label);
            this.donar_profile_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.donar_profile_panel.Location = new System.Drawing.Point(0, 439);
            this.donar_profile_panel.Name = "donar_profile_panel";
            this.donar_profile_panel.Size = new System.Drawing.Size(681, 288);
            this.donar_profile_panel.TabIndex = 31;
            // 
            // gender_label
            // 
            this.gender_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gender_label.BackColor = System.Drawing.Color.Transparent;
            this.gender_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.gender_label.ForeColor = System.Drawing.Color.Red;
            this.gender_label.Location = new System.Drawing.Point(2, 222);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(51, 18);
            this.gender_label.TabIndex = 15;
            this.gender_label.Text = "Gender";
            // 
            // city_label
            // 
            this.city_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.city_label.BackColor = System.Drawing.Color.Transparent;
            this.city_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.city_label.ForeColor = System.Drawing.Color.Red;
            this.city_label.Location = new System.Drawing.Point(2, 181);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(31, 18);
            this.city_label.TabIndex = 15;
            this.city_label.Text = "City";
            // 
            // blood_group_label
            // 
            this.blood_group_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.blood_group_label.BackColor = System.Drawing.Color.Transparent;
            this.blood_group_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.blood_group_label.ForeColor = System.Drawing.Color.Red;
            this.blood_group_label.Location = new System.Drawing.Point(2, 140);
            this.blood_group_label.Name = "blood_group_label";
            this.blood_group_label.Size = new System.Drawing.Size(88, 18);
            this.blood_group_label.TabIndex = 15;
            this.blood_group_label.Text = "Blood Group: ";
            // 
            // phone_number_label
            // 
            this.phone_number_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.phone_number_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_number_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.phone_number_label.ForeColor = System.Drawing.Color.Red;
            this.phone_number_label.Location = new System.Drawing.Point(2, 103);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(105, 18);
            this.phone_number_label.TabIndex = 15;
            this.phone_number_label.Text = "Phone Number:";
            // 
            // email_label
            // 
            this.email_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.email_label.ForeColor = System.Drawing.Color.Red;
            this.email_label.Location = new System.Drawing.Point(2, 68);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(41, 18);
            this.email_label.TabIndex = 15;
            this.email_label.Text = "Email";
            // 
            // name_label
            // 
            this.name_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.Red;
            this.name_label.Location = new System.Drawing.Point(2, 30);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(43, 18);
            this.name_label.TabIndex = 15;
            this.name_label.Text = "Name";
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.donar_profile_panel);
            this.Controls.Add(this.user_profile_panel);
            this.Name = "Profile";
            this.Size = new System.Drawing.Size(681, 499);
            this.gender_panel.ResumeLayout(false);
            this.gender_panel.PerformLayout();
            this.user_profile_panel.ResumeLayout(false);
            this.user_profile_panel.PerformLayout();
            this.donar_profile_panel.ResumeLayout(false);
            this.donar_profile_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel warning_label;
        private Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel sign;
        private Guna.UI2.WinForms.Guna2TextBox name_tb;
        private Guna.UI2.WinForms.Guna2TextBox email_tb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox phone_number_tb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox city_tb;
        private Guna.UI2.WinForms.Guna2ComboBox blood_group_cb;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2Panel gender_panel;
        private System.Windows.Forms.RadioButton male_btn;
        private System.Windows.Forms.RadioButton others_btn;
        private System.Windows.Forms.RadioButton female_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.LinkLabel change_phone_number_button;
        private System.Windows.Forms.LinkLabel change_email_button;
        private System.Windows.Forms.LinkLabel verify_email;
        private System.Windows.Forms.LinkLabel verify_phone_number;
        private Guna.UI2.WinForms.Guna2Panel user_profile_panel;
        private Guna.UI2.WinForms.Guna2Panel donar_profile_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel city_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel blood_group_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel phone_number_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel email_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel name_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel gender_label;
        private Guna.UI2.WinForms.Guna2Button change_password_btn;
    }
}
