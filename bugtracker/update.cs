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
    public partial class update : UserControl
    {
        public update()
        {
            InitializeComponent();
        }

        usercontrollogic ucl = new usercontrollogic();
        private void update_Load(object sender, EventArgs e)
        {
            DataTable dt = ucl.getdata();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = ucl.getupdate(bug_idtext.Text, cmbupdate.Text);
            if (i > 0) {
                MessageBox.Show("Updated");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string bug_id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            bug_idtext.Text = bug_id;

            }
        }
    }
