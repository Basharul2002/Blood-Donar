namespace Blood_Donar
{
    partial class LoginPage
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
            this.password_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.email_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.login_button = new Guna.UI2.WinForms.Guna2Button();
            this.sign = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.warning_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_toggle_btn = new Guna.UI2.WinForms.Guna2Button();
            this.recover_password_btn = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // password_tb
            // 
            this.password_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_tb.BorderThickness = 0;
            this.password_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_tb.DefaultText = "";
            this.password_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_tb.ForeColor = System.Drawing.Color.Black;
            this.password_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_tb.Location = new System.Drawing.Point(52, 223);
            this.password_tb.Name = "password_tb";
            this.password_tb.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.password_tb.PasswordChar = '●';
            this.password_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.password_tb.PlaceholderText = "Password";
            this.password_tb.SelectedText = "";
            this.password_tb.Size = new System.Drawing.Size(260, 36);
            this.password_tb.TabIndex = 7;
            // 
            // email_tb
            // 
            this.email_tb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.email_tb.Location = new System.Drawing.Point(52, 161);
            this.email_tb.Name = "email_tb";
            this.email_tb.PasswordChar = '\0';
            this.email_tb.PlaceholderForeColor = System.Drawing.Color.RosyBrown;
            this.email_tb.PlaceholderText = "Email";
            this.email_tb.SelectedText = "";
            this.email_tb.Size = new System.Drawing.Size(292, 36);
            this.email_tb.TabIndex = 8;
            // 
            // login_button
            // 
            this.login_button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BorderColor = System.Drawing.Color.Red;
            this.login_button.BorderRadius = 20;
            this.login_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_button.FillColor = System.Drawing.Color.IndianRed;
            this.login_button.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Location = new System.Drawing.Point(112, 325);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(180, 45);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Login";
            this.login_button.UseTransparentBackground = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // sign
            // 
            this.sign.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sign.BackColor = System.Drawing.Color.Transparent;
            this.sign.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sign.Location = new System.Drawing.Point(150, 80);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(109, 35);
            this.sign.TabIndex = 5;
            this.sign.Text = "SIGN IN";
            // 
            // warning_label
            // 
            this.warning_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warning_label.BackColor = System.Drawing.Color.Transparent;
            this.warning_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.warning_label.ForeColor = System.Drawing.Color.Red;
            this.warning_label.Location = new System.Drawing.Point(52, 265);
            this.warning_label.Name = "warning_label";
            this.warning_label.Size = new System.Drawing.Size(173, 18);
            this.warning_label.TabIndex = 9;
            this.warning_label.Text = "Invalid Email or Password";
            // 
            // password_toggle_btn
            // 
            this.password_toggle_btn.BackColor = System.Drawing.Color.Transparent;
            this.password_toggle_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.password_toggle_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.password_toggle_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.password_toggle_btn.FillColor = System.Drawing.Color.White;
            this.password_toggle_btn.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.password_toggle_btn.ForeColor = System.Drawing.Color.Transparent;
            this.password_toggle_btn.Image = global::Blood_Donar.Properties.Resources.show;
            this.password_toggle_btn.Location = new System.Drawing.Point(312, 223);
            this.password_toggle_btn.Margin = new System.Windows.Forms.Padding(0);
            this.password_toggle_btn.Name = "password_toggle_btn";
            this.password_toggle_btn.Size = new System.Drawing.Size(34, 36);
            this.password_toggle_btn.TabIndex = 27;
            this.password_toggle_btn.TextOffset = new System.Drawing.Point(0, 20);
            this.password_toggle_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.password_toggle_btn.UseTransparentBackground = true;
            this.password_toggle_btn.Click += new System.EventHandler(this.password_toggle_btn_Click);
            // 
            // recover_password_btn
            // 
            this.recover_password_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.recover_password_btn.AutoSize = true;
            this.recover_password_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recover_password_btn.Font = new System.Drawing.Font("Montserrat", 9F, System.Drawing.FontStyle.Bold);
            this.recover_password_btn.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.recover_password_btn.LinkColor = System.Drawing.Color.Black;
            this.recover_password_btn.Location = new System.Drawing.Point(49, 297);
            this.recover_password_btn.Name = "recover_password_btn";
            this.recover_password_btn.Size = new System.Drawing.Size(125, 15);
            this.recover_password_btn.TabIndex = 30;
            this.recover_password_btn.TabStop = true;
            this.recover_password_btn.Text = "Recover Password?";
            this.recover_password_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.recover_password_btn_LinkClicked);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.recover_password_btn);
            this.Controls.Add(this.password_toggle_btn);
            this.Controls.Add(this.warning_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.sign);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(400, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox password_tb;
        private Guna.UI2.WinForms.Guna2TextBox email_tb;
        private Guna.UI2.WinForms.Guna2Button login_button;
        private Guna.UI2.WinForms.Guna2HtmlLabel sign;
        private Guna.UI2.WinForms.Guna2HtmlLabel warning_label;
        private Guna.UI2.WinForms.Guna2Button password_toggle_btn;
        private System.Windows.Forms.LinkLabel recover_password_btn;
    }
}
