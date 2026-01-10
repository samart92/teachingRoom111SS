using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingRoom111SS.userControll
{
    public partial class ucCategory : UserControl
    {
        string id = null;
        public ucCategory(string name,string _id)
        {
            InitializeComponent();
            tbnCategory.Text = name;
            id = _id;
        }

        private void tbnCategory_Click(object sender, EventArgs e)
        {
            frmDashboard fm = (frmDashboard)Application.OpenForms["frmDashboard"];
            fm.flowLayoutPanel1.Controls.Clear();

            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            string sql = $"SELECT * FROM `tbproducts` WHERE categoryID='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ucProductCard uc = new ucProductCard($"{dr.GetValue(3).ToString()}", $"{dr.GetValue(2)}", $"$ {dr.GetValue(4)}");
                
                fm.flowLayoutPanel1.Controls.Add(uc);
            }
            cn.Close();


        }
    }
}
