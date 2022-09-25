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
    public partial class userupdate : UserControl
    {
        public userupdate()
        {
            InitializeComponent();
        }
       
        usercontrollogic ucl = new usercontrollogic();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtuserid.Text);
            int i = ucl.updateuser(txtusername.Text, txtpassword.Text, cmbusertype.Text, id);
            if (i > 0)
            {
                MessageBox.Show("user Updated");
                
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtuserid.Text);
            int i = ucl.deleteuser(id);
            if (i > 0)
            {
                MessageBox.Show("User Deleted");
            
            }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string user_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtuserid.Text = user_id;
            string username = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtusername.Text = username;
            string password = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtpassword.Text = password;
            string usertype = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cmbusertype.Text = usertype;
           
        }

        private void userupdate_Load(object sender, EventArgs e)
        {
            DataTable dt = ucl.getuser();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }
    }
}
