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
        private int id;

        public Donar()
        {
            InitializeComponent();
            
        }

        public Donar(int id) : this()
        {
            this.id = id;
            //  List<Data> allDonar = Manager.DonarInformationManager();

            // DataShow(allDonar);
            DataBaseDataShow();
        }


        private void DataBaseDataShow()
        {
            DonarInformation donarInformation;
            result_panel.Controls.Clear();


            DataBase dataBase = new DataBase();
            string query = $"SELECT * FROM [User Information] WHERE [ID] != '{this.id}'";
            string error;
            DataTable dataTable = dataBase.DataAccess(query, out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: Donar Function: DataBaseSearch \nError: {error}");
                return;
            }
            if (dataTable == null)
            {
                MessageBox.Show("No Data Found", "NULL");
                return;
            }

            if (dataTable.Rows.Count <= 0)
            {
                MessageBox.Show("No Data Found", "0");
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                donarInformation = new DonarInformation(id: Convert.ToInt32(dataTable.Rows[i]["ID"]),name: dataTable.Rows[i]["Name"].ToString(), email: dataTable.Rows[i]["Email"].ToString(), phoneNumber: dataTable.Rows[i]["Phone Number"].ToString(), city: dataTable.Rows[i]["City"].ToString(), bloodGroup: dataTable.Rows[i]["Blood Group"].ToString());
                result_panel.Controls.Add(donarInformation);
            }
        }


        private void DataBaseSearch()
        {
            DonarInformation donarInformation;
            result_panel.Controls.Clear();

          //  MessageBox.Show($"blood_group_cb.SelectedIndex: {blood_group_cb.SelectedIndex}");

            DataBase dataBase = new DataBase();
            string query = $"SELECT * FROM [User Information] WHERE ";

            if (string.IsNullOrWhiteSpace(city_tb.Text) && blood_group_cb.SelectedIndex == 0)
                return;
            if (blood_group_cb.SelectedIndex > 0 && !string.IsNullOrWhiteSpace(city_tb.Text))
                query += $"[Blood Group] = {blood_group_cb.SelectedIndex} AND [City] = '{city_tb.Text}'";
            

            else
            {
                if (blood_group_cb.SelectedIndex > 0)
                    query += $"[Blood Group] = {blood_group_cb.SelectedIndex}";
                if (!string.IsNullOrWhiteSpace(city_tb.Text))
                    query += $"[City] = {city_tb.Text}";
            }
            

            
            string error;
            DataTable dataTable = dataBase.DataAccess(query + $"AND [ID] <> '{this.id}';", out error);

            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show($"Class name: Donar Function: DataBaseSearch \nError: {error}");
                return;
            }

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                donarInformation = new DonarInformation(id: Convert.ToInt32(dataTable.Rows[i]["ID"]), name: dataTable.Rows[i]["Name"].ToString(), email: dataTable.Rows[i]["Email"].ToString(), phoneNumber: dataTable.Rows[i]["Phone Number"].ToString(), city: dataTable.Rows[i]["Phone Number"].ToString(), bloodGroup: dataTable.Rows[i]["Blood Group"].ToString());
                result_panel.Controls.Add(donarInformation);
            }
        }


        /*

        private void DataShow(List<Data> allDonar)
        {
            
            DonarInformation donarInformation;
            result_panel.Controls.Clear();
            foreach (Data data in allDonar)
            {
                if (data.Email != this.id)
                {
                    donarInformation = new DonarInformation(name: data.Name, email: data.Email, phoneNumber: data.PhoneNumber, city: data.City, bloodGroup: data.BloodGroup);
                    result_panel.Controls.Add(donarInformation);
                }
               
            }

        }
        */
        private void search_btn_Click(object sender, EventArgs e)
        {
            DataBaseSearch();

            /*
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
            */
        }
        
    }
}
