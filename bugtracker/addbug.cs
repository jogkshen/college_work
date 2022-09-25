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
    public partial class addbug : UserControl
    {
        public addbug()
        {
            InitializeComponent();
        }
        public string bug_id { get; set; }

        public string username { get; set; }

        string date = DateTime.Now.ToString();

        usercontrollogic ucl = new usercontrollogic();
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadderror_Click(object sender, EventArgs e)
        {
            if (txtinput.Text == "" || txtexpected.Text == "" || txtoutput.Text == "" || txtbugid.Text == "")
            {
                MessageBox.Show("please fill the field first");
            }
            else if (txtinput.Text == "" || txtinput.Text == null)
            {
                MessageBox.Show("please fill the input first");

            }
            else if (txtexpected.Text == "" || txtexpected.Text == null)
            {
                MessageBox.Show("please fill the expected first");

            }
            else if (txtoutput.Text == "" || txtoutput.Text == null)
            {
                MessageBox.Show("please fill the output first");

            }
            else if (txtbugid.Text == "" || txtbugid.Text == null)
            {
                MessageBox.Show("please fill the bug id first");

            }

            else
            {
                int sbc = ucl.inputtest(txtinput.Text, txtexpected.Text, txtoutput.Text, txtbugid.Text, date, textcode.Text);
                if (sbc > 0)
                {
                    MessageBox.Show("added");
                    txtinput.Clear(); txtexpected.Clear(); txtoutput.Clear();
                    
                }
                else
                {
                    MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addbug_Load(object sender, EventArgs e)
        {
            DataTable dt = ucl.getdata();
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0) {
                DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];

                txtbugid.Text = rows.Cells[1].Value.ToString();
                textcode.Text = rows.Cells[8].Value.ToString();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow rows = dataGridView1.Rows[e.RowIndex];

                txtbugid.Text = rows.Cells[0].Value.ToString();
                textcode.Text = rows.Cells[8].Value.ToString();
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtbugid.Clear();
            txtinput.Clear();
            txtexpected.Clear();
            txtoutput.Clear();
        }
    }
}
