using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

namespace SchoolBase
{
    public partial class mainForm : Form
    {
        public mainForm(string userName, string userPassword, string connetionString) // bool check
        {
            InitializeComponent();
            /*label1.Text = Name;
            label2.Text = Password;
            label3.Text = (check) ? "Checked)" : "Unchecked)";*/

            label1.Text = userName;
            label2.Text = userPassword;

        }
    }
    
}
