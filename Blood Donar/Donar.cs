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
    public partial class Donar : UserControl
    {
        private string email;

        public Donar()
        {
            InitializeComponent();
            
        }

        public Donar(string email) : this()
        {
            this.email = email;
            List<Data> allDonar = Manager.DonarInformationManager();

            DataShow(allDonar);
        }


        private void DataBaseDataShow()
        {
            DonarInformation donarInformation;
            result_panel.Controls.Clear();


            DataBase dataBase = new DataBase();
            string query = $"SELECT * FROM [User Information] WHEHE [Email] != {this.email}";
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);
            if (string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class: Donar Funcion: DataBaseDataShow \nException: {error}");
                return;
            }

            if (dataTable.Rows.Count < 0)
            {
                MessageBox.Show("No Data Found");
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                donarInformation = new DonarInformation(name: dataTable.Columns["Name"].ToString(), email: dataTable.Columns["Email"].ToString(), phoneNumber: dataTable.Columns["Phone Number"].ToString(), city: dataTable.Columns["City"].ToString(), bloodGroup: dataTable.Columns["Blood Group"].ToString());
                result_panel.Controls.Add(donarInformation);
            }
        }


        private void DataBaseSearch()
        {
            DonarInformation donarInformation;
            result_panel.Controls.Clear();


            DataBase dataBase = new DataBase();
            string query = $"SELECT * FROM [User Information] WHEHE ";

            if (string.IsNullOrWhiteSpace(city_tb.Text) || blood_group_cb.SelectedIndex == 0)
                return;

            if (blood_group_cb.SelectedIndex != 0)
                query += $"[Blood Group] = {blood_group_cb.Text}";
            if (!string.IsNullOrWhiteSpace(city_tb.Text))
                query += $"[City] = {city_tb.Text}";

            
            string error;
            DataTable dataTable = dataBase.DataAccess(query + ";", out error);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                donarInformation = new DonarInformation(name: dataTable.Columns[0].ToString(), email: dataTable.Columns[1].ToString(), phoneNumber: dataTable.Columns[2].ToString(), city: dataTable.Columns[3].ToString(), bloodGroup: dataTable.Columns[4].ToString());
                result_panel.Controls.Add(donarInformation);
            }
        }

        private void DataShow(List<Data> allDonar)
        {
            DonarInformation donarInformation;
            result_panel.Controls.Clear();
            foreach (Data data in allDonar)
            {
                if (data.Email != this.email)
                {
                    donarInformation = new DonarInformation(name: data.Name, email: data.Email, phoneNumber: data.PhoneNumber, city: data.City, bloodGroup: data.BloodGroup);
                    result_panel.Controls.Add(donarInformation);
                }
               
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            List<Data> allDonar = Manager.DonarInformationManager();
            List<Data> searchDonar = new List<Data> { };

            for ( int i = 0; i < allDonar.Count; i++)
            {

                if (!string.IsNullOrWhiteSpace(city_tb.Text) && blood_group_cb.SelectedIndex != 0)
                {
                    if (allDonar[i].City == city_tb.Text && allDonar[i].BloodGroup == blood_group_cb.Text)
                        searchDonar.Add(new Data { Name = allDonar[i].Name, Email = allDonar[i].Email, PhoneNumber = allDonar[i].PhoneNumber, BloodGroup = allDonar[i].BloodGroup, City = allDonar[i].City, Password = allDonar[i].Password });

                }

                else if (!string.IsNullOrWhiteSpace(city_tb.Text) && blood_group_cb.SelectedIndex == 0)
                {
                    if (allDonar[i].City == city_tb.Text)
                        searchDonar.Add(new Data { Name = allDonar[i].Name, Email = allDonar[i].Email, PhoneNumber = allDonar[i].PhoneNumber, BloodGroup = allDonar[i].BloodGroup, City = allDonar[i].City, Password = allDonar[i].Password });

                }

                else if (blood_group_cb.SelectedIndex != 0 && string.IsNullOrWhiteSpace(city_tb.Text))
                {
                    if (allDonar[i].BloodGroup == blood_group_cb.Text)
                        searchDonar.Add(new Data { Name = allDonar[i].Name, Email = allDonar[i].Email, PhoneNumber = allDonar[i].PhoneNumber, BloodGroup = allDonar[i].BloodGroup, City = allDonar[i].City, Password = allDonar[i].Password });
                        
                }

                
            }

            DataShow(searchDonar);
        }
    }
}
