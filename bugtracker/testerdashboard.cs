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
    public partial class testerdashboard : Form
    {
        public testerdashboard()
        {
            InitializeComponent();
        }
        string un;
        string user_id;
        public void getusername(string username, string id)
        {
            this.un = username;
            this.user_id = id;

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addbug ab = new addbug();
            testerpanel.Controls.Clear();
            testerpanel.Controls.Add(ab);
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search r = new search();
            testerpanel.Controls.Clear();
            testerpanel.Controls.Add(r);
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin l = new frmlogin();
            this.Close();
            l.Show();
        }

        private void uPDATESTATUSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update u = new update();
            testerpanel.Controls.Clear();
            testerpanel.Controls.Add(u);
        }
    }
}
