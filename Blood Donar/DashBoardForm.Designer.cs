namespace Blood_Donar
{
    partial class DashBoardForm
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
            this.data_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.donar_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.profile_btn = new Guna.UI2.WinForms.Guna2Button();
            this.data_panel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_panel
            // 
            this.data_panel.Controls.Add(this.guna2Panel2);
            this.data_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_panel.Location = new System.Drawing.Point(0, 48);
            this.data_panel.Name = "data_panel";
            this.data_panel.Size = new System.Drawing.Size(800, 402);
            this.data_panel.TabIndex = 1;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 402);
            this.guna2Panel2.TabIndex = 0;
            // 
            // donar_btn
            // 
            this.donar_btn.BackColor = System.Drawing.Color.Transparent;
            this.donar_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.donar_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.donar_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.donar_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.donar_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.donar_btn.FillColor = System.Drawing.Color.IndianRed;
            this.donar_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.donar_btn.ForeColor = System.Drawing.Color.White;
            this.donar_btn.Location = new System.Drawing.Point(3, 3);
            this.donar_btn.Name = "donar_btn";
            this.donar_btn.Size = new System.Drawing.Size(144, 42);
            this.donar_btn.TabIndex = 0;
            this.donar_btn.Text = "Donar";
            this.donar_btn.UseTransparentBackground = true;
            this.donar_btn.Click += new System.EventHandler(this.donar_btn_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button2.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(153, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(144, 42);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Messages";
            this.guna2Button2.UseTransparentBackground = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.Controls.Add(this.guna2Button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Button2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.donar_btn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2Panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 48);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Button1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(303, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(144, 42);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "Log Out";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(450, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(255, 48);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.profile_btn);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(255, 48);
            this.guna2Panel3.TabIndex = 6;
            // 
            // profile_btn
            // 
            this.profile_btn.BackColor = System.Drawing.Color.Transparent;
            this.profile_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profile_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profile_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profile_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profile_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profile_btn.FillColor = System.Drawing.Color.IndianRed;
            this.profile_btn.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold);
            this.profile_btn.ForeColor = System.Drawing.Color.White;
            this.profile_btn.Location = new System.Drawing.Point(0, 0);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.Size = new System.Drawing.Size(255, 48);
            this.profile_btn.TabIndex = 5;
            this.profile_btn.Text = "Profile";
            this.profile_btn.UseTransparentBackground = true;
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // DashBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_panel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashBoardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.data_panel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel data_panel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button donar_btn;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button profile_btn;
    }
}