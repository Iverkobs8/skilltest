namespace skilltest
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linksignup = new System.Windows.Forms.LinkLabel();
            this.chkshow = new System.Windows.Forms.CheckBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.linkFpass = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(29, 84);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(229, 22);
            this.txtemail.TabIndex = 1;
            this.txtemail.Text = "Email";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(97, 191);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(87, 30);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linksignup
            // 
            this.linksignup.AutoSize = true;
            this.linksignup.BackColor = System.Drawing.Color.Transparent;
            this.linksignup.LinkColor = System.Drawing.Color.Black;
            this.linksignup.Location = new System.Drawing.Point(154, 224);
            this.linksignup.Name = "linksignup";
            this.linksignup.Size = new System.Drawing.Size(55, 16);
            this.linksignup.TabIndex = 3;
            this.linksignup.TabStop = true;
            this.linksignup.Text = "Account";
            this.linksignup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linksignup_LinkClicked);
            // 
            // chkshow
            // 
            this.chkshow.AutoSize = true;
            this.chkshow.Location = new System.Drawing.Point(196, 152);
            this.chkshow.Name = "chkshow";
            this.chkshow.Size = new System.Drawing.Size(62, 20);
            this.chkshow.TabIndex = 4;
            this.chkshow.Text = "Show";
            this.chkshow.UseVisualStyleBackColor = true;
            this.chkshow.CheckedChanged += new System.EventHandler(this.chkshow_CheckedChanged);
            // 
            // txtpass
            // 
            this.txtpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtpass.Location = new System.Drawing.Point(29, 124);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(229, 22);
            this.txtpass.TabIndex = 5;
            this.txtpass.Text = "Password";
            this.txtpass.Enter += new System.EventHandler(this.txtpass_Enter);
            this.txtpass.Leave += new System.EventHandler(this.txtpass_Leave);
            // 
            // linkFpass
            // 
            this.linkFpass.AutoSize = true;
            this.linkFpass.LinkColor = System.Drawing.Color.DimGray;
            this.linkFpass.Location = new System.Drawing.Point(26, 156);
            this.linkFpass.Name = "linkFpass";
            this.linkFpass.Size = new System.Drawing.Size(116, 16);
            this.linkFpass.TabIndex = 6;
            this.linkFpass.TabStop = true;
            this.linkFpass.Text = "Forgot Password?";
            this.linkFpass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFpass_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(69, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Don\'t have an";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkFpass);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.chkshow);
            this.Controls.Add(this.linksignup);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linksignup;
        private System.Windows.Forms.CheckBox chkshow;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.LinkLabel linkFpass;
        private System.Windows.Forms.Label label2;
    }
}