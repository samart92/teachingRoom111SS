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
    public partial class ucCategory : UserControl
    {
        public ucCategory(string name)
        {
            InitializeComponent();
            tbnCategory.Text = name;
        }

        private void tbnCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
