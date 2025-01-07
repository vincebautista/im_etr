
namespace Giftly
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.logout = new System.Windows.Forms.Button();
            this.add_recipient = new System.Windows.Forms.Button();
            this.recipients = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.recipients)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Giftly";
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(12, 392);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(137, 46);
            this.logout.TabIndex = 1;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // add_recipient
            // 
            this.add_recipient.Location = new System.Drawing.Point(40, 56);
            this.add_recipient.Name = "add_recipient";
            this.add_recipient.Size = new System.Drawing.Size(145, 50);
            this.add_recipient.TabIndex = 2;
            this.add_recipient.Text = "Add Recipient";
            this.add_recipient.UseVisualStyleBackColor = true;
            this.add_recipient.Click += new System.EventHandler(this.add_recipient_Click);
            // 
            // recipients
            // 
            this.recipients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.recipients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recipients.Location = new System.Drawing.Point(221, 86);
            this.recipients.Name = "recipients";
            this.recipients.ReadOnly = true;
            this.recipients.RowHeadersWidth = 51;
            this.recipients.RowTemplate.Height = 24;
            this.recipients.Size = new System.Drawing.Size(832, 352);
            this.recipients.TabIndex = 3;
            this.recipients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recipients_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(337, 53);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(249, 22);
            this.search.TabIndex = 5;
            this.search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.search_KeyUp);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 450);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.recipients);
            this.Controls.Add(this.add_recipient);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recipients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout;
        private System.Windows.Forms.Button add_recipient;
        private System.Windows.Forms.DataGridView recipients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search;
    }
}