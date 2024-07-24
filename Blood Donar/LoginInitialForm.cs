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
    public partial class LoginInitialForm : UserControl
    {
        private HomePage homePage;
        public LoginInitialForm()
        {
            InitializeComponent();
        }

        public LoginInitialForm(HomePage homePage) : this()
        {
            this.homePage = homePage;
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            if (!HomePage.Instance.leftPanelContainer.Controls.ContainsKey("LoginPage"))
            {
                HomePage.Instance.leftPanelContainer.Controls.Clear();
                LoginPage login_Page = new LoginPage(homePage);
                login_Page.Dock = DockStyle.Fill;
                HomePage.Instance.leftPanelContainer.Controls.Add(login_Page);
            }

            if (!HomePage.Instance.rightPanelContainer.Controls.ContainsKey("ResistrationInitialPage"))
            {
                HomePage.Instance.rightPanelContainer.Controls.Clear();
                ResistrationInitialPage resistration_Initial_Panel = new ResistrationInitialPage(homePage);
                resistration_Initial_Panel.Dock = DockStyle.Fill;
                HomePage.Instance.rightPanelContainer.Controls.Add(resistration_Initial_Panel);
            }
        }

        private void LoginInitialForm_Load(object sender, EventArgs e)
        {

        }
    }
}
