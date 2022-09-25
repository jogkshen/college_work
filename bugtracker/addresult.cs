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
    public partial class addresult : UserControl
    {
        public addresult()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addresult_Load(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
        usercontrollogic u = new usercontrollogic();
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cmbclass.Text == "" || cmbterm.Text == "" || txtname.Text == "" || txtroll.Text == "" || txtenglish.Text == "" || txtengpractical.Text == "" || txtnepali.Text == "" || txtmath.Text == "" || txtscience.Text == "" || txtscipractical.Text == "" || txtsocial.Text == "" || txtsopractical.Text == "" || txtoptenglish.Text == "" || txtoccupation.Text == "" || txtoccupractical.Text == "" || txtmoral.Text == "" || txtmopractical.Text == "" || txtcomputer.Text == "" || txtcompractical.Text == "" || txthealth.Text == "" || txthepractical.Text == "" || txtopt.Text == "" || txtaccount.Text == "" || txtaccpractical.Text == "")
            {
                MessageBox.Show("please fill the cell first");
            }
            else if (cmbclass.Text == "" || cmbclass.Text == null)
            {
                MessageBox.Show("please fill the class");
            }
            else if (cmbterm.Text == "" || cmbterm.Text == null)
            {
                MessageBox.Show("please fill the term");
            }
            else if (txtname.Text == "" || txtname.Text == null)
            {
                MessageBox.Show("please fill the name");
            }
            else if (txtroll.Text == "" || txtroll.Text == null)
            {
                MessageBox.Show("please fill the roll");
            }

            else
            {
                int sbc = u.inputdataresult(cmbclass.Text, cmbterm.Text, txtname.Text, txtroll.Text, txtenglish.Text, txtengpractical.Text, txtnepali.Text, txtmath.Text, txtscience.Text, txtscipractical.Text, txtsocial.Text, txtsopractical.Text, txtoptenglish.Text, txtoccupation.Text, txtoccupractical.Text, txtmoral.Text, txtmopractical.Text, txtcomputer.Text, txtcomputer.Text, txthealth.Text, txthepractical.Text, txtopt.Text, txtaccount.Text, txtaccpractical.Text);
                if (sbc > 0)
                {
                    MessageBox.Show("user added");

                }
                else
                {
                    MessageBox.Show("Invalid username and password", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
