using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLL;
using ICSharpCode.TextEditor.Document;

namespace bugtracker
{
    public partial class addfile : UserControl
    {
        public addfile()
        {
            InitializeComponent();
        }

        public string userid { get; set; }

        public string username { get; set; }

        string reported_date = DateTime.Now.ToString();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        usercontrollogic ucl = new usercontrollogic();
        //private void btnaddfile_Click(object sender, EventArgs e)
        //{
        //    if (txtbugname.Text == "" ||  txtcomments.Text == "" || lblfile.Text == "")
        //    {
        //        MessageBox.Show("please fill the cell first");
        //    }
        //    else if(txtbugname.Text == "" || txtbugname.Text == null)
        //    {
        //        MessageBox.Show("please fill the bugname first");
        //    }
        //    if (txtcomments.Text == "" || txtcomments.Text == null)
        //    {
        //        MessageBox.Show("please fill the comment first");
        //    }
        //    if (lblfile.Text == "" || lblfile.Text == null)
        //    {
        //        MessageBox.Show("please fill the file first");
        //    }
        //    else
        //    {
        //        int sbc = ucl.inputdatafile(txtbugname.Text, userid, username,txtcomments.Text, reported_date, lblfile.Text, txtcode.Text);
        //        if (sbc > 0)
        //        {
        //            MessageBox.Show("login success");
        //            txtbugname.Clear(); txtcomments.Clear();
                    
        //        }
        //        else
        //        {
        //            MessageBox.Show("Invalid", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }


        //    }
        //}

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string folderpath = "C:\\ERRORFILE";
            if (!Directory.Exists(folderpath))
            {
                Directory.CreateDirectory(folderpath);
            }

            string filelocation = openFileDialog1.FileName;
            File.Copy(filelocation, Path.Combine("C:\\ERRORFILE", Path.GetFileName(filelocation)), true);
            lblfile.Text = filelocation.ToString();

        }

        private void txtcomments_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcode_Load(object sender, EventArgs e)
        {
            string dirc = Application.StartupPath;
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dirc))
            {

                fsmp = new FileSyntaxModeProvider(dirc);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                txtcode.SetHighlighting("C#");

            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            txtbugname.Clear();
          
            txtcomments.Clear();
            
        }
    }
}
