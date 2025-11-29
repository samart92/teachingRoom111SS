using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace teachingRoom111SS.allForm.user
{
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //insert new user to table user
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            //insert
            string sql = $"INSERT INTO `tbuser`( `fullName`, `role`, `pinCode`, `isActive`, `CreatedAt`) VALUES ('{txtUserName.Text}','{cbbRole.SelectedItem}','{txtPinCode.Text}','0','{DateTime.Today.ToString("yyyy-MM-dd")}')";
            // command  insert delete update
            MySqlCommand cm = new MySqlCommand(sql, cn);

            //open
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();

            //reload data
            GetAllUser();

        }

        private void GetAllUser()
        {
            MySqlConnection cnn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            string sql = "SELECT * FROM tbuser";
            MySqlCommand cm = new MySqlCommand( sql, cnn );
            MySqlDataAdapter da = new MySqlDataAdapter(cm);
            DataTable dt = new DataTable();
            cnn.Open();
            da.Fill( dt );
            cnn.Close();

            dataGridView1.DataSource = dt;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //insert new user to table user
            MySqlConnection cn = new MySqlConnection(Properties.Settings.Default.MySqlDB);
            //insert
            string sql = $"DELETE FROM tbuser WHERE id='{txtID.Text}'";
            // command  insert delete update
            MySqlCommand cm = new MySqlCommand(sql, cn);

            //open
            cn.Open();
            cm.ExecuteNonQuery();
            cn.Close();

            //reload data
            GetAllUser();
        }

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            GetAllUser();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
