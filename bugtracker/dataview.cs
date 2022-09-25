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
    public partial class dataview : UserControl
    {
        public dataview()
        {
            InitializeComponent();
        }

        usercontrollogic ucl = new usercontrollogic();

        private void dataview_Load(object sender, EventArgs e)
        {
            DataTable dt = ucl.getdata();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
