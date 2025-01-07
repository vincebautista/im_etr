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
    public partial class AddRecipientDialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public AddRecipientDialog()
        {
            InitializeComponent();
        }

        private void AddRecipientDialog_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
        }

        private void add_recipient_btn_Click_1(object sender, EventArgs e)
        {
            if (firstname.Text == "" || lastname.Text == "" || relationship.Text == "" || address.Text == "" || contact_number.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sql = "INSERT INTO recipient (user_id, firstname, lastname, relationship, budget, address, contact_number) VALUES (@user_id, @firstname, @lastname, @relationship, @budget, @address, @contact_number)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user_id", Session.UserId);
                    cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                    cmd.Parameters.AddWithValue("@relationship", relationship.Text);
                    cmd.Parameters.AddWithValue("@budget", budget.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@contact_number", contact_number.Text);
                    cmd.ExecuteNonQuery();

                    this.DialogResult = DialogResult.OK;
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
    }
}
