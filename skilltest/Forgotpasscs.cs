using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace skilltest
{
    public partial class Forgotpasscs : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=IVERSONKOBE\\SQLEXPRESS;Initial Catalog=skilltest;Integrated Security=True");
        Thread login;
        public Forgotpasscs()
        {
            InitializeComponent();
        }
        public void goLogin(object obj)
        {
            Application.Run(new Login());
        }
        private void txtemail_Leave(object sender, EventArgs e)
        {
            if(txtemail.Text == "")
            {
                txtemail.Text = "Email";
                txtemail.ForeColor = Color.DimGray;

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

        private void txtnewpass_Leave(object sender, EventArgs e)
        {
            if (txtnewpass.Text == "")
            {
                txtnewpass.Text = "Email";
                txtnewpass.ForeColor = Color.DimGray;

            }
        }

        private void txtnewpass_Enter(object sender, EventArgs e)
        {
            if (txtnewpass.Text == "New Password")
            {
                txtnewpass.Text = "";
                txtnewpass.ForeColor = Color.Black;

            }
        }

        private void txtconpass_Leave(object sender, EventArgs e)
        {
            if(txtconpass.Text == "")
            {
                txtconpass.Text = "Confirm Password";
                txtconpass.ForeColor = Color.DimGray;
            }
        }

        private void txtconpass_Enter(object sender, EventArgs e)
        {
            if(txtconpass.Text =="Confirm Password")
            {
                txtconpass.Text = "";
                txtconpass.ForeColor = Color.Black;
            }
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            login = new Thread(goLogin);
            login.SetApartmentState(ApartmentState.STA);
            login.Start();
        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand check = new SqlCommand("Select * from Accounts where email = @email", conn);
            check.Parameters.AddWithValue("@email", txtemail.Text);
            
            SqlDataReader checkifexist = check.ExecuteReader(); 

            if(checkifexist.HasRows) {
                SqlCommand update = new SqlCommand("Update Accounts set password = @newpass", conn);
                update.Parameters.AddWithValue("@newpass", txtnewpass.Text);
                conn.Close();
                conn.Open();
                update.ExecuteNonQuery();
            
                MessageBox.Show("Password succesfully updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else {
                MessageBox.Show("Email not found!", "Oops :(", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
