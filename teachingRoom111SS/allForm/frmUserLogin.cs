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
    public partial class frmUserLogin : Form
    {
        public frmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin" && txtPassword.Text == "admin") {
                frmDashboard fm = new frmDashboard();
                fm.Show();
                this.Hide();
            }
            else
            {
                if (txtUserName.Text != "admin")
                {
                    lblShowUserName.Visible = true;
                    txtUserName.Focus();
                }
                else
                {
                    lblShowUserName.Visible = false;
                }
                if (txtPassword.Text != "admin")
                {
                    lblShowPassword.Visible = true;
                    txtUserName.Focus();
                }
                else
                {
                    lblShowPassword.Visible = false;
                }
            }

        }
    }
}
