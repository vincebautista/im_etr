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
    public partial class OrderHistory : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";
            DisplayOrders();
        }

        private void DisplayOrders()
        {
            try
            {
                conn.Open();

                String sql = @"SELECT 
                    transaction.trans_id AS 'Transaction ID', 
                    recipient.firstname AS 'Recipient First Name', 
                    recipient.lastname AS ''Recipient Last Name', 
                    item.item_name AS 'Item Name', 
                    item.item_price AS 'Item Price', 
                    transaction.item_quantity AS 'Item Quantity', 
                    transaction.total_price AS 'Item Total Price', 
                    CASE 
                        WHEN orders.is_delivered = 0 THEN 'Ready to Pickup'
                        WHEN orders.is_delivered = 1 THEN 'Picked Up'
                        WHEN orders.is_delivered = 2 THEN 'Delivered'
                        ELSE 'Unknown'
                    END AS 'Status'
                FROM
                    transaction
                INNER JOIN
                    item ON transaction.item_id = item.item_id
                INNER JOIN
                    orders ON transaction.order_id = orders.order_id
                INNER JOIN
                    recipient ON orders.recipient_id = recipient.recipient_id
                INNER JOIN
                    user ON orders.user_id = user.user_id AND recipient.user_id = user.user_id
                WHERE
                    user.user_id = @user_id";

                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@user_id", Session.UserId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ordersDataGridView.DataSource = dt;
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
