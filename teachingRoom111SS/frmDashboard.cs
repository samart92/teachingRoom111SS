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
            frmProducts fm = new frmProducts();
            fm.Show();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory fm = new frmInventory();
            fm.Show();
        }
    }
}
