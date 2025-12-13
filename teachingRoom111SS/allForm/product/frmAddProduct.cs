using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teachingRoom111SS.allForm.product
{
    public partial class frmAddProduct : Form
    {

        Products product = new Products();
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            product.Insert(1, txtSku.Text,txtProName.Text, Convert.ToDouble(txtPrice.Text),Convert.ToDouble(txtRate.Text), Convert.ToInt16(chbActive.Checked));

            product.SelectAll(dataGridView1);
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            product.SelectAll(dataGridView1);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            product.SelectByProductName(dataGridView1,txtSearch.Text);
        }
    }
}
