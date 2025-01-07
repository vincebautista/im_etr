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
    public partial class EditOccasionDialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int occasionId;

        public EditOccasionDialog(int occasion_id)
        {
            InitializeComponent();
            occasionId = occasion_id;
        }

        private void EditOccasionDialog_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            fetchOccasion();
        }

        void fetchOccasion()
        {
            try
            {
                conn.Open();

                String sql = "SELECT * FROM occassion WHERE occassion_id = @occassion_id";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@occassion_id", occasionId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.HasRows)
                    {
                        dr.Read();

                        occasion_name.Text = dr["occassion_name"].ToString();

                        DateTime parsedDate;
                        if (DateTime.TryParse(dr["occassion_date"].ToString(), out parsedDate))
                        {
                            occasion_date.Value = parsedDate;
                        }

                        dr.Close();
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

        private void edit_occasion_btn_Click(object sender, EventArgs e)
        {
            if(occasion_name.Text == "")
            {
                MessageBox.Show("Please fill in all fields!");
            }
            else
            {
                try
                {
                    conn.Open();

                    String sql = "UPDATE occassion SET occassion_name = @occassion_name, occassion_date = @occassion_date WHERE occassion_id = @occassion_id";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@occassion_name", occasion_name.Text);
                    cmd.Parameters.AddWithValue("@occassion_date", occasion_date.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@occassion_id", occasionId);
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

            this.DialogResult = DialogResult.OK;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
