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
    public partial class EditRecipientDialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int recipientId;

        public EditRecipientDialog(int recipient_id)
        {
            InitializeComponent();

            recipientId = recipient_id;
        }

        private void EditDetails_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            fetchRecipientDetails();
        }

        void fetchRecipientDetails()
        {
            try
            {
                conn.Open();

                String sql = "SELECT * FROM recipient WHERE recipient_id = @recipient_id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recipient_id", recipientId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();

                        firstname.Text = dr["firstname"].ToString();
                        lastname.Text = dr["lastname"].ToString();
                        relationship.Text = dr["relationship"].ToString();
                        budget.Text = dr["budget"].ToString();
                        address.Text = dr["address"].ToString();
                        contact_number.Text = dr["contact_number"].ToString();

                        dr.Close();
                    }
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

        private void edit_recipient_btn_Click(object sender, EventArgs e)
        {
            if (firstname.Text == "" || lastname.Text == "" || relationship.Text == "" || budget.Text == "" || address.Text == "" || contact_number.Text == "")
            {
                MessageBox.Show("Please fill all input fields!");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sql = "UPDATE recipient SET firstname = @firstname, lastname = @lastname, relationship = @relationship, budget = @budget, address = @address, contact_number = @contact_number WHERE recipient_id = @recipient_id";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@firstname", firstname.Text);
                    cmd.Parameters.AddWithValue("@lastname", lastname.Text);
                    cmd.Parameters.AddWithValue("@relationship", relationship.Text);
                    cmd.Parameters.AddWithValue("@budget", double.Parse(budget.Text));
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@contact_number", contact_number.Text);
                    cmd.Parameters.AddWithValue("@recipient_id", recipientId);
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
