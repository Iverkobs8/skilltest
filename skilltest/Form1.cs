using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace skilltest
{

    public partial class Form1 : Form
    {
        Thread login;
        SqlConnection conn = new SqlConnection("Data Source=IVERSONKOBE\\SQLEXPRESS;Initial Catalog=skilltest;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        public void gologin(object obj)
        {
            Application.Run(new Login());
        }
        private void txtfname_Leave(object sender, EventArgs e)
        {
            if (txtfname.Text == "")
            {
                txtfname.Text = "First name";
                txtfname.ForeColor = Color.Gray;
            }
        }

        private void txtfname_Enter(object sender, EventArgs e)
        {
            if(txtfname.Text == "First name")
            {
                txtfname.Text = "";
                txtfname.ForeColor = Color.Black;
            }
            
        }

        private void txtlname_Leave(object sender, EventArgs e)
        {
            if (txtlname.Text == "")
            {
                txtlname.Text = "Last name";
                txtlname.ForeColor = Color.Gray;
            }
        }

        private void txtlname_Enter(object sender, EventArgs e)
        {
            if (txtlname.Text == "Last name")
            {
                txtlname.Text = "";
                txtlname.ForeColor = Color.Black;
            }
        }

        private void txtemail_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Email";
                txtemail.ForeColor = Color.Gray;
            }
        }

        private void txtemail_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Email")
            {
                txtemail.Text = "";
                txtemail.ForeColor = Color.Black;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtconpass_Leave(object sender, EventArgs e)
        {
            if (txtconpass.Text == "")
            {
                txtconpass.Text = "Confirm Password";
                txtconpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void txtconpass_Enter(object sender, EventArgs e)
        {
            if (txtconpass.Text == "Confirm Password")
            {
                txtconpass.Text = "";
                txtconpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            var hasNum = new Regex(@"[a-z]+");
            var hasUpper = new Regex(@"[A-Z]+");
            var hasLower = new Regex(@"[a-z]+");
            var hasChar = new Regex(@"[!@#$%^&*()_><?]+");


           if(!hasNum.IsMatch(txtpass.Text))
            {
                MessageBox.Show("Password must contain numeric", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (!hasUpper.IsMatch(txtpass.Text))
            {
                MessageBox.Show("Password must contain uppercase", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if (!hasLower.IsMatch(txtpass.Text))
            {
                MessageBox.Show("Password must contain lowercase", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           else if (!hasChar.IsMatch(txtpass.Text))
            {
                MessageBox.Show("Password must contain characters ex (!@@$$*)", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if(txtpass.Text != txtconpass.Text)
            {
                MessageBox.Show("Password didn't match", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlCommand check = new SqlCommand("Select * from Accounts where email = @email", conn);
                    check.Parameters.AddWithValue("@email", txtemail.Text);
                conn.Open();
                SqlDataReader checkifexist = check.ExecuteReader();
               

                if(checkifexist.HasRows)
                {
                    MessageBox.Show("Email already used", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                }
                
                else
                {
                    
                   
                    string bday = bdaydate.Value.ToString("yyyy-MM-dd");
                    conn.Close();
                    conn.Open();
                    SqlCommand insert = new SqlCommand("Insert Into Accounts (firstname, lastname, email, birthdate, password) values (@fname, @lname, @email, @birthdate, @password)", conn);
                    insert.Parameters.AddWithValue("@fname", txtfname.Text);
                    insert.Parameters.AddWithValue("@lname", txtlname.Text);
                    insert.Parameters.AddWithValue("@email", txtemail.Text);
                    insert.Parameters.AddWithValue("@birthdate", bday);
                    insert.Parameters.AddWithValue("@password", txtpass.Text);

                    insert.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Successfully registered!", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void chkshow_CheckedChanged(object sender, EventArgs e)
        {
            if(chkshow.Checked)
            {
                txtpass.UseSystemPasswordChar = false;

            }
            else
            {
                txtpass.UseSystemPasswordChar= true;
            }
        }

        private void linklogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            login = new Thread(gologin);
            login.SetApartmentState(ApartmentState.STA);
            login.Start();

        }
    }
    
    


}
