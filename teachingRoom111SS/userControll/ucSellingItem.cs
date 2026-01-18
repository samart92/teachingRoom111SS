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
    public partial class ucSellingItem : UserControl
    {
        int count = 1;
        string[] price;

        frmDashboard fm = (frmDashboard)Application.OpenForms["frmDashboard"];

        public ucSellingItem(string name, string _price)
        {
            InitializeComponent();
            lblProName.Text = name;
            price = _price.Split('$');
            lblPrice.Text = $"{_price} x {count}"; // 10.00 X 2
            lblTotalPrice.Text = "$ " + ( Convert.ToDouble( price[1]) * count).ToString();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] text = fm.lblTotalPrice.Text.Split('$');
            fm.lblTotalPrice.Text = "$" + (Convert.ToDouble(text[1]) + Convert.ToDouble(price[1]));

            count += 1;  
            lblTotalPrice.Text = "$ " + (Convert.ToDouble(price[1]) * count).ToString();
            lblPrice.Text = $"$ {price[1]} x {count}"; // 10.00 X 2
        }

        private void btnSubstruck_Click(object sender, EventArgs e)
        {
            
            if (count > 1)
            {
                string[] text = fm.lblTotalPrice.Text.Split('$');
                fm.lblTotalPrice.Text = "$" + (Convert.ToDouble(text[1]) - Convert.ToDouble(price[1]));
                
                count -= 1;
                
                lblTotalPrice.Text = "$ " + (Convert.ToDouble(price[1]) * count).ToString();
                lblPrice.Text = $"$ {price[1]} x {count}"; // 10.00 X 2}
            }



            }

        private void btnClose_Click(object sender, EventArgs e)
        {        

            string[] text = fm.lblTotalPrice.Text.Split('$');
            fm.lblTotalPrice.Text = "$" + (Convert.ToDouble(text[1]) - (Convert.ToDouble(price[1]) * count));

            fm.flowLayoutPanel3.Controls.Remove(this);
        }
    }
}
