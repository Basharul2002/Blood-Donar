namespace Blood_Donar
{
    partial class Verify
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
            this.otp_tb = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.way_label = new System.Windows.Forms.Label();
            this.way_number_label = new System.Windows.Forms.Label();
            this.verification_code_warning_label = new System.Windows.Forms.Label();
            this.resend_btn = new Guna.UI2.WinForms.Guna2Button();
            this.verify_btn = new Guna.UI2.WinForms.Guna2Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // otp_tb
            // 
            this.otp_tb.Animated = true;
            this.otp_tb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.otp_tb.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.otp_tb.BorderThickness = 2;
            this.otp_tb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.otp_tb.DefaultText = "";
            this.otp_tb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.otp_tb.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.otp_tb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_tb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.otp_tb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_tb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.otp_tb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.otp_tb.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.otp_tb.Location = new System.Drawing.Point(24, 150);
            this.otp_tb.Name = "otp_tb";
            this.otp_tb.PasswordChar = '\0';
            this.otp_tb.PlaceholderText = "Enter the OTP Code";
            this.otp_tb.SelectedText = "";
            this.otp_tb.Size = new System.Drawing.Size(315, 36);
            this.otp_tb.TabIndex = 3;
            // 
            // timer_label
            // 
            this.timer_label.BackColor = System.Drawing.Color.Transparent;
            this.timer_label.Font = new System.Drawing.Font("Montserrat", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timer_label.Location = new System.Drawing.Point(24, 124);
            this.timer_label.Name = "timer_label";
            this.timer_label.Size = new System.Drawing.Size(357, 20);
            this.timer_label.TabIndex = 2;
            this.timer_label.Text = "Please enter the code within 00:00:00 remaining";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your confirmation code";
            // 
            // way_label
            // 
            this.way_label.AutoSize = true;
            this.way_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.way_label.Location = new System.Drawing.Point(32, 54);
            this.way_label.Name = "way_label";
            this.way_label.Size = new System.Drawing.Size(349, 20);
            this.way_label.TabIndex = 5;
            this.way_label.Text = "We sent an email with your confirmation code to \r\n";
            // 
            // way_number_label
            // 
            this.way_number_label.AutoSize = true;
            this.way_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.way_number_label.Location = new System.Drawing.Point(32, 74);
            this.way_number_label.Name = "way_number_label";
            this.way_number_label.Size = new System.Drawing.Size(200, 20);
            this.way_number_label.TabIndex = 6;
            this.way_number_label.Text = "basharulalam6@gmail.com";
            // 
            // verification_code_warning_label
            // 
            this.verification_code_warning_label.AutoSize = true;
            this.verification_code_warning_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verification_code_warning_label.ForeColor = System.Drawing.Color.Red;
            this.verification_code_warning_label.Location = new System.Drawing.Point(21, 189);
            this.verification_code_warning_label.Name = "verification_code_warning_label";
            this.verification_code_warning_label.Size = new System.Drawing.Size(81, 17);
            this.verification_code_warning_label.TabIndex = 7;
            this.verification_code_warning_label.Text = "Invalid OTP";
            this.verification_code_warning_label.Visible = false;
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
            this.resend_btn.Location = new System.Drawing.Point(70, 237);
            this.resend_btn.Name = "resend_btn";
            this.resend_btn.Size = new System.Drawing.Size(100, 35);
            this.resend_btn.TabIndex = 8;
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
            this.verify_btn.Location = new System.Drawing.Point(219, 238);
            this.verify_btn.Name = "verify_btn";
            this.verify_btn.Size = new System.Drawing.Size(100, 35);
            this.verify_btn.TabIndex = 9;
            this.verify_btn.Text = "VERIFY";
            this.verify_btn.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.verify_btn.UseTransparentBackground = true;
            this.verify_btn.Click += new System.EventHandler(this.verify_btn_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 289);
            this.Controls.Add(this.resend_btn);
            this.Controls.Add(this.verify_btn);
            this.Controls.Add(this.verification_code_warning_label);
            this.Controls.Add(this.way_number_label);
            this.Controls.Add(this.way_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.otp_tb);
            this.Controls.Add(this.timer_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verify";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox otp_tb;
        private Guna.UI2.WinForms.Guna2HtmlLabel timer_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label way_label;
        private System.Windows.Forms.Label way_number_label;
        private System.Windows.Forms.Label verification_code_warning_label;
        private Guna.UI2.WinForms.Guna2Button resend_btn;
        private Guna.UI2.WinForms.Guna2Button verify_btn;
        private System.Windows.Forms.Timer timer;
    }
}