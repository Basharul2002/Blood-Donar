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
    public partial class ResistrationInitialPage : UserControl
    {

        private HomePage homePage;
        public ResistrationInitialPage()
        {
            InitializeComponent();
        }

        public ResistrationInitialPage(HomePage homePage) : this()
        {
            this.homePage = homePage;
        }

        private void sign_up_btn_Click(object sender, EventArgs e)
        {
            if ((!HomePage.Instance.rightPanelContainer.Controls.ContainsKey("ResistrationForm")) && (!HomePage.Instance.leftPanelContainer.Controls.ContainsKey("LoginInitialForm")))
            {
                HomePage.Instance.leftPanelContainer.Controls.Clear();
                HomePage.Instance.rightPanelContainer.Controls.Clear();

                LoginInitialForm loginInitialForm = new LoginInitialForm(homePage);
                loginInitialForm.Dock = DockStyle.Fill;
                HomePage.Instance.leftPanelContainer.Controls.Add(loginInitialForm);

                ResistrationForm resistrationForm = new ResistrationForm(homePage);
                resistrationForm.Dock = DockStyle.Fill;
                HomePage.Instance.rightPanelContainer.Controls.Add(resistrationForm);   
            }
            
        }
    }
}
