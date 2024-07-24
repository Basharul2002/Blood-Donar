namespace Blood_Donar
{
    partial class DonarInformation
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
            this.name_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.email_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.phone_number_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.city_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.blood_group_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Montserrat", 10F);
            this.name_label.Location = new System.Drawing.Point(19, 11);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(51, 18);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Name :";
            this.name_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // email_label
            // 
            this.email_label.BackColor = System.Drawing.Color.Transparent;
            this.email_label.Font = new System.Drawing.Font("Montserrat", 10F);
            this.email_label.Location = new System.Drawing.Point(19, 28);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(49, 18);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "Email : ";
            this.email_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // phone_number_label
            // 
            this.phone_number_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_number_label.Font = new System.Drawing.Font("Montserrat", 10F);
            this.phone_number_label.Location = new System.Drawing.Point(19, 45);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(110, 18);
            this.phone_number_label.TabIndex = 0;
            this.phone_number_label.Text = "Phone Number :";
            this.phone_number_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // city_label
            // 
            this.city_label.BackColor = System.Drawing.Color.Transparent;
            this.city_label.Font = new System.Drawing.Font("Montserrat", 10F);
            this.city_label.Location = new System.Drawing.Point(19, 60);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(37, 18);
            this.city_label.TabIndex = 0;
            this.city_label.Text = "City :";
            this.city_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // blood_group_label
            // 
            this.blood_group_label.BackColor = System.Drawing.Color.Transparent;
            this.blood_group_label.Font = new System.Drawing.Font("Montserrat", 10F);
            this.blood_group_label.Location = new System.Drawing.Point(19, 77);
            this.blood_group_label.Name = "blood_group_label";
            this.blood_group_label.Size = new System.Drawing.Size(93, 18);
            this.blood_group_label.TabIndex = 0;
            this.blood_group_label.Text = "Blood Group :";
            this.blood_group_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // DonarInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.Controls.Add(this.blood_group_label);
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.phone_number_label);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.name_label);
            this.Name = "DonarInformation";
            this.Size = new System.Drawing.Size(323, 111);
            this.Click += new System.EventHandler(this.profile_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel name_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel email_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel phone_number_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel city_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel blood_group_label;
    }
}
