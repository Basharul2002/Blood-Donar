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
    public partial class DashBoardForm : Form
    {
        public int id;
        static DashBoardForm obj;
        
        public DashBoardForm()
        {
            InitializeComponent();
        }

        public DashBoardForm(int id) : this()
        {
            this.id = id;
        }

        public static DashBoardForm Instance
        {
            get
            {
                if (obj == null)
                    obj = new DashBoardForm();

                return obj;
            }
        }

        public Guna2Panel panelContainer
        {
            get { return data_panel; }
            set { data_panel = value; }
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            obj = this;
        }

        private void log_out_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private void donar_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            Donar donar = new Donar(this.id);
            donar.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(donar);   
        }


        private void profile_btn_Click(object sender, EventArgs e)
        {
            Instance.panelContainer.Controls.Clear();
            Profile profile = new Profile(true, this.id);
            profile.Dock = DockStyle.Fill;
            Instance.panelContainer.Controls.Add(profile);
        }
    }
}
