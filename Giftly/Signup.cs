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
    public partial class Signup : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            if(firstname.Text == "" || lastname.Text == "" || email.Text == "" || password.Text == "")
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
                    cmd.Parameters.AddWithValue("@email", email.Text);

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
                    else
                    {
                        String query = "INSERT INTO user (firstname, lastname, email, password, date_created) VALUES (@firstname, @lastname, @email, @password, NOW())";
                        cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                        cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                        cmd.Parameters.AddWithValue("@email", email.Text);
                        cmd.Parameters.AddWithValue("@password", password.Text);
                        cmd.ExecuteNonQuery();

                        firstname.Clear();
                        lastname.Clear();
                        email.Clear();
                        password.Clear();

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

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
