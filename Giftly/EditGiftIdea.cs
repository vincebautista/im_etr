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
    public partial class EditGiftIdea : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int giftIdeaId;
        int recipientId;
        public EditGiftIdea(int gift_idea_id, int recipient_id)
        {
            InitializeComponent();

            giftIdeaId = gift_idea_id;
            recipientId = recipient_id;
        }

        private void EditGiftIdea_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            fetchOccasions();
            fetchGiftIdea();
        }

        void fetchGiftIdea()
        {
            try
            {
                conn.Open();

                String sql = "SELECT gift_name, occassion_id FROM gift_ideas WHERE gift_idea_id = @gift_idea_id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@gift_idea_id", giftIdeaId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();

                        gift_name.Text = dr["gift_name"].ToString();

                        if (dr["occassion_id"] != DBNull.Value)
                        {
                            occasions.SelectedValue = dr["occassion_id"];
                        }

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

        private void edit_gift_idea_Click(object sender, EventArgs e)
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
                        String sql = "UPDATE gift_ideas SET occassion_id = NULL, gift_name = @gift_name WHERE gift_idea_id = @gift_idea_id";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@gift_name", gift_name.Text);
                        cmd.Parameters.AddWithValue("@gift_idea_id", giftIdeaId);
                        cmd.ExecuteNonQuery();

                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        String sql = "UPDATE gift_ideas SET occassion_id = @occassion_id, gift_name = @gift_name WHERE gift_idea_id = @gift_idea_id";
                        cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@occassion_id", occasions.SelectedValue);
                        cmd.Parameters.AddWithValue("@gift_name", gift_name.Text);
                        cmd.Parameters.AddWithValue("@gift_idea_id", giftIdeaId);
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
