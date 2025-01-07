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
    public partial class Login : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(email.Text == "" || password.Text == "")
            {
                MessageBox.Show("Please fill up all input fields!");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sql = "SELECT * FROM user WHERE email = @email AND password = @password";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@password", password.Text);

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();

                            Session.UserId = int.Parse(dr["user_id"].ToString());
                            Session.UserEmail = dr["email"].ToString();
                            Session.UserFirstName = dr["firstname"].ToString();
                            Session.UserLastName = dr["lastname"].ToString();

                            dr.Close();

                            this.Hide();
                            new Home().Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid email or password!");
                        }
                    }
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
