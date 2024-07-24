namespace Blood_Donar
{
    partial class UserProfile
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
            this.city_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_label.BackColor = System.Drawing.Color.Transparent;
            this.name_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.Color.Red;
            this.name_label.Location = new System.Drawing.Point(30, 20);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 18);
            this.name_label.TabIndex = 19;
            this.name_label.Text = "Name :";
            this.name_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // city_label
            // 
            this.city_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.city_label.BackColor = System.Drawing.Color.Transparent;
            this.city_label.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Bold);
            this.city_label.ForeColor = System.Drawing.Color.Red;
            this.city_label.Location = new System.Drawing.Point(30, 48);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(35, 18);
            this.city_label.TabIndex = 19;
            this.city_label.Text = "City: ";
            this.city_label.Click += new System.EventHandler(this.profile_Click);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.city_label);
            this.Controls.Add(this.name_label);
            this.Name = "UserProfile";
            this.Size = new System.Drawing.Size(456, 86);
            this.Click += new System.EventHandler(this.profile_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel name_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel city_label;
    }
}
