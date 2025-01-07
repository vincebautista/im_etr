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
    public partial class AddGiftIdea : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int recipientId;

        public AddGiftIdea(int recipient_id)
        {
            InitializeComponent();

            recipientId = recipient_id;
        }

        private void AddGiftIdea_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            fetchOccasions();
        }

        void fetchOccasions()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "SELECT occassion_id, occassion_name FROM occassion WHERE recipient_id = @recipient_id";
                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@recipient_id", recipientId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                occasions.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    occasions.DataSource = dt;
                    occasions.DisplayMember = "occassion_name";
                    occasions.ValueMember = "occassion_id";
                }
                else
                {
                    occasions.DataSource = null;
                    occasions.Items.Clear();
                    occasions.Items.Add("No occasion found");
                }

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            occasions.Items.Add(dr["occasion_name"].ToString());
                        }
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

        private void add_gift_idea_Click(object sender, EventArgs e)
        {
            if (gift_name.Text == "")
            {
                MessageBox.Show("Gift Name is required!");
            }
            else
            {
                try
                {
                    conn.Open();

                    if (occasions.SelectedValue == null || occasions.SelectedValue.ToString() == "No occasion found")
                    {
                        string sql = "INSERT INTO gift_ideas (recipient_id, occassion_id, gift_name) VALUES (@recipient_id, NULL, @gift_name)";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@recipient_id", recipientId);
                        cmd.Parameters.AddWithValue("@gift_name", gift_name.Text);
                        cmd.ExecuteNonQuery();

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        string sql = "INSERT INTO gift_ideas (recipient_id, occassion_id, gift_name) VALUES (@recipient_id, @occassion_id, @gift_name)";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@recipient_id", recipientId);
                        cmd.Parameters.AddWithValue("@occassion_id", occasions.SelectedValue);
                        cmd.Parameters.AddWithValue("@gift_name", gift_name.Text);
                        cmd.ExecuteNonQuery();

                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
