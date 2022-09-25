namespace bugtracker
{
    partial class addfile
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.developerpanel = new System.Windows.Forms.Panel();
            this.txtcode = new ICSharpCode.TextEditor.TextEditorControl();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnaddfile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblfile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtcomments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbugname = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.developerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // developerpanel
            // 
            this.developerpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.developerpanel.Controls.Add(this.txtcode);
            this.developerpanel.Controls.Add(this.btncancel);
            this.developerpanel.Controls.Add(this.btnaddfile);
            this.developerpanel.Controls.Add(this.label4);
            this.developerpanel.Controls.Add(this.lblfile);
            this.developerpanel.Controls.Add(this.label3);
            this.developerpanel.Controls.Add(this.btnadd);
            this.developerpanel.Controls.Add(this.txtcomments);
            this.developerpanel.Controls.Add(this.label2);
            this.developerpanel.Controls.Add(this.label1);
            this.developerpanel.Controls.Add(this.txtbugname);
            this.developerpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.developerpanel.Location = new System.Drawing.Point(0, 0);
            this.developerpanel.Name = "developerpanel";
            this.developerpanel.Size = new System.Drawing.Size(612, 347);
            this.developerpanel.TabIndex = 0;
            this.developerpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtcode
            // 
            this.txtcode.IsReadOnly = false;
            this.txtcode.Location = new System.Drawing.Point(3, 80);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(330, 229);
            this.txtcode.TabIndex = 11;
            this.txtcode.Load += new System.EventHandler(this.txtcode_Load);
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(528, 315);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 23);
            this.btncancel.TabIndex = 10;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnaddfile
            // 
            //this.btnaddfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //this.btnaddfile.Location = new System.Drawing.Point(427, 315);
            //this.btnaddfile.Name = "btnaddfile";
            //this.btnaddfile.Size = new System.Drawing.Size(75, 23);
            //this.btnaddfile.TabIndex = 9;
            //this.btnaddfile.Text = "ADD";
            //this.btnaddfile.UseVisualStyleBackColor = true;
            //this.btnaddfile.Click += new System.EventHandler(this.btnaddfile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(548, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "comments";
            // 
            // lblfile
            // 
            this.lblfile.AutoSize = true;
            this.lblfile.Location = new System.Drawing.Point(160, 320);
            this.lblfile.Name = "lblfile";
            this.lblfile.Size = new System.Drawing.Size(0, 13);
            this.lblfile.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "file path";
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(19, 315);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(61, 23);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "add file";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtcomments
            // 
            this.txtcomments.Location = new System.Drawing.Point(367, 87);
            this.txtcomments.Multiline = true;
            this.txtcomments.Name = "txtcomments";
            this.txtcomments.Size = new System.Drawing.Size(236, 222);
            this.txtcomments.TabIndex = 4;
            this.txtcomments.TextChanged += new System.EventHandler(this.txtcomments_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Error code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "BugName";
            // 
            // txtbugname
            // 
            this.txtbugname.Location = new System.Drawing.Point(261, 48);
            this.txtbugname.Name = "txtbugname";
            this.txtbugname.Size = new System.Drawing.Size(118, 20);
            this.txtbugname.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // addfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.developerpanel);
            this.Name = "addfile";
            this.Size = new System.Drawing.Size(612, 347);
            this.developerpanel.ResumeLayout(false);
            this.developerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel developerpanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblfile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtcomments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbugname;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnaddfile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ICSharpCode.TextEditor.TextEditorControl txtcode;
    }
}
