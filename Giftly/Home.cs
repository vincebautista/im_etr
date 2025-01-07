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
    public partial class Home : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            displayRecipients();
        }

        private void add_recipient_Click(object sender, EventArgs e)
        {
            using(AddRecipientDialog addRecipient = new AddRecipientDialog())
            {
                if (addRecipient.ShowDialog() == DialogResult.OK)
                {
                    displayRecipients();
                    MessageBox.Show("Recipient is added!");
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            Session.Clear();

            this.Hide();
            new Form1().Show();
        }

        void displayRecipients(String search = "")
        {
            try
            {
                conn.Open();

                String sql = "SELECT recipient_id, firstname AS 'First Name', lastname AS 'Last Name', relationship AS 'Relationship', budget AS 'Budget', address AS 'Address', contact_number AS 'Contact Number' FROM recipient WHERE user_id = @user_id";

                if(search != "")
                {
                    sql += " AND (firstname LIKE @firstname OR lastname LIKE @lastname)";
                }

                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", Session.UserId);

                if(search != "")
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@firstname", $"%{search}%");
                    adapter.SelectCommand.Parameters.AddWithValue("@lastname", $"%{search}%");
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                recipients.DataSource = dt;

                recipients.Columns["recipient_id"].Visible = false;
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

        private void recipients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                int recipient_id = int.Parse(recipients.Rows[e.RowIndex].Cells["recipient_id"].Value.ToString());

                this.Hide();
                new RecipientDetails(recipient_id).Show();
            }
        }

        private void search_KeyUp(object sender, KeyEventArgs e)
        {
            displayRecipients(search.Text);
        }

        private void order_history_Click(object sender, EventArgs e)
        {
            new OrderHistory().Show();
        }
    }
}
