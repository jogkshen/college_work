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
    public partial class search : UserControl
    {
        public search()
        {
            InitializeComponent();
        }

        usercontrollogic ucl = new usercontrollogic();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch.Text == "" || txtsearch.Text == null )
            {
                MessageBox.Show("please fill the cell first");
            }
            else
            {
                string bugname = txtsearch.Text;

                DataTable searchresult = ucl.SearchBug(bugname);
                if (searchresult.Rows.Count > 0)
                {
                    dataGridView1.DataSource = searchresult;
                }
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtsearch.Clear();
        }
    }
}
