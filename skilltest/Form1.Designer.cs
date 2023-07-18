namespace skilltest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtconpass = new System.Windows.Forms.TextBox();
            this.bdaydate = new System.Windows.Forms.DateTimePicker();
            this.btnsignup = new System.Windows.Forms.Button();
            this.chkshow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtfname
            // 
            this.txtfname.BackColor = System.Drawing.SystemColors.Window;
            this.txtfname.ForeColor = System.Drawing.Color.Gray;
            this.txtfname.Location = new System.Drawing.Point(36, 79);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(255, 22);
            this.txtfname.TabIndex = 0;
            this.txtfname.Text = "First name";
            this.txtfname.Enter += new System.EventHandler(this.txtfname_Enter);
            this.txtfname.Leave += new System.EventHandler(this.txtfname_Leave);
            // 
            // txtlname
            // 
            this.txtlname.ForeColor = System.Drawing.Color.Gray;
            this.txtlname.Location = new System.Drawing.Point(36, 117);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(255, 22);
            this.txtlname.TabIndex = 1;
            this.txtlname.Text = "Last name";
            this.txtlname.Enter += new System.EventHandler(this.txtlname_Enter);
            this.txtlname.Leave += new System.EventHandler(this.txtlname_Leave);
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.Gray;
            this.txtemail.Location = new System.Drawing.Point(36, 156);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(255, 22);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "Email";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.Color.Gray;
            this.txtpass.Location = new System.Drawing.Point(36, 246);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(255, 22);
            this.txtpass.TabIndex = 3;
            this.txtpass.Text = "Password";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // txtconpass
            // 
            this.txtconpass.ForeColor = System.Drawing.Color.Gray;
            this.txtconpass.Location = new System.Drawing.Point(36, 300);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.Size = new System.Drawing.Size(255, 22);
            this.txtconpass.TabIndex = 4;
            this.txtconpass.Text = "Confirm Password";
            this.txtconpass.Enter += new System.EventHandler(this.txtconpass_Enter);
            this.txtconpass.Leave += new System.EventHandler(this.txtconpass_Leave);
            // 
            // bdaydate
            // 
            this.bdaydate.Location = new System.Drawing.Point(36, 209);
            this.bdaydate.Name = "bdaydate";
            this.bdaydate.Size = new System.Drawing.Size(255, 22);
            this.bdaydate.TabIndex = 5;
            // 
            // btnsignup
            // 
            this.btnsignup.Location = new System.Drawing.Point(124, 351);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(75, 23);
            this.btnsignup.TabIndex = 6;
            this.btnsignup.Text = "Sign up";
            this.btnsignup.UseVisualStyleBackColor = true;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.BackColor = System.Drawing.Color.Transparent;
            this.chkshow.Location = new System.Drawing.Point(229, 274);
            this.chkshow.Name = "chkshow";
            this.chkshow.Size = new System.Drawing.Size(62, 20);
            this.chkshow.TabIndex = 7;
            this.chkshow.Text = "Show";
            this.chkshow.UseVisualStyleBackColor = false;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 38);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sign Up";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(80, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Already have an";
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.LinkColor = System.Drawing.Color.Black;
            this.linklogin.Location = new System.Drawing.Point(182, 392);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(62, 16);
            this.linklogin.TabIndex = 10;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Account?";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogin_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Birthdate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linklogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkshow);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.bdaydate);
            this.Controls.Add(this.txtconpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtconpass;
        private System.Windows.Forms.DateTimePicker bdaydate;
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.CheckBox chkshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.Label label3;
    }
}

