using MySql.Data;
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
using teachingRoom111SS.allForm;
using teachingRoom111SS.allForm.product;
using teachingRoom111SS.userControll;

namespace teachingRoom111SS
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            frmUserLogin fm = new frmUserLogin();
            fm.Show();


           
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            frmOrders fm = new frmOrders();
            fm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           frmAddProduct fm = new frmAddProduct();
            fm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory fm = new frmInventory();
            fm.Show();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            GetAllProductCart();
            GetAllCategory();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void GetAllProductCart()
        {
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            string sql = "SELECT * FROM `tbproducts`";
            MySqlCommand cm = new MySqlCommand(sql, cn);            
            cn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read()) {
                ucProductCard uc = new ucProductCard($"{dr.GetValue(3).ToString()}", $"{dr.GetValue(2)}", $"$ {dr.GetValue(4)}");
                flowLayoutPanel1.Controls.Add(uc);
            }
            cn.Close();
        }


        private void GetAllCategory()
        {
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            string sql = "SELECT * FROM `tbcategories`";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            MySqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                var uc = new ucCategory($"{dr.GetValue(1).ToString()}", $"{dr.GetValue(0).ToString()}");
                flowLayoutPanel2.Controls.Add(uc);
            }
            cn.Close();
        }
    }
}
