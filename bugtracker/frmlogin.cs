using System;
using System.Data;
using System.Windows.Forms;
using BLL;
namespace bugtracker
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }
        
        usercontrollogic ucl = new usercontrollogic();
        private void btnlogin_Click(object sender, EventArgs e)
        {
            admindashboard ad = new admindashboard();
            ad.Show();
            //string username = txtusername.Text;

            //if (txtusername.Text == "" || txtusername.Text == null)
            //{
            //    MessageBox.Show("please fill the username", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    txtusername.Focus();

            //}
            //else if (txtpassword.Text == "" || txtpassword.Text == null)
            //{
            //    MessageBox.Show("please fill password", "Empty textbox", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //else
            //{
            //    DataTable dt = ucl.getdatafromuser(txtusername.Text, txtpassword.Text);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string user_id = (dt.Rows[0]["user_id"].ToString());
            //        if (dt.Rows[0][3].ToString() == "admin")
            //        {
            //            MessageBox.Show("login success");
            //            admindashboard ds = new admindashboard();
            //            ds.getusername(user_id, username);
            //            ds.Visible = true;
            //        }
            //        else if (dt.Rows[0][3].ToString() == "teacher")
            //        {
            //            MessageBox.Show("login success");
            //            developerdashboard td = new developerdashboard();
            //            td.getusername(user_id, username);
            //            td.Visible = true;
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid username and password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //   }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtusername.Clear();
            txtpassword.Clear();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
    }
    }

