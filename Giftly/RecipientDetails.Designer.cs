
namespace Giftly
{
    partial class RecipientDetails
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recipient_name = new System.Windows.Forms.TextBox();
            this.relationship = new System.Windows.Forms.TextBox();
            this.budget = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.contact_number = new System.Windows.Forms.TextBox();
            this.edit_btn = new System.Windows.Forms.Button();
            this.add_occasion = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.occasions = new System.Windows.Forms.DataGridView();
            this.edit_occasion_btn = new System.Windows.Forms.Button();
            this.delete_occasion_btn = new System.Windows.Forms.Button();
            this.gift_ideas = new System.Windows.Forms.DataGridView();
            this.delete_gift_idea = new System.Windows.Forms.Button();
            this.edit_gift_idea = new System.Windows.Forms.Button();
            this.add_gift_idea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.occasions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift_ideas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Recipient Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Relationship";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Budget";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contact Number";
            // 
            // recipient_name
            // 
            this.recipient_name.Location = new System.Drawing.Point(138, 42);
            this.recipient_name.Name = "recipient_name";
            this.recipient_name.Size = new System.Drawing.Size(260, 22);
            this.recipient_name.TabIndex = 6;
            // 
            // relationship
            // 
            this.relationship.Location = new System.Drawing.Point(116, 76);
            this.relationship.Name = "relationship";
            this.relationship.Size = new System.Drawing.Size(260, 22);
            this.relationship.TabIndex = 7;
            // 
            // budget
            // 
            this.budget.Location = new System.Drawing.Point(83, 110);
            this.budget.Name = "budget";
            this.budget.Size = new System.Drawing.Size(260, 22);
            this.budget.TabIndex = 8;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(90, 142);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(260, 22);
            this.address.TabIndex = 9;
            // 
            // contact_number
            // 
            this.contact_number.Location = new System.Drawing.Point(138, 173);
            this.contact_number.Name = "contact_number";
            this.contact_number.Size = new System.Drawing.Size(260, 22);
            this.contact_number.TabIndex = 10;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(27, 214);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(173, 50);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.Text = "Edit Details";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // add_occasion
            // 
            this.add_occasion.Location = new System.Drawing.Point(27, 270);
            this.add_occasion.Name = "add_occasion";
            this.add_occasion.Size = new System.Drawing.Size(173, 50);
            this.add_occasion.TabIndex = 12;
            this.add_occasion.Text = "Add Occasion";
            this.add_occasion.UseVisualStyleBackColor = true;
            this.add_occasion.Click += new System.EventHandler(this.add_occasion_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(12, 613);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(173, 50);
            this.back_btn.TabIndex = 13;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // occasions
            // 
            this.occasions.AllowUserToAddRows = false;
            this.occasions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.occasions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.occasions.Location = new System.Drawing.Point(441, 27);
            this.occasions.MultiSelect = false;
            this.occasions.Name = "occasions";
            this.occasions.ReadOnly = true;
            this.occasions.RowHeadersWidth = 51;
            this.occasions.RowTemplate.Height = 24;
            this.occasions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.occasions.Size = new System.Drawing.Size(717, 257);
            this.occasions.TabIndex = 14;
            // 
            // edit_occasion_btn
            // 
            this.edit_occasion_btn.Location = new System.Drawing.Point(27, 326);
            this.edit_occasion_btn.Name = "edit_occasion_btn";
            this.edit_occasion_btn.Size = new System.Drawing.Size(173, 50);
            this.edit_occasion_btn.TabIndex = 15;
            this.edit_occasion_btn.Text = "Edit Occasion";
            this.edit_occasion_btn.UseVisualStyleBackColor = true;
            this.edit_occasion_btn.Click += new System.EventHandler(this.edit_occasion_btn_Click);
            // 
            // delete_occasion_btn
            // 
            this.delete_occasion_btn.Location = new System.Drawing.Point(27, 382);
            this.delete_occasion_btn.Name = "delete_occasion_btn";
            this.delete_occasion_btn.Size = new System.Drawing.Size(173, 50);
            this.delete_occasion_btn.TabIndex = 16;
            this.delete_occasion_btn.Text = "Delete Occasion";
            this.delete_occasion_btn.UseVisualStyleBackColor = true;
            this.delete_occasion_btn.Click += new System.EventHandler(this.delete_occasion_btn_Click);
            // 
            // gift_ideas
            // 
            this.gift_ideas.AllowUserToAddRows = false;
            this.gift_ideas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gift_ideas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gift_ideas.Location = new System.Drawing.Point(441, 305);
            this.gift_ideas.MultiSelect = false;
            this.gift_ideas.Name = "gift_ideas";
            this.gift_ideas.ReadOnly = true;
            this.gift_ideas.RowHeadersWidth = 51;
            this.gift_ideas.RowTemplate.Height = 24;
            this.gift_ideas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gift_ideas.Size = new System.Drawing.Size(717, 257);
            this.gift_ideas.TabIndex = 17;
            // 
            // delete_gift_idea
            // 
            this.delete_gift_idea.Location = new System.Drawing.Point(206, 382);
            this.delete_gift_idea.Name = "delete_gift_idea";
            this.delete_gift_idea.Size = new System.Drawing.Size(173, 50);
            this.delete_gift_idea.TabIndex = 20;
            this.delete_gift_idea.Text = "Delete Gift Idea";
            this.delete_gift_idea.UseVisualStyleBackColor = true;
            this.delete_gift_idea.Click += new System.EventHandler(this.delete_gift_idea_Click);
            // 
            // edit_gift_idea
            // 
            this.edit_gift_idea.Location = new System.Drawing.Point(206, 326);
            this.edit_gift_idea.Name = "edit_gift_idea";
            this.edit_gift_idea.Size = new System.Drawing.Size(173, 50);
            this.edit_gift_idea.TabIndex = 19;
            this.edit_gift_idea.Text = "Edit Gift Idea";
            this.edit_gift_idea.UseVisualStyleBackColor = true;
            this.edit_gift_idea.Click += new System.EventHandler(this.edit_gift_idea_Click);
            // 
            // add_gift_idea
            // 
            this.add_gift_idea.Location = new System.Drawing.Point(206, 270);
            this.add_gift_idea.Name = "add_gift_idea";
            this.add_gift_idea.Size = new System.Drawing.Size(173, 50);
            this.add_gift_idea.TabIndex = 18;
            this.add_gift_idea.Text = "Add Gift Idea";
            this.add_gift_idea.UseVisualStyleBackColor = true;
            this.add_gift_idea.Click += new System.EventHandler(this.add_gift_idea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 69);
            this.button1.TabIndex = 21;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RecipientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.delete_gift_idea);
            this.Controls.Add(this.edit_gift_idea);
            this.Controls.Add(this.add_gift_idea);
            this.Controls.Add(this.gift_ideas);
            this.Controls.Add(this.delete_occasion_btn);
            this.Controls.Add(this.edit_occasion_btn);
            this.Controls.Add(this.occasions);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.add_occasion);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.contact_number);
            this.Controls.Add(this.address);
            this.Controls.Add(this.budget);
            this.Controls.Add(this.relationship);
            this.Controls.Add(this.recipient_name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RecipientDetails";
            this.Text = "RecipientDetails";
            this.Load += new System.EventHandler(this.RecipientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.occasions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gift_ideas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recipient_name;
        private System.Windows.Forms.TextBox relationship;
        private System.Windows.Forms.TextBox budget;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox contact_number;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button add_occasion;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.DataGridView occasions;
        private System.Windows.Forms.Button edit_occasion_btn;
        private System.Windows.Forms.Button delete_occasion_btn;
        private System.Windows.Forms.DataGridView gift_ideas;
        private System.Windows.Forms.Button delete_gift_idea;
        private System.Windows.Forms.Button edit_gift_idea;
        private System.Windows.Forms.Button add_gift_idea;
        private System.Windows.Forms.Button button1;
    }
}