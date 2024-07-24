using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blood_Donar
{
    public partial class HomePage : Form
    {
        static HomePage obj;
        public HomePage()
        {
            InitializeComponent();
        }

        
        public static HomePage Instance
        {
            get
            {
                if (obj == null)
                    obj = new HomePage();

                return obj;
            }
        }

        public Guna2Panel leftPanelContainer
        {
            get { return left_panel; }
            set { left_panel = value; }
        }


        public Guna2Panel rightPanelContainer
        {
            get { return right_panel; }
            set { right_panel = value; }
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            obj = this;
            IntialDesign();
        }


        private void IntialDesign()
        {
            // For Login page
            leftPanelContainer.Controls.Clear();
            LoginPage login_Page = new LoginPage(this);
            login_Page.Dock = DockStyle.Fill;
            leftPanelContainer.Controls.Add(login_Page);


            // Right side for Intial Resitration Form
            rightPanelContainer.Controls.Clear();
            ResistrationInitialPage resistration_Initial_Panel = new ResistrationInitialPage(this);
            resistration_Initial_Panel.Dock = DockStyle.Fill;
            rightPanelContainer.Controls.Add(resistration_Initial_Panel);
        }
    }
}
