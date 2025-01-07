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
    public partial class AddOccasionDialog : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int recipientId;
        public AddOccasionDialog(int recipient_id)
        {
            InitializeComponent();

            recipientId = recipient_id;
        }

        private void AddOccasionDialog_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
        }

        private void add_occasion_btn_Click(object sender, EventArgs e)
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

                    String sql = "INSERT INTO occassion (recipient_id, occassion_name, occassion_date) VALUES (@recipient_id, @occassion_name, @occassion_date)";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("recipient_id", recipientId);
                    cmd.Parameters.AddWithValue("occassion_name", occasion_name.Text);
                    cmd.Parameters.AddWithValue("occassion_date", occasion_date.Value.ToString("yyyy-MM-dd"));
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
