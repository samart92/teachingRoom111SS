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
    public partial class ucProductCard : UserControl
    {
        public ucProductCard(string proName,string sku,string prices)
        {
            InitializeComponent();
            lblProName.Text = proName;
            lblPrices.Text = prices;
            lblSKU.Text = sku;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ucSellingItem selling = new ucSellingItem(lblProName.Text, lblPrices.Text);
            frmDashboard fm = (frmDashboard)Application.OpenForms["frmDashboard"];
            fm.flowLayoutPanel3.Controls.Add(selling);


            
        }
    }
}
