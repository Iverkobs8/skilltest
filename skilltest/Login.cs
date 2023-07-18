using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skilltest
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=IVERSONKOBE\\SQLEXPRESS;Initial Catalog=skilltest;Integrated Security=True");
        Thread signup;
        Thread home;
        Thread forgotpass;
        public Login()
        {
            InitializeComponent();
        }
        public void goSignup(object obj)
        {
            Application.Run(new Form1());
        }
        public void goHome(object obj)
        {
            Application.Run(new home());
        }

        public void goForgotPass(object obj)
        {
            Application.Run(new Forgotpasscs());
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "") {
                txtemail.ForeColor = Color.Gray;
            }

        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if(txtemail.Text == "Email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text == "")
            {
                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkshow.Checked)
            {
                txtpass.UseSystemPasswordChar = false;

            }
            else
            {
                txtpass.UseSystemPasswordChar= true;
            }
        }

        private void linksignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            signup = new Thread(goSignup);
            signup.SetApartmentState(ApartmentState.STA);
            signup.Start();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand check = new SqlCommand("Select * from Accounts where email = @email", conn);
            check.Parameters.AddWithValue("@email", txtemail.Text);
            conn.Close();
            conn.Open();

            SqlDataReader checkifExist = check.ExecuteReader();

            if (checkifExist.HasRows)
            {
                checkifExist.Read();
                string passwordfromdb = checkifExist["password"].ToString();
                if (txtpass.Text == passwordfromdb)
                {

                    conn.Close();
                    MessageBox.Show("Welcome!", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    home = new Thread(goHome);
                    home.SetApartmentState(ApartmentState.STA);
                    home.Start();
                }
                else
                {
                    MessageBox.Show("Email or password incorrect", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void linkFpass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            forgotpass = new Thread(goForgotPass);
            forgotpass.SetApartmentState(ApartmentState.STA);
            forgotpass.Start();
        }
    }
}
