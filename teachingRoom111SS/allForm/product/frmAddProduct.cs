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
        string id = string.Empty;
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            //MessageBox.Show(id);
            product.Delete(Convert.ToInt16(id));

            product.SelectAll(dataGridView1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSku.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtProName.Text= dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text= dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtRate.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            product.Update(1, txtSku.Text, txtProName.Text, Convert.ToDouble( txtPrice.Text), Convert.ToDouble(txtRate.Text),1, Convert.ToInt16(id));
            product.SelectAll(dataGridView1);
        }
    }
}
