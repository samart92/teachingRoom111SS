using MySql.Data;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingRoom111SS.allForm
{

    // data base name : teachingroom111ss2025

    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            //connection string
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            //insert
            string sql = "INSERT INTO tbuser(fullname) VALUES('Sam Art')";
            // command  insert delete update
            MySqlCommand cm = new MySqlCommand(sql, cn);

            //open
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();



           




        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            //insert
            string sql = $"DELETE FROM tbuser WHERE id='{textBox1.Text}'";
            // command  insert delete update
            MySqlCommand cm = new MySqlCommand(sql, cn);

            //open
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();



        }
    }
}
