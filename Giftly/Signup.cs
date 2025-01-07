using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Giftly
{
    public partial class Sign_up : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        public Sign_up()
        {
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void Sign_up_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            if (Firstname.Text == "" || Lastname.Text == "" || Email.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Please fill up all input fields!");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sql = "SELECT * FROM user WHERE email = @email";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", Email.Text);

                    bool emailExists = false;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            emailExists = true;
                        }
                    }

                    if (emailExists)
                    {
                        MessageBox.Show("Email is already taken!");
                    }
                    else if (!Male.Checked && !Female.Checked)
                    {
                        MessageBox.Show("Please select a gender!");
                    }
                    else
                    {
                        string gender = Male.Checked ? "Male" : "Female";
                        String query = "INSERT INTO user (firstname, lastname, gender, email, password, date_created) VALUES (@firstname, @lastname, @gender, @email, @password, NOW())";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@firstname", Firstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", Lastname.Text);
                        cmd.Parameters.AddWithValue("@email", Email.Text);
                        cmd.Parameters.AddWithValue("@gender", gender);
                        cmd.Parameters.AddWithValue("@password", Password.Text);
                        cmd.ExecuteNonQuery();

                        Firstname.Clear();
                        Lastname.Clear();
                        Email.Clear();
                        Password.Clear();
                        Male.Checked = false;
                        Female.Checked = false;
                        MessageBox.Show("Created Account Successfully!");
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            if (Male.Checked)
            
                Female.Checked = false;
            }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            if (Female.Checked)
            {
                Male.Checked = false;
            }
        }
    }
}

