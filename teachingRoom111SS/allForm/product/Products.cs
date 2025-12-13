using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingRoom111SS.allForm.product
{
    public class Products
    {

        MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
        public void Insert(int catagory,string sku, string ProductName,double price, double texRate,int status)
        {       
            string sql = $"INSERT INTO `tbproducts`( `categoryID`, `sku`, `productName`, `prices`, `texRate`, `isActive`, `createAt`) VALUES ('{catagory}','{sku}','{ProductName}','{price}','{texRate}','{status}','{DateTime.Today.ToString("yyyy-MM-dd")}')";            
            MySqlCommand cm = new MySqlCommand(sql, cn);            
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void Delete(int id)
        {
            string sql = $"DELETE FROM `tbproducts` WHERE id='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void Update(int catagory, string sku, string ProductName, double price, double texRate, int status,int id)
        {
            string sql = $"UPDATE `tbproducts` SET `categoryID`='{catagory}',`sku`='{sku}',`productName`='{ProductName}',`prices`='{price}',`texRate`='{texRate}',`isActive`='{status}' WHERE `id`='{id}'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();

        }
        public void SelectAll(DataGridView dg)
        {            
            string sql = "SELECT * FROM `tbproducts`";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            cn.Close();

            dg.DataSource = dt;
        }
        public void SelectByProductName(DataGridView dg,string name)
        {
            string sql = $"SELECT * FROM `tbproducts` WHERE `productName` like '%{name}%'";
            MySqlCommand cm = new MySqlCommand(sql, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cn.Open();
            da.Fill(dt);
            cn.Close();

            dg.DataSource = dt;

        }
    }
}
