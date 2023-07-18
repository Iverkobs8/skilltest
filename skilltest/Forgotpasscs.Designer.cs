namespace skilltest
{
    partial class Forgotpasscs
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
            this.linklogin = new System.Windows.Forms.LinkLabel();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtnewpass = new System.Windows.Forms.TextBox();
            this.txtconpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forgot Password";
            // 
            // linklogin
            // 
            this.linklogin.AutoSize = true;
            this.linklogin.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linklogin.Location = new System.Drawing.Point(134, 256);
            this.linklogin.Name = "linklogin";
            this.linklogin.Size = new System.Drawing.Size(40, 16);
            this.linklogin.TabIndex = 1;
            this.linklogin.TabStop = true;
            this.linklogin.Text = "Login";
            this.linklogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklogin_LinkClicked);
            // 
            // txtemail
            // 
            this.txtemail.ForeColor = System.Drawing.Color.DimGray;
            this.txtemail.Location = new System.Drawing.Point(35, 96);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(251, 22);
            this.txtemail.TabIndex = 2;
            this.txtemail.Text = "Email";
            this.txtemail.Enter += new System.EventHandler(this.txtemail_Enter);
            this.txtemail.Leave += new System.EventHandler(this.txtemail_Leave);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(119, 230);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 23);
            this.btnchange.TabIndex = 3;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = true;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtnewpass
            // 
            this.txtnewpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtnewpass.Location = new System.Drawing.Point(35, 134);
            this.txtnewpass.Name = "txtnewpass";
            this.txtnewpass.Size = new System.Drawing.Size(251, 22);
            this.txtnewpass.TabIndex = 4;
            this.txtnewpass.Text = "New Password";
            this.txtnewpass.Enter += new System.EventHandler(this.txtnewpass_Enter);
            this.txtnewpass.Leave += new System.EventHandler(this.txtnewpass_Leave);
            // 
            // txtconpass
            // 
            this.txtconpass.ForeColor = System.Drawing.Color.DimGray;
            this.txtconpass.Location = new System.Drawing.Point(35, 174);
            this.txtconpass.Name = "txtconpass";
            this.txtconpass.Size = new System.Drawing.Size(251, 22);
            this.txtconpass.TabIndex = 5;
            this.txtconpass.Text = "Confirm Password";
            this.txtconpass.Enter += new System.EventHandler(this.txtconpass_Enter);
            this.txtconpass.Leave += new System.EventHandler(this.txtconpass_Leave);
            // 
            // Forgotpasscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 293);
            this.Controls.Add(this.txtconpass);
            this.Controls.Add(this.txtnewpass);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.linklogin);
            this.Controls.Add(this.label1);
            this.Name = "Forgotpasscs";
            this.Text = "Forgotpasscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linklogin;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtnewpass;
        private System.Windows.Forms.TextBox txtconpass;
    }
}