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
using System.Net;
using System.Net.Mail;

namespace Giftly
{
    public partial class RecipientDetails : Form
    {
        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        int recipientId;

        private Timer notificationTimer;

        public RecipientDetails(int recipient_id)
        {
            InitializeComponent();

            notificationTimer = new Timer();
            notificationTimer.Interval = 3600000; // 1 hour in milliseconds
            notificationTimer.Tick += NotificationTimer_Tick;
            notificationTimer.Start();

            recipientId = recipient_id;
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            CheckForUpcomingOccasions();
        }

        void CheckForUpcomingOccasions()
        {
            try
            {
                conn.Open();

                String sql = @"
                SELECT occassion_name, occassion_date
                FROM occassion
                WHERE recipient_id = @recipient_id 
                AND (DATEDIFF(occassion_date, CURDATE()) = 7 OR DATEDIFF(occassion_date, CURDATE()) = 0)";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recipient_id", recipientId);

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        String occasionName = dr["occassion_name"].ToString();
                        String occasionDate = dr["occassion_date"].ToString();

                        string notificationMessage = $"Reminder: '{occasionName}' is on {occasionDate}!";
                        MessageBox.Show(notificationMessage);

                        InsertNotification(notificationMessage, Session.UserId);
                        SendEmailNotification(occasionName, occasionDate);
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

        void SendEmailNotification(String occasionName, String occasionDate)
        {
            try
            {
                MailMessage mail = new MailMessage
                {
                    From = new MailAddress("vincebautista678@gmail.com"),
                    Subject = $"Reminder: Upcoming Occasion - {occasionName}",
                    Body = $"Dear User,\n\nThis is a reminder that the occasion '{occasionName}' is coming up on {occasionDate}.\n\nBest regards,\nGiftly App",
                    IsBodyHtml = false
                };

                mail.To.Add(Session.UserEmail);

                SmtpClient smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("vincebautista678@gmail.com", "hvls yybl deas enrc"),
                    EnableSsl = true
                };

                smtpClient.Send(mail);
                MessageBox.Show("Email sent successfully!", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        void InsertNotification(string message, int userId)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string sql = "INSERT INTO notification (message, user_id) VALUES (@message, @user_id)";
                cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("@user_id", userId);

                cmd.ExecuteNonQuery();
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

        void SendTestNotifications()
        {
            try
            {
                string testMessage = "Test Notification: This is a test in-app notification.";
                MessageBox.Show(testMessage, "In-App Notification", MessageBoxButtons.OK);

                InsertNotification(testMessage, Session.UserId);

                string testEmailSubject = "Test Email Notification";
                string testEmailBody = "This is a test email notification from the Giftly App.";
                SendEmailNotification(testEmailSubject, testEmailBody);

                MessageBox.Show("Test notifications sent successfully!", "Test Complete", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending test notifications: {ex.Message}", "Error", MessageBoxButtons.OK);
            }
        }

        private void RecipientDetails_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = "server = localhost; user id = root; database = giftly";

            setTextBoxToReadOnly();
            fetchRecipientDetails();
            displayOccasions();
            displayGiftIdeas();
        }

        void setTextBoxToReadOnly()
        {
            recipient_name.ReadOnly = true;
            relationship.ReadOnly = true;
            budget.ReadOnly = true;
            address.ReadOnly = true;
            contact_number.ReadOnly = true;
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

                        recipient_name.Text = $"{dr["firstname"]} {dr["lastname"]}";
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

        private void edit_btn_Click(object sender, EventArgs e)
        {
            using (EditRecipientDialog editRecipient = new EditRecipientDialog(recipientId))
            {
                if (editRecipient.ShowDialog() == DialogResult.OK)
                {
                    fetchRecipientDetails();
                    MessageBox.Show("Recipient is edited!");
                }
            }
        }

        private void add_occasion_Click(object sender, EventArgs e)
        {
            using (AddOccasionDialog addOccasion = new AddOccasionDialog(recipientId))
            {
                if (addOccasion.ShowDialog() == DialogResult.OK)
                {
                    displayOccasions();
                    MessageBox.Show("Occasion is added!");
                }
            }
        }

        void displayOccasions()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                String sql = "SELECT occassion_id, occassion_name AS 'Occassion Name', occassion_date AS 'Occassion Date' FROM occassion WHERE recipient_id = @recipient_id";
                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@recipient_id", recipientId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                occasions.DataSource = dt;

                occasions.Columns["occassion_id"].Visible = false;
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

        private void delete_occasion_btn_Click(object sender, EventArgs e)
        {
            if (occasions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an occasion to delete.", "Delete Occasion", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this occasion?", "Delete Occasion", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    String sql = "DELETE FROM occassion WHERE occassion_id = @occassion_id";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@occassion_id", occasions.SelectedRows[0].Cells["occassion_id"].Value);
                    cmd.ExecuteNonQuery();

                    displayOccasions();
                    MessageBox.Show("Occasion deleted successfully!");
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

        private void edit_occasion_btn_Click(object sender, EventArgs e)
        {
            if (occasions.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an occasion to edit.");
                return;
            }

            int occassionId = int.Parse(occasions.SelectedRows[0].Cells["occassion_id"].Value.ToString());

            using (EditOccasionDialog editOccasion = new EditOccasionDialog(occassionId))
            {
                if (editOccasion.ShowDialog() == DialogResult.OK)
                {
                    displayOccasions();
                    MessageBox.Show("Occasion is edited!");
                }
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        void displayGiftIdeas()
        {
            try
            {
                conn.Open();

                String sql = "SELECT gift_idea_id, gift_ideas.recipient_id, gift_name AS 'Gift Name', occassion.occassion_name AS 'Occassion Name' FROM gift_ideas LEFT JOIN occassion ON gift_ideas.occassion_id = occassion.occassion_id WHERE gift_ideas.recipient_id = @recipient_id";
                adapter = new MySqlDataAdapter(sql, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@recipient_id", recipientId);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                gift_ideas.DataSource = dt;

                gift_ideas.Columns["gift_idea_id"].Visible = false;
                gift_ideas.Columns["recipient_id"].Visible = false;
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
            using (AddGiftIdea addGiftIdea = new AddGiftIdea(recipientId))
            {
                if (addGiftIdea.ShowDialog() == DialogResult.OK)
                {
                    displayGiftIdeas();
                    MessageBox.Show("Gift Idea is added!");
                }
            }
        }

        private void delete_gift_idea_Click(object sender, EventArgs e)
        {
            if (gift_ideas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a gift idea to delete.", "Delete Gift Idea", MessageBoxButtons.OK);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this gift idea?", "Delete Gift Idea", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    String sql = "DELETE FROM gift_ideas WHERE gift_idea_id = @gift_idea_id";
                    cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@gift_idea_id", gift_ideas.SelectedRows[0].Cells["gift_idea_id"].Value);
                    cmd.ExecuteNonQuery();

                    displayGiftIdeas();
                    MessageBox.Show("Gift Idea deleted successfully!");
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

        private void edit_gift_idea_Click(object sender, EventArgs e)
        {
            if (gift_ideas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a gift idea to delete.", "Delete Gift Idea", MessageBoxButtons.OK);
                return;
            }

            int giftIdeaId = int.Parse(gift_ideas.SelectedRows[0].Cells["gift_idea_id"].Value.ToString());
            int recipientId = int.Parse(gift_ideas.SelectedRows[0].Cells["recipient_id"].Value.ToString());

            using (EditGiftIdea editGiftIdea = new EditGiftIdea(giftIdeaId, recipientId))
            {
                if (editGiftIdea.ShowDialog() == DialogResult.OK)
                {
                    displayGiftIdeas();
                    MessageBox.Show("Gift Idea is edited!");
                }
            }
        }

        private void notification_Click(object sender, EventArgs e)
        {
            new Notification().Show();
        }
    }
}
