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
            flowLayoutPanel2.Visible = true;
            panel4.Visible = true;
            GetAllProductCart();
            GetAllCategory();
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
            flowLayoutPanel2.Visible = false;
            panel4.Visible = false;
            


        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            
        }

        private void GetAllProductCart()
        {
            flowLayoutPanel1.Controls.Clear();
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
            flowLayoutPanel2.Controls.Clear();
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

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            string orders_ID = null;
            string[] totalprice = lblTotalPrice.Text.Split('$');
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            string sql = $"INSERT INTO `tborders`( `cashier_id`, `status`, `opened_at`, `closed_at`, `subtotal`, `tax_total`, `discount_total`, `grand_total`) VALUES ('1','1','{DateTime.Today.ToString("yyyy-MM-dd h:mm:ss")}','{DateTime.Today.ToString("yyyy-MM-dd h:mm:ss")}','{Convert.ToDouble(totalprice[1])}','0','0','{Convert.ToDouble(totalprice[1])}')";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            orders_ID = cm.LastInsertedId.ToString();
            cn.Close();



            //MessageBox.Show(orders_ID);
            

            foreach (ucSellingItem item in flowLayoutPanel3.Controls)
            {
                //insert data to tborder_items
                string sql1 = $"INSERT INTO `tborder_items`( `order_id`, `Product_id`, `name_snapshot`, `unit_price`, `qty`, `line_subtotal`, `tax_amount`, `discount_amount`, `line_total`) VALUES ('{orders_ID}','1','{item.lblProName.Text}','1','1','1','0','0','1')";
                MySqlCommand cm1 = new MySqlCommand(sql1, cn);
                cn.Open();
                cm1.ExecuteNonQuery();
                cn.Close();
            }


        }

        private void btnDashbord_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Visible = false;
            panel4.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            ucSellingInformation uc = new ucSellingInformation("revene","10");
            flowLayoutPanel1.Controls.Add(uc);
        }
    }
}
