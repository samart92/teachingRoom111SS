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
    public partial class ucSellingInformation : UserControl
    {
        public ucSellingInformation(string _name,string _number, string _url= "https://img.icons8.com/sf-black-filled/1200/image.jpg")
        {
            InitializeComponent();
            lblName.Text = _name;
            lblNumber.Text = _number;
            ptbIcon.ImageLocation = _url;
        }
    }
}
