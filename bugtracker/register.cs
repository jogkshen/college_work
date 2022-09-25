using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace bugtracker
{
    public partial class register : UserControl
    {
        public register()
        {
            InitializeComponent();
        }
        usercontrollogic ucl = new usercontrollogic();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "" || txtpassword.Text == "" || cmbusertype.Text == "")
            {
                MessageBox.Show("please fill the cell first");
            }
            else if(txtusername.Text == "" || txtusername.Text == null)
            {
                MessageBox.Show("please fill the username");
            }
            else if (txtpassword.Text == "" || txtpassword.Text == null)
            {
                MessageBox.Show("please fill the password");
            }
            else if (cmbusertype.Text == "" || cmbusertype.Text == null)
            {
                MessageBox.Show("please fill the usertype");
            }
          
            else
            {
                int sbc = ucl.inputdatauser(txtusername.Text, txtpassword.Text, cmbusertype.Text);
                if (sbc > 0)
                {
                    MessageBox.Show("user added");
                    txtusername.Clear();txtpassword.Clear();
                }
                else
                {
                    MessageBox.Show("Invalid username and password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {

        }
    }
}
