using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace bugtracker
{
    public partial class admindashboard : Form
    {
        public admindashboard()
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

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r = new register();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(r);
        }

        private void admindashboard_Load(object sender, EventArgs e)
        {

        }

        private void uSERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            userview uv = new userview();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(uv);
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search s = new search();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(s);
        }

        private void lOGOUTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmlogin l = new frmlogin();
            this.Hide();
            l.Show();
        }

        private void rEPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataview dv = new dataview();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(dv);

        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userupdate uu = new userupdate();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(uu);
        }

        private void addResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addresult ar = new addresult();
            admindisplay.Controls.Clear();
            admindisplay.Controls.Add(ar);

        }
    }
}
