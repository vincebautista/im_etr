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
    public partial class Notification : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        public Notification()
        {
            InitializeComponent();
        }

        private void Notification_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            try
            {
                String sql = "SELECT message FROM notification WHERE user_id = @user_id";
                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", Session.UserId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                notifications.DataSource = dt;
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
