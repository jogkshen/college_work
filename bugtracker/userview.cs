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
    public partial class userview : UserControl
    {
        public userview()
        {
            InitializeComponent();
        }
        usercontrollogic ucl = new usercontrollogic();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userview_Load(object sender, EventArgs e)
        {
            DataTable dt = ucl.getuser();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            userupdate frm = new userupdate();

            frm.txtusername.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtpassword.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.cmbusertype.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtemail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtaddress.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.Show();
            this.Hide();

        }
    }
}
