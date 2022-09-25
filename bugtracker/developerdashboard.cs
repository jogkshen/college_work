using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bugtracker
{
    public partial class developerdashboard : Form
    {
        public developerdashboard()
        {
            InitializeComponent();
        }
        string un;
        string id;
        public void getusername(string user_id, string username)
        {
            this.id = user_id.ToString();
            this.un = username.ToString();

        }
        usercontrollogic ucl = new usercontrollogic();

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addfile af = new addfile();
            developerpanel.Controls.Clear();
            af.userid = lbluserid.Text;
            af.username = lblusername.Text;
            developerpanel.Controls.Add(af);
        }

        private void testerdashboard_Load(object sender, EventArgs e)
        {
            lbluserid.Text = id;
            lblusername.Text = un;


        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search r = new search();
            developerpanel.Controls.Clear();
            developerpanel.Controls.Add(r);
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin l = new frmlogin();
            this.Close();
            l.Show();
        }
    }
}
